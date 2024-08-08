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
        void Init(ILegoPortal portal);

        /// <summary>
        /// Returns the configuration control for the main window
        /// </summary>
        Control Control { get; }
    }
}
