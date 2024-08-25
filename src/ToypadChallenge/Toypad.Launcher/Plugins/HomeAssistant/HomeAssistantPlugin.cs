namespace Toypad.Launcher.Plugins.HomeAssistant
{
    [PluginDescription("Home Assistant", "Control your Smarthome with this Home Assistant Plugin")]
    internal sealed class HomeAssistantPlugin : Plugin<HomeAssistantConfiguration>
    {
        private readonly HomeAssistantControl _control = new();

        /// <inheritdoc />
        public override void Dispose()
        {
            _control.Dispose();
        }

        protected override HomeAssistantConfiguration GetDefaultConfiguration()
        {
            return new HomeAssistantConfiguration
            {
                HomeAssistantURL = "http://192.168.178.100:8123",
                HomeAssistantToken = "1234568901234567890"
            };
        }

        /// <inheritdoc />
        protected override void SetToypad(IToypad toypad)
        {
            _control._config = Configuration;
            _control.SetToypad(Toypad);
        }

        /// <inheritdoc />
        protected override void SetConfiguration(HomeAssistantConfiguration configuration)
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
