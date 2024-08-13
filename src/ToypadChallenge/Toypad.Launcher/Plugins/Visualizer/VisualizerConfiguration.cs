namespace Toypad.Launcher.Plugins.Visualizer
{
    /// <summary>
    /// Configuration for the visualizer plugin
    /// </summary>
    public sealed class VisualizerConfiguration : IConfiguration
    {
        /// <summary>
        /// Stores the target pad setting
        /// </summary>
        public Pad TargetPads { get; set; }

        /// <summary>
        /// Color for the solid color feature
        /// </summary>
        public Color SetColor { get; set; }

        /// <summary>
        /// Color for the flash feature
        /// </summary>
        public Color FlashColor { get; set; }

        /// <summary>
        /// ticks to set flash color on
        /// </summary>
        public byte FlashOn { get; set; }

        /// <summary>
        /// ticks to set flash color off
        /// </summary>
        public byte FlashOff { get; set; }

        /// <summary>
        /// number of cycles for the flash feature
        /// </summary>
        public byte FlashCycles { get; set; }

        /// <summary>
        /// Color for the fade feature
        /// </summary>
        public Color FadeColor { get; set; }

        /// <summary>
        /// ticks to fade color
        /// </summary>
        public byte FadeTime { get; set; }

        /// <summary>
        /// number of cycles for the fade feature
        /// </summary>
        public byte FadeCycles { get; set; }
    }
}
