namespace Toypad.Launcher.Plugins.MicrosoftTeams
{
    /// <summary>
    /// Plugin for the microsoft teams integration
    /// </summary>
    [PluginDescription("Microsoft Teams", "Integrates Microsoft Teams to link your figure with your colleagues. This is the super hero HQ.")]
    public sealed class MicrosoftTeamsPlugin : Plugin<MicrosoftTeamsConfiguration>
    {
        private MicrosoftTeamsControl _control;

        /// <inheritdoc />
        public override Control Control => _control;

        public MicrosoftTeamsPlugin()
        {
            _control = new MicrosoftTeamsControl();
        }

        /// <inheritdoc />
        public override void Dispose()
        {
            _control.Dispose();
        }

        /// <inheritdoc />
        protected override MicrosoftTeamsConfiguration GetDefaultConfiguration()
        {
            return new MicrosoftTeamsConfiguration();
        }

        /// <inheritdoc />
        protected override void SetConfiguration(MicrosoftTeamsConfiguration configuration)
        {
            
        }

        /// <inheritdoc />
        protected override void UpdateConfiguration()
        {
            
        }
    }
}
