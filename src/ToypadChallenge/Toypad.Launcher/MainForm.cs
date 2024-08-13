using System.ComponentModel;
using System.Reflection;
using Toypad.Launcher.Plugins;

namespace Toypad.Launcher
{
    /// <summary>
    /// Main window of the launcher application
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Optional reference to the emulator form, if the toypad is an emulator instance
        /// </summary>
        private readonly EmulatorForm? _emulator;

        /// <summary>
        /// Reference to the used toypad
        /// </summary>
        private readonly IToypad? _toypad;

        /// <summary>
        /// Local configuration
        /// </summary>
        private readonly AppConfiguration _appConfiguration;

        /// <summary>
        /// Collection of all known plugins
        /// </summary>
        private readonly List<(PluginDescriptionAttribute description, Type type)> _knownPlugins = new();

        public MainForm()
        {
            InitializeComponent();

            _emulator = null;
            _toypad = null;
            _appConfiguration = new AppConfiguration();

            // Scan for plugins
            var types = Assembly.GetCallingAssembly().GetTypes();
            foreach (var type in types)
            {
                if (!typeof(IPlugin).IsAssignableFrom(type))
                {
                    continue;
                }

                if (type.IsAbstract || type.IsInterface)
                {
                    continue;
                }

                var pluginDescription = type.GetCustomAttribute<PluginDescriptionAttribute>();
                if (pluginDescription is null)
                {
                    continue;
                }

                _knownPlugins.Add((pluginDescription, type));
            }

            // Adds new menu entries for creating plugins
            foreach (var pluginInformation in _knownPlugins.OrderBy(p => p.description.Name))
            {
                var menuItem = new ToolStripMenuItem
                {
                    Text = pluginInformation.description.Name,
                    ToolTipText = pluginInformation.description.Description,
                };

                // Build click event handler
                menuItem.Click += (s, e) =>
                {
                    // Create tab configuration
                    var config = new TabConfiguration
                    {
                        InstanceId = Guid.NewGuid(),
                        TypeName = pluginInformation.type.FullName,
                        Configuration = null,
                        Plugin = null
                    };

                    // Try to create plugin
                    config.Plugin = CreatePluginInstanceWithPage(pluginInformation.description, pluginInformation.type, config.Configuration);

                    _appConfiguration.TabConfigurations.Add(config);
                };

                createPluginMenuItem.DropDownItems.Add(menuItem);
            }
        }

        public MainForm(IToypad portal) : this()
        {
            _toypad = portal;
            emulatorButton.Visible = false;

            // In case we run with an emulator, enable infrastructure
            if (portal is EmulatorToypad emulatorToypad)
            {
                _emulator = new EmulatorForm(emulatorToypad);
                emulatorButton.Visible = true;
            }

            // Load configuration and create ready to go configured plugins
            _appConfiguration = AppConfiguration.Load();

            // Recreate tabs based on existing configuration
            foreach (var tabConfiguration in _appConfiguration.TabConfigurations)
            {
                // Lookup plugin information based on type
                var information = _knownPlugins.FirstOrDefault(p => p.type.FullName == tabConfiguration.TypeName);
                if (information.type is null)
                {
                    continue;
                }

                tabConfiguration.Plugin = CreatePluginInstanceWithPage(information.description, information.type, tabConfiguration.Configuration);
            }
        }

        /// <summary>
        /// Creates a new instance of a plugin and adds it to the tabs
        /// </summary>
        /// <param name="description">plugin description (used for tab title)</param>
        /// <param name="type">Plugin type</param>
        /// <param name="configuration">optional configuration string</param>
        private IPlugin CreatePluginInstanceWithPage(PluginDescriptionAttribute description, Type type, string? configuration)
        {
            // Create the plugin instance
            var plugin = (IPlugin)Activator.CreateInstance(type);
            plugin.Init(_toypad, configuration);

            // Prepare the tab page
            var page = new TabPage(description.Name);
            page.Tag = plugin;
            page.Controls.Add(plugin.Control);
            plugin.Control.Dock = DockStyle.Fill;

            // Add and select it
            tabControl.TabPages.Add(page);
            tabControl.SelectedTab = page;
            tabControl_SelectedIndexChanged(tabControl, EventArgs.Empty); // For some reason selection changed does not trigger on the first tab page, so we need to do this manually

            return plugin;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // Collect all configurations
            foreach (var tabConfiguration in _appConfiguration.TabConfigurations)
            {
                tabConfiguration.Configuration = tabConfiguration.Plugin.GetConfiguration();
            }

            // Shut down all plugins
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage.Tag is IPlugin plugin)
                {
                    // Remove UI
                    tabControl.TabPages.Remove(tabPage);

                    // Dispose plugin
                    plugin.Dispose();
                }
            }

            // Store away app configuration
            AppConfiguration.Save(_appConfiguration);

            _emulator?.Dispose();
            base.OnClosing(e);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Toggle emulator visibility if available
        /// </summary>
        private void emulatorButton_Click(object sender, EventArgs e)
        {
            if (_emulator is null)
            {
                return;
            }

            if (_emulator.Visible)
            {
                _emulator.Hide();
            }
            else
            {
                _emulator.Show();
            }
        }

        /// <summary>
        /// Handles a changed tab selection
        /// </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Only show remove plugin when there is an active tab selected
            removePluginMenuItem.Enabled = tabControl.SelectedIndex >= 0;
        }

        /// <summary>
        /// Removes the current selected plugin
        /// </summary>
        private void removePluginMenuItem_Click(object sender, EventArgs e)
        {
            // Get the affected plugin and stop if there is no
            var tab = tabControl.SelectedTab;
            if (tab is null || tab.Tag is not IPlugin plugin)
            {
                return;
            }

            // Select another tag (if we have more tabs on the right, take the next. if not, take the left. if there is none at all, unselect everything)
            var position = tabControl.TabPages.IndexOf(tab);
            if (tabControl.TabPages.Count > position + 1)
            {
                tabControl.SelectedIndex = position + 1;
            }
            else
            {
                tabControl.SelectedIndex = position - 1;
            }

            // Remove tab and dispose the plugin
            tabControl.TabPages.Remove(tab);

            // remove also the configuration for it
            var config = _appConfiguration.TabConfigurations.FirstOrDefault(c => c.Plugin == plugin);
            if (config is not null)
            {
                _appConfiguration.TabConfigurations.Remove(config);
            }

            plugin.Dispose();
        }
    }
}
