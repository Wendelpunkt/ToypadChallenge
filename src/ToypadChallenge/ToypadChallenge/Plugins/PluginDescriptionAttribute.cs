namespace ToypadChallenge.Plugins
{
    /// <summary>
    /// Decoration for all kind of plugins for a better discovery
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class PluginDescriptionAttribute(string name, string description) : Attribute
    {
        /// <summary>
        /// Display Name of the plugin
        /// </summary>
        public string Name { get; set; } = name;

        /// <summary>
        /// Additional description for the plugin
        /// </summary>
        public string Description { get; set; } = description;
    }
}
