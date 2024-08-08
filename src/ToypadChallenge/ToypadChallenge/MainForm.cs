using System.ComponentModel;
using LegoDimensions;
using LegoDimensions.Portal;
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

            _portal.SetColor(Pad.All, Color.Red);
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
