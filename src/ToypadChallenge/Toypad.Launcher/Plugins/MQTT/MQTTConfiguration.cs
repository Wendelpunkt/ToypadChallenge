namespace Toypad.Launcher.Plugins.MQTT
{
    /// <summary>
    /// Configuration for the visualizer plugin
    /// </summary>
    public sealed class MQTTConfiguration : IConfiguration
    {
        /// <summary>
        /// Stores the target pad setting
        /// </summary>
        public String MQTTHost { get; set; }
        
        public String MQTTUsername { get; set; }

        public String MQTTPassword { get; set; }

        public String MQTTPort { get; set; }

        public String MQTTTopic { get; set; }

        public String MQTTMessageType { get; set; }

    }
}
