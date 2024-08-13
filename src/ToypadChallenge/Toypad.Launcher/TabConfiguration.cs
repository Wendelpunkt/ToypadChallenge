using Newtonsoft.Json;
using Toypad.Launcher.Plugins;

namespace Toypad.Launcher
{
    /// <summary>
    /// Holds the configuration of a single plugin tab
    /// </summary>
    public sealed class TabConfiguration
    {
        /// <summary>
        /// Plugins full type name for a later lookup
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Serialized configuration for this plugin
        /// </summary>
        public string? Configuration { get; set; }

        /// <summary>
        /// Instance of the plugin (not serialized)
        /// </summary>
        [JsonIgnore]
        public IPlugin? Plugin { get; set; }
    }
}
