using Newtonsoft.Json;

namespace Toypad.Launcher.Plugins
{
    /// <summary>
    /// Base class for all plugins to handle common stuff like configuration serialization
    /// </summary>
    public abstract class Plugin : IPlugin
    {
        /// <summary>
        /// Local reference to the toypad
        /// </summary>
        protected IToypad Toypad { get; private set; } = new NullToypad();

        /// <inheritdoc />
        public virtual void Init(IToypad toypad, string? configuration)
        {
            Toypad = toypad;

            // Set the actual toypad instance
            SetToypad(toypad);
        }

        /// <inheritdoc />
        public abstract void Dispose();

        /// <summary>
        /// Gets a call when the toypad was set for the plugin
        /// </summary>
        /// <param name="toypad">reference to the toypad</param>
        protected abstract void SetToypad(IToypad toypad);

        /// <inheritdoc />
        public abstract string? GetConfiguration();

        /// <inheritdoc />
        public abstract Control Control { get; }
    }

    /// <summary>
    /// base class for all plugins with typed configuration
    /// </summary>
    /// <typeparam name="T">configuration type</typeparam>
    public abstract class Plugin<T> : Plugin where T : IConfiguration
    {
        /// <summary>
        /// Local configuration
        /// </summary>
        protected T Configuration { get; private set; }

        protected Plugin()
        {
            Configuration = GetDefaultConfiguration();
        }

        public override void Init(IToypad toypad, string? configurationString)
        {
            base.Init(toypad, configurationString);

            // Deserialize configuration
            Configuration = JsonConvert.DeserializeObject<T>(configurationString ?? "") ?? GetDefaultConfiguration();
            SetConfiguration(Configuration);
        }

        public override string? GetConfiguration()
        {
            UpdateConfiguration();

            // No config, no string
            if (Configuration is null)
            {
                return null;
            }

            // Serialize existing Config
            return JsonConvert.SerializeObject(Configuration);
        }

        /// <summary>
        /// Returns a default configuration in case there is none
        /// </summary>
        /// <returns>default config</returns>
        protected abstract T GetDefaultConfiguration();

        /// <summary>
        /// Sets an existing configuration for the plugin
        /// </summary>
        /// <param name="configuration">configuration</param>
        protected abstract void SetConfiguration(T configuration);

        /// <summary>
        /// Asks the plugin to update the configuration right before storing it away
        /// </summary>
        protected abstract void UpdateConfiguration();
    }
}
