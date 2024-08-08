using LegoDimensions;

namespace ToypadChallenge.Plugins
{
    /// <summary>
    /// Base interface for all plugins
    /// </summary>
    public interface IPlugin : IDisposable
    {
        /// <summary>
        /// Initializes the plugin and handover the portal instance
        /// </summary>
        /// <param name="portal">current portal instance</param>
        /// <param name="configuration">current configuration or nul if there is no</param>
        void Init(ILegoPortal portal, IConfiguration configuration);

        /// <summary>
        /// Returns the current configuration
        /// </summary>
        IConfiguration GetConfiguration();

        /// <summary>
        /// Returns the configuration control for the main window
        /// </summary>
        Control Control { get; }
    }
}
