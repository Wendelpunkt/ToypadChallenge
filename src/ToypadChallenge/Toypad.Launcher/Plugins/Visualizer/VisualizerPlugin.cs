
namespace Toypad.Launcher.Plugins.Visualizer
{
    /// <summary>
    /// Plugin to show up the current state of the pad in a visual way
    /// </summary>
    [PluginDescription("Pad visualizer", "Just shows up the current pad state")]
    internal sealed class VisualizerPlugin : Plugin<VisualizerConfiguration>
    {
        /// <summary>
        /// Local configuration control
        /// </summary>
        private readonly VisualizerControl _control = new();

        /// <inheritdoc />
        public override void Dispose()
        {
            _control.SetToypad(null);
            _control.Dispose();
        }

        /// <inheritdoc />
        protected override VisualizerConfiguration GetDefaultConfiguration()
        {
            return new VisualizerConfiguration
            {
                SetColor = Color.Red,
                FadeColor = Color.Blue,
                FadeTime = 10,
                FadeCycles = 4,
                FlashColor = Color.LawnGreen,
                FlashOn = 15,
                FlashOff = 20,
                FlashCycles = 4
            };
        }

        /// <inheritdoc />
        protected override void SetToypad(IToypad toypad)
        {
            _control.SetToypad(Toypad);
        }

        /// <inheritdoc />
        protected override void SetConfiguration(VisualizerConfiguration configuration)
        {
            _control.SetConfiguration(configuration);
        }

        /// <inheritdoc />
        protected override void UpdateConfiguration()
        {
            if (Configuration is null)
            {
                return;
            }

            _control.UpdateConfiguration(Configuration);
        }

        /// <inheritdoc />
        public override Control Control => _control;
    }
}
