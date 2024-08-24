using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace Toypad.Launcher.Plugins.MQTT
{
    public partial class MQTTControl : UserControl
    {
        public MQTTConfiguration _config;
        public MqttClient _client;

        public MQTTControl()
        {
            InitializeComponent();

            lbStatus.Text = "Loading plugin...";
        }

        private void PluginInit()
        {
            if (_client == null)
            {
                lbStatus.Text = "Connecting...";

                try
                {
                    _client = new MqttClient(_config.MQTTHost, Convert.ToInt32(_config.MQTTPort), false, null, null, MqttSslProtocols.None);
                    _client.Connect("toypad_" + Guid.NewGuid().ToString());
                    _client.ConnectionClosed += _client_ConnectionClosed;
                }
                catch (Exception ex)
                {
                    lbStatus.Text = ex.Message;
                }

                lbStatus.Text = "Connected";
            }
        }

        private void _client_ConnectionClosed(object sender, EventArgs e)
        {
            lbStatus.Text = "Connection closed...";
        }

        public void SetToypad(IToypad toypad)
        {
            toypad.TagAdded += ToypadOnTagAdded;
            toypad.TagRemoved += ToypadOnTagRemoved;
        }

        private void ToypadOnTagRemoved(object? sender, Tag tag)
        {

            if (_client != null)
            {
                if (cbMessageType.SelectedIndex == 0)
                {
                    string msg = "{ \"UID\": \"" + BitConverter.ToString(tag.Uid.ToArray()) + "\", \"event\": \"remove\" }";

                    _client.Publish(tbMQTTTopic.Text, Encoding.UTF8.GetBytes(msg));
                }
            }

            tbUID.Text = string.Empty;
        }

        private void ToypadOnTagAdded(object? sender, Tag tag)
        {
            if (_client != null)
            {
                if (cbMessageType.SelectedIndex == 0)
                {
                    string msg = "{ \"UID\": \"" + BitConverter.ToString(tag.Uid.ToArray()) + "\", \"event\": \"add\" }";

                    _client.Publish(tbMQTTTopic.Text, Encoding.UTF8.GetBytes(msg));
                }
                else
                {
                    _client.Publish(tbMQTTTopic.Text, Encoding.UTF8.GetBytes(BitConverter.ToString(tag.Uid.ToArray())));
                }
            }

            tbUID.Text = BitConverter.ToString(tag.Uid.ToArray());
        }

        public void SetConfiguration(MQTTConfiguration configuration)
        {
            _config = configuration;
            tbMQTTHost.Text = configuration.MQTTHost;
            tbMQTTPort.Text = configuration.MQTTPort;
            tbMQTTUsername.Text = configuration.MQTTUsername;
            tbMQTTPassword.Text = configuration.MQTTPassword;
            tbMQTTTopic.Text = configuration.MQTTTopic;
            cbMessageType.Text = configuration.MQTTMessageType;

            PluginInit();
        }

        /// <summary>
        /// Updates the configuration based on the UI settings
        /// </summary>
        public void UpdateConfiguration(MQTTConfiguration configuration)
        {
            _config = configuration;
            configuration.MQTTHost = tbMQTTHost.Text;
            configuration.MQTTPort = tbMQTTPort.Text;
            configuration.MQTTUsername = tbMQTTUsername.Text;
            configuration.MQTTPassword = tbMQTTPassword.Text;
            configuration.MQTTTopic = tbMQTTTopic.Text;
            configuration.MQTTMessageType = cbMessageType.Text;
        }
    }
}
