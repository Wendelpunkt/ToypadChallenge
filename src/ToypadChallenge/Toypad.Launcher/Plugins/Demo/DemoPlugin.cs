namespace Toypad.Launcher.Plugins.Demo
{
    [PluginDescription("Demo", "Just shows up the possibilities of plugins")]
    internal sealed class DemoPlugin : Plugin<DemoConfiguration>
    {
        private readonly DemoControl _control;

        public override Control Control => _control;

        private int _leftTags = 0;

        private int _rightTags = 0;

        private int _centerTags = 0;

        public DemoPlugin()
        {
            _control = new DemoControl();
        }

        public override void Dispose()
        {
            _control.Dispose();
        }

        protected override DemoConfiguration GetDefaultConfiguration()
        {
            return new DemoConfiguration
            {
                TestMessage = "Hallo Welt"
            };
        }

        protected override void SetConfiguration(DemoConfiguration configuration)
        {
            _control.messageTextBox.Text = configuration.TestMessage;
            
            _control.SetToypad(Toypad);
            Toypad.TagAdded += Toypad_TagAdded;
            Toypad.TagRemoved += Toypad_TagRemoved;
        }

        private void Toypad_TagRemoved(object? sender, Tag e)
        {
            switch (e.Pad)
            {
                case Pad.Left:
                    _leftTags--;
                    break;
                case Pad.Center:
                    _centerTags--;
                    break;
                case Pad.Right:
                    _rightTags--;
                    break;
            }

            SetColors(e.Pad);
        }

        private void Toypad_TagAdded(object? sender, Tag e)
        {
            switch (e.Pad)
            {
                case Pad.Left:
                    _leftTags++;
                    break;
                case Pad.Center:
                    _centerTags++;
                    break;
                case Pad.Right:
                    _rightTags++;
                    break;
            }

            SetColors(e.Pad);
        }

        private void SetColors(Pad pad)
        {
            int count = 0;
            switch (pad)
            {
                case Pad.Left:
                    count = _leftTags;
                    break;
                case Pad.Center:
                    count = _centerTags;
                    break;
                case Pad.Right:
                    count = _rightTags;
                    break;
            }

            if (count > 0)
            {
                Toypad.SetColor(pad, Color.Red);
            }
            else
            {
                Toypad.SetColor(pad, Color.Black);
            }
        }

        protected override void UpdateConfiguration()
        {
            Configuration.TestMessage = _control.messageTextBox.Text;
        }
    }
}
