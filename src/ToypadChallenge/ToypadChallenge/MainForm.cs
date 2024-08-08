using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection;
using LegoDimensions;
using LegoDimensions.Portal;
using ToypadChallenge.Plugins;
using Color = LegoDimensions.Color;

namespace ToypadChallenge
{
    public partial class MainForm : Form
    {
        private readonly EmulatorForm? _emulator;

        private readonly ILegoPortal? _portal;

        public MainForm()
        {
            InitializeComponent();

            _emulator = null;
            _portal = null;
        }

        public MainForm(ILegoPortal? portal) : this()
        {
            if (portal is null)
            {
                _emulator = new EmulatorForm();
                _portal = _emulator;

                emulatorButton.Visible = true;
            }
            else
            {
                _portal = portal;

                emulatorButton.Visible = false;
            }

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

                var menuItem = new ToolStripMenuItem()
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
            plugin.Init(_portal, null);

            var page = new TabPage(description.Name);
            page.Controls.Add(plugin.Control);
            plugin.Control.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(page);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _portal?.SetColor(Pad.All, Color.Black);
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
