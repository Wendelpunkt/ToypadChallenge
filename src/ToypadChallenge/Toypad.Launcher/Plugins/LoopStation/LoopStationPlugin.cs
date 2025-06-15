using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toypad.Launcher.Plugins.LoopStation
{
    /// <summary>
    /// Plugin to use toypad as a loop station
    /// </summary>
    [PluginDescription("LoopStation", "Allows to use the Toypad as a loop station")]
    internal sealed class LoopStationPlugin : Plugin<LoopStationConfiguration>
    {
        private readonly LoopStationControl _control;

        private LoopStationConfiguration _configuration;

        public LoopStationPlugin()
        {
            _control = new LoopStationControl();
        }

        public override void Dispose()
        {
            _control.Dispose();
        }

        protected override void SetToypad(IToypad toypad)
        {
        }

        public override Control Control => _control;

        protected override LoopStationConfiguration GetDefaultConfiguration()
        {
            return new LoopStationConfiguration();
        }

        protected override void SetConfiguration(LoopStationConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void UpdateConfiguration()
        {
        }
    }
}
