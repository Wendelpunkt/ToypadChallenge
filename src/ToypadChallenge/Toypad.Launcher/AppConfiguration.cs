using Newtonsoft.Json;

namespace Toypad.Launcher
{
    /// <summary>
    /// Holds the full application configuration to serialize it away to disk
    /// </summary>
    public sealed class AppConfiguration
    {
        /// <summary>
        /// remembers the latest selected tab
        /// </summary>
        public int SelectedTab { get; set; }

        /// <summary>
        /// Lists up all tab configurations
        /// </summary>
        public List<TabConfiguration> TabConfigurations { get; } = [];

        #region static load and store methods

        /// <summary>
        /// Loads the application settings from the disk
        /// </summary>
        /// <returns>application configuration</returns>
        public static AppConfiguration Load()
        {
            var path = GetConfigurationPath();

            // If file does not exist, just create a new configuration
            if (!File.Exists(path))
            {
                return new AppConfiguration();
            }

            try
            {
                var configurationString = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<AppConfiguration>(configurationString) ?? new AppConfiguration();
            }
            catch (Exception ex)
            {
                // In case something goes wrong, just create another new config here
                return new AppConfiguration();
            }
        }

        /// <summary>
        /// Stores the application configuration to the disk
        /// </summary>
        /// <param name="appConfiguration">application configuration</param>
        public static Task Save(AppConfiguration appConfiguration)
        {
            
            return File.WriteAllTextAsync(GetConfigurationPath(), JsonConvert.SerializeObject(appConfiguration));
        }

        /// <summary>
        /// Builds up the path to the application configuration file
        /// </summary>
        private static string GetConfigurationPath()
        {
            return @"d:\temp\launcher.config";
        }

        #endregion
    }
}
