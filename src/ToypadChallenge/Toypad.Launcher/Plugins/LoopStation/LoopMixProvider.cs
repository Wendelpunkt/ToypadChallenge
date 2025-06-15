using NAudio.Wave;

namespace Toypad.Launcher.Plugins.LoopStation
{
    internal sealed class LoopMixProvider : ISampleProvider
    {
        private readonly List<LoopTrack> _tracks = new();
        private readonly int _channels;
        private readonly int _loopLengthSamples;
        private long _samplePosition = 0;

        public LoopMixProvider(int sampleRate, int channels, int loopLengthSamples)
        {
            _channels = channels;
            _loopLengthSamples = loopLengthSamples;
            WaveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channels);
        }

        public LoopMixProvider(string masterTrack)
        {
            var track = CreateTrack(masterTrack);
            WaveFormat = track.WaveFormat;
            _channels = track.WaveFormat.Channels;
            _loopLengthSamples = track.Samples.Length / track.WaveFormat.Channels;
        }

        public static LoopTrack CreateTrack(string filename)
        {
            using var reader = new AudioFileReader(filename);
            var wholeFile = new List<float>();
            var buffer = new float[reader.WaveFormat.SampleRate * reader.WaveFormat.Channels];

            int read;
            while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
            {
                wholeFile.AddRange(buffer.Take(read));
            }

            return new LoopTrack(wholeFile.ToArray(), reader.WaveFormat);

        }

        public void Add(string filename)
        {
            var track = CreateTrack(filename);
            _tracks.Add(track);
        }

        public void Add(LoopTrack track)
        {
            _tracks.Add(track);
        }

        public int Read(float[] buffer, int offset, int count)
        {
            for (var n = 0; n < count; n += _channels)
            {
                var positionInLoop = (_samplePosition / _channels) % _loopLengthSamples;

                if (positionInLoop == 0)
                {
                    foreach (var t in _tracks)
                    {
                        t.IsActive = t.NextCycleActive;
                    }
                }

                for (var ch = 0; ch < _channels; ch++)
                {
                    var mixedSample = 0f;

                    foreach (var track in _tracks)
                    {
                        if (!track.IsActive) continue;

                        var sampleIndex = (positionInLoop * _channels) + ch;
                        if (sampleIndex < track.Samples.Length)
                        {
                            mixedSample += track.Samples[sampleIndex] * track.Volume;
                        }
                    }

                    buffer[offset + n + ch] = mixedSample;
                }

                _samplePosition += _channels;
            }

            return count;
        }

        public WaveFormat WaveFormat { get; }
    }
}
