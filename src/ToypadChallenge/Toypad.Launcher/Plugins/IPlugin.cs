﻿namespace Toypad.Launcher.Plugins
{
    /// <summary>
    /// Base interface for all plugins
    /// </summary>
    public interface IPlugin : IDisposable
    {
        /// <summary>
        /// Initializes the plugin and handover the portal instance
        /// </summary>
        /// <param name="toypad">current toypad instance</param>
        /// <param name="configuration">current configuration or nul if there is no</param>
        void Init(IToypad toypad, string? configuration);

        /// <summary>
        /// Returns the current configuration
        /// </summary>
        string? GetConfiguration();

        /// <summary>
        /// Returns the configuration control for the main window
        /// </summary>
        Control Control { get; }
    }
}
