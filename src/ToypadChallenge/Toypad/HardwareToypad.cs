using System.Collections.ObjectModel;
using System.ComponentModel;
using LegoDimensions;
using Color = System.Drawing.Color;

namespace Toypad
{
    /// <summary>
    /// Wrapper around an original toypad
    /// </summary>
    public sealed class HardwareToypad : IToypad
    {
        /// <summary>
        /// Local reference to the portal
        /// </summary>
        private readonly LegoPortal _portal;

        /// <summary>
        /// Internal list of all known tags
        /// </summary>
        private readonly ObservableCollection<Tag> _tags;

        public HardwareToypad(LegoPortal portal)
        {
            _portal = portal ?? throw new ArgumentNullException(nameof(portal));
            _portal.LegoTagEvent += PortalOnLegoTagEvent;
            LeftPanel = Color.Black;
            RightPanel = Color.Black;
            CenterPanel = Color.Black;

            _tags = new ObservableCollection<Tag>();

            // Add already existing tags
            foreach (var tag in _portal.PresentTags)
            {
                _tags.Add(new Tag(tag.Index, FromPad(tag.Pad), tag.CardUid));
            }
        }

        public void Dispose()
        {
            _portal.Dispose();
        }

        /// <summary>
        /// Handle changed tags
        /// </summary>
        private void PortalOnLegoTagEvent(object? sender, LegoTagEventArgs e)
        {
            if (e.Present)
            {
                var tag = new Tag(e.Index, FromPad(e.Pad), e.CardUid, e.LegoTag?.Name ?? "");
                _tags.Add(tag);
                TagAdded?.Invoke(this, tag);
            }
            else
            {
                var tag = _tags.FirstOrDefault(t => t.Index == e.Index);
                if (tag is not null)
                {
                    _tags.Remove(tag);
                    TagRemoved?.Invoke(this, tag);
                }
            }
        }

        /// <summary>
        /// Translates from internal pad enum to the external one
        /// </summary>
        /// <param name="pad"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private Pad FromPad(LegoDimensions.Portal.Pad pad)
        {
            switch (pad)
            {
                case LegoDimensions.Portal.Pad.Left:
                    return Pad.Left;
                case LegoDimensions.Portal.Pad.Center:
                    return Pad.Center;
                case LegoDimensions.Portal.Pad.Right: 
                    return Pad.Right;
                default:
                    throw new ArgumentException("Position makes no sense.");
            }
        }

        private Color _leftPanel;

        /// <inheritdoc />
        public Color LeftPanel
        {
            get => _leftPanel;
            set
            {
                if (_leftPanel != value)
                {
                    _leftPanel = value;
                    _portal.SetColor(LegoDimensions.Portal.Pad.Left, LegoDimensions.Color.FromArgb(value.ToArgb()));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LeftPanel)));
                }
            }
        }
        
        private Color _centerPanel;

        /// <inheritdoc />
        public Color CenterPanel
        {
            get => _centerPanel;
            set
            {
                if (_centerPanel != value)
                {
                    _centerPanel = value;
                    _portal.SetColor(LegoDimensions.Portal.Pad.Center, LegoDimensions.Color.FromArgb(value.ToArgb()));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CenterPanel)));
                }
            }
        }
        
        private Color _rightPanel;

        /// <inheritdoc />
        public Color RightPanel
        {
            get => _rightPanel;
            set
            {
                if (_rightPanel != value)
                {
                    _rightPanel = value;
                    _portal.SetColor(LegoDimensions.Portal.Pad.Right, LegoDimensions.Color.FromArgb(value.ToArgb()));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RightPanel)));
                }
            }
        }

        /// <inheritdoc />
        public IReadOnlyCollection<Tag> Tags => _tags.AsReadOnly();

        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <inheritdoc />
        public event EventHandler<Tag>? TagAdded;

        /// <inheritdoc />
        public event EventHandler<Tag>? TagRemoved;
    }
}
