using System.ComponentModel;

namespace Toypad.Launcher
{
    public partial class EmulatorForm : Form
    {
        private readonly EmulatorToypad? _toypad;

        public EmulatorForm()
        {
            InitializeComponent();
        }

        public EmulatorForm(EmulatorToypad toypad) : this()
        {
            _toypad = toypad;
            _toypad.PropertyChanged += ToypadOnPropertyChanged;

            leftPanel.BackColor = _toypad.LeftColor;
            centerPanel.BackColor = _toypad.CenterColor;
            rightPanel.BackColor = _toypad.RightColor;
        }

        private void ToypadOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(() =>
                {
                    switch (e.PropertyName)
                    {
                        case nameof(IToypad.LeftColor):
                            leftPanel.BackColor = _toypad?.LeftColor ?? Color.Black;
                            break;
                        case nameof(IToypad.RightColor):
                            rightPanel.BackColor = _toypad?.RightColor ?? Color.Black;
                            break;
                        case nameof(IToypad.CenterColor):
                            centerPanel.BackColor = _toypad?.CenterColor ?? Color.Black;
                            break;

                    }
                });
            }
            else
            {
                switch (e.PropertyName)
                {
                    case nameof(IToypad.LeftColor):
                        leftPanel.BackColor = _toypad?.LeftColor ?? Color.Black;
                        break;
                    case nameof(IToypad.RightColor):
                        rightPanel.BackColor = _toypad?.RightColor ?? Color.Black;
                        break;
                    case nameof(IToypad.CenterColor):
                        centerPanel.BackColor = _toypad?.CenterColor ?? Color.Black;
                        break;

                }
            }

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            e.Cancel = true;
            Hide();
        }
    }
}
