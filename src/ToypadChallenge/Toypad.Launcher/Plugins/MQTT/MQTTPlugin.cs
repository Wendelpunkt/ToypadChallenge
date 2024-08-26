

using System.Net;
using System.Text;
using System.Xml;
using uPLibrary.Networking.M2Mqtt;

namespace Toypad.Launcher.Plugins.MQTT
{
    /// <summary>
    /// Plugin to show up the current state of the pad in a visual way
    /// </summary>
    [PluginDescription("MQTT", "Control your Smarthome with MQTT")]
    internal sealed class MQTTPlugin : Plugin<MQTTConfiguration>
    {
        /// <summary>
        /// Local configuration control
        /// </summary>
        private readonly MQTTControl _control = new();

        /// <inheritdoc />
        public override void Dispose()
        {
            if (_control._client != null)
            {
                _control._client.Disconnect();
            }

            _control.Dispose();
        }

        /// <inheritdoc />
        protected override MQTTConfiguration GetDefaultConfiguration()
        {
            return new MQTTConfiguration
            {
                MQTTHost = "test.mosquitto.org",
                MQTTUsername = "",
                MQTTPassword = "",
                MQTTPort = "1883",
                MQTTTopic = "/toypad/",
                MQTTMessageType = "Add / Remove JSON"
            };
        }

        /// <inheritdoc />
        protected override void SetToypad(IToypad toypad)
        {
            _control._config = Configuration;
            _control.SetToypad(Toypad);
        }

        /// <inheritdoc />
        protected override void SetConfiguration(MQTTConfiguration configuration)
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
