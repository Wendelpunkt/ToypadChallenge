using Toypad;

namespace ToypadChallenge.Plugins.Visualizer
{
    public partial class TagControl : UserControl
    {
        public TagControl()
        {
            InitializeComponent();
        }

        public TagControl(Tag tag) : this()
        {
            Tag = tag;
            indexContent.Text = tag.Index.ToString();
            uidContent.Text = BitConverter.ToString(tag.Uid.ToArray());
            nameContent.Text = tag.DisplayName;
        }
    }
}
