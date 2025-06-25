namespace Toypad.Launcher.Plugins.LoopStation
{
    /// <summary>
    /// Configuration set for the loop station
    /// </summary>
    public sealed class LoopStationConfiguration : IConfiguration
    {
        public Guid? SelectedPreset { get; set; }

        public List<LoopStationPreset> Presets { get; set; }

        public LoopStationConfiguration()
        {
            Presets = new List<LoopStationPreset>();
        }

        public sealed class LoopStationPreset
        {
            public Guid Id { get; set; }

            public string Name { get; set; }

            public List<LoopStationSample> Samples { get; set; }

            public LoopStationPreset()
            {
                Name = "New preset";
                Samples = new List<LoopStationSample>();
            }
        }

        public sealed class LoopStationSample
        {
            public string Name { get; set; }

            public string Filename { get; set; }

            public Pad Pad { get; set; }

            public byte[]? Token { get; set; }
        }

    }
}
