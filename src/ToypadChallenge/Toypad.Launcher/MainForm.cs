using System.ComponentModel;
using System.Reflection;
using Toypad.Launcher.Plugins;

namespace Toypad.Launcher
{
    public partial class MainForm : Form
    {
        private readonly EmulatorForm? _emulator;

        private readonly IToypad? _toypad;

        public MainForm()
        {
            InitializeComponent();

            _emulator = null;
            _toypad = null;
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

                var menuItem = new ToolStripMenuItem
                {
                    Text = pluginDescription.Name,
                    ToolTipText = pluginDescription.Description,
                    Tag = type
                };

                menuItem.Click += (s, e) =>
                {
                    AddPlugin(pluginDescription, type);
                };

                pluginItem.DropDownItems.Add(menuItem);
            }
        }

        private void AddPlugin(PluginDescriptionAttribute description, Type type)
        {
            var plugin = (IPlugin)Activator.CreateInstance(type);
            plugin.Init(_toypad, null);

            var page = new TabPage(description.Name);
            page.Controls.Add(plugin.Control);
            plugin.Control.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(page);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
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
    }
}
