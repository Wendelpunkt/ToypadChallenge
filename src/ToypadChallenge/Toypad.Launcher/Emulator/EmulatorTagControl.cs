namespace Toypad.Launcher.Emulator
{
    public partial class EmulatorTagControl : UserControl
    {
        public Pad Position { get; set; }

        public byte[] Uid { get; private set; }

        public string DisplayName { get; private set; }

        public EmulatorTagControl()
        {
            InitializeComponent();
            Uid = Array.Empty<byte>();
            DisplayName = "Unknown";
        }

        public EmulatorTagControl(byte[] uid, string displayName) : this()
        {
            Uid = uid;
            DisplayName = displayName;

            uidLabel.Text = BitConverter.ToString(uid).Replace("-", "");
            nameLabel.Text = displayName;
        }

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this, DragDropEffects.Move);
        }
    }
}
