using System.ComponentModel;
using System.Drawing;

namespace Toypad
{
    /// <summary>
    /// Base class for all toypads
    /// </summary>
    public abstract class Toypad : IToypad
    {
        /// <summary>
        /// Internal list of all known tags
        /// </summary>
        private readonly List<Tag> _tags;

        public IReadOnlyCollection<Tag> Tags => _tags.AsReadOnly();


        protected Toypad()
        {
            _tags = new List<Tag>();
        }

        public void Dispose()
        {
        }

        private Color _leftPanel;

        /// <inheritdoc />
        public Color LeftPanel
        {
            get => _leftPanel;
            protected set
            {
                if (_leftPanel != value)
                {
                    _leftPanel = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LeftPanel)));
                }
            }
        }
        
        private Color _centerPanel;

        /// <inheritdoc />
        public Color CenterPanel
        {
            get => _centerPanel;
            protected set
            {
                if (_centerPanel != value)
                {
                    _centerPanel = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CenterPanel)));
                }
            }
        }
        
        private Color _rightPanel;

        /// <inheritdoc />
        public Color RightPanel
        {
            get => _rightPanel;
            protected set
            {
                if (_rightPanel != value)
                {
                    _rightPanel = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RightPanel)));
                }
            }
        }

        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <inheritdoc />
        public event EventHandler<Tag>? TagAdded;
        
        /// <inheritdoc />
        public event EventHandler<Tag>? TagRemoved;
    }
}
