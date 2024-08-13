namespace Toypad.Launcher.Plugins.Visualizer
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

        /// <summary>
        /// Copies the uid into the clipboard when click on the label
        /// </summary>
        private void uidContent_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(uidContent.Text);
        }
    }
}
