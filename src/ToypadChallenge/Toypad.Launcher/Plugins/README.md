# Plugin Folder

This is the central place for putting your plugin.

* Create a new folder named after your plugin function (e.g. "Spotify")
* Create a new class for holding configuration information (e.g. "SpotifyConfiguration") and implement "IConfiguration" here
* Create a WinForms UserControl to hold the Plugin UI
* Create a third file which is the actual plugin class (e.g. "SpotifyPlugin")
* Decorate the class with the "PluginDescriptionAttribute" to give it a display name and a display description. This is what the application shows up in the plugin selector.
* Inherit from Plugin<T> and place your configuration class as T (e.g. "SpotifyPlugin : Plugin<SpotifyConfiguration>")
* Implement all abstract methods and do, whatever your plugin should do
