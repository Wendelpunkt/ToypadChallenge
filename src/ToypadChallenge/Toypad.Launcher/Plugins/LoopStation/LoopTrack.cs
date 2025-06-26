
using NAudio.Wave;

namespace Toypad.Launcher.Plugins.LoopStation
{
    internal sealed class LoopTrack
    {
        public float[] Samples;
        public bool IsActive = false;
        public bool NextCycleActive = false;
        public float Volume = 1.0f;
        public WaveFormat WaveFormat;

        public string Name;
        public Pad Pad;
        public byte[] Token;

        public LoopTrack(string name, float[] samples, WaveFormat format, Pad pad, byte[] token)
        {
            Name = name;
            Samples = samples;
            WaveFormat = format;
            Pad = pad;
            Token = token;
        }
    }
}
