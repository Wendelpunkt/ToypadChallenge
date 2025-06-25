namespace Toypad.Launcher.Plugins.LoopStation
{
    public partial class EditPresetDialog : Form
    {
        private readonly IToypad? _toypad;

        private readonly LoopStationConfiguration.LoopStationPreset _preset;

        public EditPresetDialog()
        {
            _preset = new LoopStationConfiguration.LoopStationPreset
            {
                Id = Guid.NewGuid(),
                Name = "New preset",
                Samples = new List<LoopStationConfiguration.LoopStationSample>()
            };

            InitializeComponent();
            ApplyFromPreset();
        }

        public EditPresetDialog(IToypad toypad, LoopStationConfiguration.LoopStationPreset preset)
        {
            _preset = preset;
            _toypad = toypad;

            InitializeComponent();
            ApplyFromPreset();
        }

        private void ApplyFromPreset()
        {
            tbName.Text = _preset.Name;

            listSamples.Items.Clear();
            foreach (var sample in _preset.Samples)
            {
                var item = new ListViewItem
                {
                    Tag = sample,
                    Text = sample.Name
                };

                item.SubItems.Add(sample.Filename);
                item.SubItems.Add(sample.Pad.ToString());

                listSamples.Items.Add(item);
            }
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            if (listSamples.SelectedItems.Count > 0)
            {
                if (_targetItem is null)
                {
                    // No learn mode yet - start learn
                    StartToLearn(listSamples.SelectedItems[0]);
                }
                else
                {
                    // Already learning - stop learn
                    StopLearn();
                }
            }
        }

        private void listSamples_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopLearn();
            var hasItems = listSamples.SelectedItems.Count > 0;
            var hasMultipleItems = listSamples.SelectedItems.Count > 1;
            var hasBoundItems = false;
            foreach (ListViewItem selectedItem in listSamples.SelectedItems)
            {
                if (selectedItem.Tag is LoopStationConfiguration.LoopStationSample { Token: not null })
                {
                    hasBoundItems = true;
                }
            }

            btnRemove.Enabled = hasItems;
            btnUnlearn.Enabled = hasBoundItems;
            btnLearn.Enabled = hasItems && !hasMultipleItems && _toypad is not null;
        }

        private void btnUnlearn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listSamples.SelectedItems)
            {
                if (selectedItem.Tag is LoopStationConfiguration.LoopStationSample sample)
                {
                    sample.Token = null;
                    sample.Pad = Pad.None;
                }

                selectedItem.SubItems[1].Text = nameof(Pad.None);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                foreach (var file in openFileDialog.FileNames)
                {
                    var fileInfo = new FileInfo(file);
                    if (fileInfo.Exists)
                    {
                        var sample =
                            new LoopStationConfiguration.LoopStationSample
                            {
                                Name = fileInfo.Name,
                                Filename = fileInfo.FullName,
                                Pad = Pad.None,
                                Token = null
                            };

                        var listItem = new ListViewItem
                        {
                            Text = sample.Name,
                            Tag = sample
                        };

                        listItem.SubItems.Add(sample.Filename);
                        listItem.SubItems.Add(sample.Pad.ToString());

                        listSamples.Items.Add(listItem);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var itemsToRemove = new List<ListViewItem>();
            foreach (ListViewItem selectedItem in listSamples.SelectedItems)
            {
                itemsToRemove.Add(selectedItem);
            }

            foreach (var item in itemsToRemove)
            {
                listSamples.Items.Remove(item);
            }
        }

        private ListViewItem? _targetItem;

        private void StartToLearn(ListViewItem listItem)
        {
            if (_toypad is null)
            {
                return;
            }

            _targetItem = listItem;
            _toypad.TagAdded += _toypad_TagAdded;
            btnLearn.BackColor = Color.LightGreen;
        }

        private void _toypad_TagAdded(object? sender, Tag e)
        {
            if (_targetItem is not null)
            {
                // Apply new tag
                if (_targetItem.Tag is LoopStationConfiguration.LoopStationSample sample)
                {
                    sample.Pad = e.Pad;
                    sample.Token = e.Uid.ToArray();
                }

                _targetItem.SubItems[1].Text = e.Pad.ToString();
            }

            StopLearn();
        }

        private void StopLearn()
        {
            if (_toypad is null)
            {
                return;
            }

            _targetItem = null;
            _toypad.TagAdded -= _toypad_TagAdded;
            btnLearn.BackColor = btnAdd.BackColor;
        }

        private void EditPresetDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                _preset.Name = tbName.Text;
                _preset.Samples.Clear();
                foreach (ListViewItem item in listSamples.Items)
                {
                    if (item.Tag is LoopStationConfiguration.LoopStationSample sample)
                    {
                        _preset.Samples.Add(sample);
                    }
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
        }
    }
}
