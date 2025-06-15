
using NAudio.Wave;

namespace Toypad.Launcher.Plugins.LoopStation
{
    internal sealed class LoopTrack
    {
        public float[] Samples;
        public bool IsActive = true;
        public bool NextCycleActive = true;
        public float Volume = 1.0f;
        public WaveFormat WaveFormat;

        public LoopTrack(float[] samples, WaveFormat format)
        {
            Samples = samples;
            WaveFormat = format;
        }
    }
}
