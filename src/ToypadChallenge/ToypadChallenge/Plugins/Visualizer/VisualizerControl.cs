using System.ComponentModel;
using Toypad;

namespace ToypadChallenge.Plugins.Visualizer
{
    public partial class VisualizerControl : UserControl
    {
        private IToypad? _toypad;

        public VisualizerControl()
        {
            _toypad = null;
            InitializeComponent();
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
                SetColor(Pad.Left, _toypad.LeftPanel);
                SetColor(Pad.Center, _toypad.CenterPanel);
                SetColor(Pad.Right, _toypad.RightPanel);
            }
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
            var toypad = sender as IToypad;
            if (toypad != null)
            {
                switch (e.PropertyName)
                {
                    case nameof(IToypad.LeftPanel):
                        SetColor(Pad.Left, toypad.LeftPanel);
                        break;
                    case nameof(IToypad.CenterPanel):
                        SetColor(Pad.Center, toypad.CenterPanel);
                        break;
                    case nameof(IToypad.RightPanel):
                        SetColor(Pad.Center, toypad.RightPanel);
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
    }
}
