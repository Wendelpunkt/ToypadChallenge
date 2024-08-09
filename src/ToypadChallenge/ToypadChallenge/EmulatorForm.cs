using LegoDimensions;
using LegoDimensions.Portal;
using Color = LegoDimensions.Color;

namespace ToypadChallenge
{
    public partial class EmulatorForm : Form, ILegoPortal
    {
        public EmulatorForm()
        {
            InitializeComponent();
        }

        public void WakeUp()
        {
            throw new NotImplementedException();
        }

        public void SetColor(Pad pad, Color color)
        {
            switch (pad)
            {
                case Pad.Left:
                    leftPanel.BackColor = System.Drawing.Color.FromArgb(color.ToArgb());
                    break;
                case Pad.Right:
                    rightPanel.BackColor = System.Drawing.Color.FromArgb(color.ToArgb());
                    break;
                case Pad.Center:
                    middlePanel.BackColor = System.Drawing.Color.FromArgb(color.ToArgb());
                    break;
                case Pad.All:
                    leftPanel.BackColor = System.Drawing.Color.FromArgb(color.ToArgb());
                    rightPanel.BackColor = System.Drawing.Color.FromArgb(color.ToArgb());
                    middlePanel.BackColor = System.Drawing.Color.FromArgb(color.ToArgb());
                    break;
            }
        }

        public Color GetColor(Pad pad)
        {
            throw new NotImplementedException();
        }

        public void SetColorAll(Color padCenter, Color padLeft, Color padRight)
        {
            throw new NotImplementedException();
        }

        public void SwitchOffAll()
        {
            throw new NotImplementedException();
        }

        public void Flash(Pad pad, FlashPad flashPad)
        {
            throw new NotImplementedException();
        }

        public void FlashAll(FlashPad flashPadCenter, FlashPad flashPadLeft, FlashPad flashPadRight)
        {
            throw new NotImplementedException();
        }

        public void Fade(Pad pad, FadePad fadePad)
        {
            throw new NotImplementedException();
        }

        public void FadeAll(FadePad fadePadCenter, FadePad fadePadLeft, FadePad fadePadRight)
        {
            throw new NotImplementedException();
        }

        public void FadeRandom(Pad pad, byte tickTime, byte tickCount)
        {
            throw new NotImplementedException();
        }

        public bool NfcEnabled { get; set; }
        public bool GetTagDetails { get; set; }
        public event EventHandler<LegoTagEventArgs>? LegoTagEvent;
    }
}
