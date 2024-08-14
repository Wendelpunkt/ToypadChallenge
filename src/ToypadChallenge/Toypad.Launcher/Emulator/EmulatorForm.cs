using System.ComponentModel;

namespace Toypad.Launcher.Emulator
{
    public partial class EmulatorForm : Form
    {
        private readonly EmulatorToypad? _toypad;

        private readonly List<string> _knownUids = new();

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

        /// <summary>
        /// Configures the emulator based on the given configuration
        /// </summary>
        public void SetConfiguration(EmulatorConfiguration configuration)
        {
            foreach (var tag in configuration.Tags)
            {
                var tagControl = new EmulatorTagControl(tag.Uid.ToArray(), tag.DisplayName);
                _knownUids.Add(BitConverter.ToString(tagControl.Uid));
                switch (tag.Pad)
                {
                    case Pad.None:
                        tagFlow.Controls.Add(tagControl);
                        break;
                    case Pad.Left:
                        leftFlow.Controls.Add(tagControl);
                        _toypad?.AddEmulatedTag(Pad.Left, tag.Uid.ToArray(), tag.DisplayName);
                        break;
                    case Pad.Center:
                        centerFlow.Controls.Add(tagControl);
                        _toypad?.AddEmulatedTag(Pad.Center, tag.Uid.ToArray(), tag.DisplayName);
                        break;
                    case Pad.Right:
                        rightFlow.Controls.Add(tagControl);
                        _toypad?.AddEmulatedTag(Pad.Right, tag.Uid.ToArray(), tag.DisplayName);
                        break;
                }
            }
        }

        /// <summary>
        /// Collects all emulator configuration infos and returns it as configuration
        /// </summary>
        public EmulatorConfiguration GetConfiguration() =>
            new()
            {
                Tags = CollectTags(tagFlow, Pad.None)
                    .Union(CollectTags(leftFlow, Pad.Left))
                    .Union(CollectTags(centerFlow, Pad.Center))
                    .Union(CollectTags(rightFlow, Pad.Right))
                    .ToList()
            };

        /// <summary>
        /// Collects the tags from the given flow control
        /// </summary>
        private IEnumerable<Tag> CollectTags(FlowLayoutPanel panel, Pad position)
        {
            foreach (var control in panel.Controls)
            {
                if (control is not EmulatorTagControl tagControl)
                {
                    continue;
                }

                yield return new Tag(0, position, tagControl.Uid, tagControl.DisplayName);
            }
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

        private void toypadPanel_Paint(object? sender, PaintEventArgs e)
        {
            using var brush = new SolidBrush(Color.FromArgb(100, 100, 100));

            DrawCircles(e.Graphics, brush, 30, 30);
            DrawCircles(e.Graphics, brush, toypadPanel.Width - 60, 30);
        }

        private void DrawCircles(Graphics g, Brush b, int offsetX, int offsetY)
        {
            int size = 11;

            g.FillEllipse(b, offsetX, offsetY, size, size);
            g.FillEllipse(b, offsetX + 15, offsetY, size, size);
            g.FillEllipse(b, offsetX, offsetY + 15, size, size);
            g.FillEllipse(b, offsetX + 15, offsetY + 15, size, size);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            byte[] uid = new byte[7];
            rand.NextBytes(uid);

            uidTextbox.Text = BitConverter.ToString(uid);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            byte[] uid;
            try
            {
                uid = Convert.FromHexString(uidTextbox.Text.Replace("-", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not parse uid. {ex.Message}");
                return;
            }

            if (uid.Length != 7)
            {
                MessageBox.Show("Uid has not the right length. Should be 7 bytes.");
                return;
            }

            var control = new EmulatorTagControl(uid, nameTextbox.Text);

            var uidString = BitConverter.ToString(uid);
            if (_knownUids.Contains(uidString))
            {
                MessageBox.Show("UID already exists");
                return;
            }

            _knownUids.Add(uidString);

            tagFlow.Controls.Add(control);
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void leftFlow_DragDrop(object sender, DragEventArgs e)
        {
            var control = e.Data?.GetData(typeof(EmulatorTagControl)) as EmulatorTagControl;
            MoveTag(control, Pad.Left);
        }

        private void binPanel_DragDrop(object sender, DragEventArgs e)
        {
            var control = e.Data?.GetData(typeof(EmulatorTagControl)) as EmulatorTagControl;
            MoveTag(control, null);
        }

        private void rightFlow_DragDrop(object sender, DragEventArgs e)
        {
            var control = e.Data?.GetData(typeof(EmulatorTagControl)) as EmulatorTagControl;
            MoveTag(control, Pad.Right);
        }

        private void centerFlow_DragDrop(object sender, DragEventArgs e)
        {
            var control = e.Data?.GetData(typeof(EmulatorTagControl)) as EmulatorTagControl;
            MoveTag(control, Pad.Center);
        }

        private void tagFlow_DragDrop(object sender, DragEventArgs e)
        {
            var control = e.Data?.GetData(typeof(EmulatorTagControl)) as EmulatorTagControl;
            MoveTag(control, Pad.None);
        }

        private void MoveTag(EmulatorTagControl? tag, Pad? target)
        {
            if (tag is null || tag.Position == target)
            {
                return;
            }

            // Limit to maximum number of tags per pad
            switch (target)
            {
                case Pad.Left:
                    if (leftFlow.Controls.Count >= 4)
                    {
                        MessageBox.Show("Can not move tag. Too many tags on the left pad");
                        return;
                    }
                    break;
                case Pad.Center:
                    if (centerFlow.Controls.Count >= 1)
                    {
                        MessageBox.Show("Can not move tag. Too many tags on the center pad");
                        return;
                    }
                    break;
                case Pad.Right:
                    if (rightFlow.Controls.Count >= 4)
                    {
                        MessageBox.Show("Can not move tag. Too many tags on the right pad");
                        return;
                    }
                    break;
            }

            // remove tag from old panel
            switch (tag.Position)
            {
                case Pad.None:
                    tagFlow.Controls.Remove(tag);
                    _toypad?.RemoveEmulatedTag(tag.Uid);
                    break;
                case Pad.Left:
                    leftFlow.Controls.Remove(tag);
                    _toypad?.RemoveEmulatedTag(tag.Uid);
                    break;
                case Pad.Center:
                    centerFlow.Controls.Remove(tag);
                    _toypad?.RemoveEmulatedTag(tag.Uid);
                    break;
                case Pad.Right:
                    rightFlow.Controls.Remove(tag);
                    _toypad?.RemoveEmulatedTag(tag.Uid);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            // Stop here when bin
            if (target is null)
            {
                _knownUids.Remove(BitConverter.ToString(tag.Uid));
                _toypad?.RemoveEmulatedTag(tag.Uid);
                tag.Dispose();
                return;
            }

            // add to new panel
            switch (target)
            {
                case Pad.None:
                    tagFlow.Controls.Add(tag);
                    tag.Position = Pad.None;
                    break;
                case Pad.Left:
                    leftFlow.Controls.Add(tag);
                    tag.Position = Pad.Left;
                    _toypad?.AddEmulatedTag(Pad.Left, tag.Uid, tag.DisplayName);
                    break;
                case Pad.Center:
                    centerFlow.Controls.Add(tag);
                    tag.Position = Pad.Center;
                    _toypad?.AddEmulatedTag(Pad.Center, tag.Uid, tag.DisplayName);
                    break;
                case Pad.Right:
                    rightFlow.Controls.Add(tag);
                    tag.Position = Pad.Right;
                    _toypad?.AddEmulatedTag(Pad.Right, tag.Uid, tag.DisplayName);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(target), target, null);
            }
        }

    }
}
