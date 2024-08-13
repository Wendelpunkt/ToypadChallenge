using System.ComponentModel;

namespace Toypad.Launcher.Plugins.Visualizer
{
    public partial class VisualizerControl : UserControl
    {
        private IToypad? _toypad;

        public VisualizerControl()
        {
            _toypad = null;
            InitializeComponent();

            padPicker.Items.Add(Pad.Left);
            padPicker.Items.Add(Pad.Center);
            padPicker.Items.Add(Pad.Right);
            padPicker.Items.Add(Pad.All);
            padPicker.SelectedIndex = 3;
        }

        /// <summary>
        /// Sets the toypad reference for the control
        /// </summary>
        public void SetToypad(IToypad? toypad)
        {
            // Do nothing when instance is the same
            if (_toypad == toypad)
            {
                return;
            }

            // Remove event handler from old portal
            if (_toypad is not null)
            {
                _toypad.PropertyChanged -= ToypadOnPropertyChanged;
                _toypad.TagAdded -= ToypadOnTagAdded;
                _toypad.TagRemoved -= ToypadOnTagRemoved;
            }

            _toypad = toypad;

            // Att event handler for the new portal
            if (_toypad is not null)
            {
                _toypad.PropertyChanged += ToypadOnPropertyChanged;
                _toypad.TagAdded += ToypadOnTagAdded;
                _toypad.TagRemoved += ToypadOnTagRemoved;

                // Add already existing tags
                foreach (var tag in _toypad.Tags)
                {
                    ToypadOnTagAdded(_toypad, tag);
                }

                // Bring current color to the panels
                SetColor(Pad.Left, _toypad.LeftColor);
                SetColor(Pad.Center, _toypad.CenterColor);
                SetColor(Pad.Right, _toypad.RightColor);
            }
        }

        /// <summary>
        /// Sets the given configuration for the UI
        /// </summary>
        public void SetConfiguration(VisualizerConfiguration configuration)
        {
            setColorPanel.BackColor = configuration.SetColor;
            flashColorPanel.BackColor = configuration.FlashColor;
            flashOnTextbox.Value = configuration.FlashOn;
            flashOffTextbox.Value = configuration.FlashOff;
            flashCyclesTextbox.Value = configuration.FlashCycles;
            fadeColorPanel.BackColor = configuration.FadeColor;
            fadeTimeTextbox.Value = configuration.FadeTime;
            fadeCycleTextbox.Value = configuration.FadeCycles;
        }

        /// <summary>
        /// Updates the configuration based on the UI settings
        /// </summary>
        public void UpdateConfiguration(VisualizerConfiguration configuration)
        {
            configuration.SetColor = setColorPanel.BackColor;
            configuration.FlashColor = flashColorPanel.BackColor;
            configuration.FlashOn = (byte)flashOnTextbox.Value;
            configuration.FlashOff = (byte)flashOffTextbox.Value;
            configuration.FlashCycles = (byte)flashCyclesTextbox.Value;
            configuration.FadeColor = fadeColorPanel.BackColor;
            configuration.FadeTime = (byte)fadeTimeTextbox.Value;
            configuration.FadeCycles = (byte)fadeCycleTextbox.Value;
        }

        private void ToypadOnTagRemoved(object? sender, Tag tag)
        {
            if (InvokeRequired)
            {
                Invoke(() =>
                {
                    Remove(tag);
                });
            }
            else
            {
                Remove(tag);
            }
        }

        private void ToypadOnTagAdded(object? sender, Tag tag)
        {
            if (InvokeRequired)
            {
                Invoke(() =>
                {
                    Add(tag);
                });
            }
            else
            {
                Add(tag);
            }
        }

        private void Add(Tag tag)
        {
            switch (tag.Pad)
            {
                case Pad.Left:
                    leftFlow.Controls.Add(new TagControl(tag));
                    break;
                case Pad.Right:
                    rightFlow.Controls.Add(new TagControl(tag));
                    break;
                case Pad.Center:
                    centerFlow.Controls.Add(new TagControl(tag));
                    break;
            }
        }

        private void Remove(Tag tag)
        {
            switch (tag.Pad)
            {
                case Pad.Left:
                    var leftControl = FindControl(leftFlow, tag);
                    if (leftControl is not null)
                    {
                        leftFlow.Controls.Remove(leftControl);
                    }
                    break;
                case Pad.Right:
                    var rightControl = FindControl(rightFlow, tag);
                    if (rightControl is not null)
                    {
                        rightFlow.Controls.Remove(rightControl);
                    }
                    break;
                case Pad.Center:
                    var centerControl = FindControl(centerFlow, tag);
                    if (centerControl is not null)
                    {
                        centerFlow.Controls.Remove(centerControl);
                    }
                    break;
            }
        }

        private TagControl? FindControl(FlowLayoutPanel panel, Tag tag)
        {
            foreach (var control in panel.Controls)
            {
                if (control is TagControl tagControl && tagControl.Tag == tag)
                {
                    return tagControl;
                }
            }

            return null;
        }

        /// <summary>
        /// Event handler for changed properties
        /// </summary>
        private void ToypadOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (sender is IToypad toypad)
            {
                switch (e.PropertyName)
                {
                    case nameof(IToypad.LeftColor):
                        SetColor(Pad.Left, toypad.LeftColor);
                        break;
                    case nameof(IToypad.CenterColor):
                        SetColor(Pad.Center, toypad.CenterColor);
                        break;
                    case nameof(IToypad.RightColor):
                        SetColor(Pad.Right, toypad.RightColor);
                        break;
                }
            }
        }

        private void SetColor(Pad pad, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(() =>
                {
                    switch (pad)
                    {
                        case Pad.Left:
                            leftPanel.BackColor = color;
                            break;
                        case Pad.Center:
                            centerPanel.BackColor = color;
                            break;
                        case Pad.Right:
                            rightPanel.BackColor = color;
                            break;
                    }
                });
            }
            else
            {
                switch (pad)
                {
                    case Pad.Left:
                        leftPanel.BackColor = color;
                        break;
                    case Pad.Center:
                        centerPanel.BackColor = color;
                        break;
                    case Pad.Right:
                        rightPanel.BackColor = color;
                        break;
                }
            }
        }

        private Pad SelectedPad()
        {
            switch (padPicker.SelectedIndex)
            {
                case 0: return Pad.Left;
                case 1: return Pad.Center;
                case 2: return Pad.Right;
                case 3: return Pad.All;
                default: throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Changes the color of the set color panel
        /// </summary>
        private void setPanel_Click(object sender, EventArgs e)
        {
            colorDialog.Color = setColorPanel.BackColor;
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                setColorPanel.BackColor = colorDialog.Color;
            }
        }

        /// <summary>
        /// Changes the color of the flash effect panel
        /// </summary>
        private void flashColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog.Color = flashColorPanel.BackColor;
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                flashColorPanel.BackColor = colorDialog.Color;
            }
        }

        /// <summary>
        /// Changes the color of the fade effect panel
        /// </summary>
        private void fadeColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog.Color = fadeColorPanel.BackColor;
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                fadeColorPanel.BackColor = colorDialog.Color;
            }
        }

        private void setColorButton_Click(object sender, EventArgs e)
        {
            _toypad?.SetColor(SelectedPad(), setColorPanel.BackColor);
        }

        private void flashButton_Click(object sender, EventArgs e)
        {
            _toypad?.FlashColor(SelectedPad(),
                flashColorPanel.BackColor,
                (byte)flashOnTextbox.Value,
                (byte)flashOffTextbox.Value,
                (byte)flashCyclesTextbox.Value);
        }

        private void fadeButton_Click(object sender, EventArgs e)
        {
            _toypad?.FadeColor(SelectedPad(), 
                fadeColorPanel.BackColor, 
                (byte)fadeTimeTextbox.Value, 
                (byte)fadeCycleTextbox.Value);
        }
    }
}
