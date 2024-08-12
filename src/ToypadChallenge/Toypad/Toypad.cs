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
            LeftColor = Color.Black;
            RightColor = Color.Black;
            CenterColor = Color.Black;
        }

        public void Dispose()
        {
            OnDispose();
        }

        /// <summary>
        /// Gets a call on dispose
        /// </summary>
        protected abstract void OnDispose();

        private Color _leftColor;

        /// <inheritdoc />
        public Color LeftColor
        {
            get => _leftColor;
            protected set
            {
                if (_leftColor != value)
                {
                    _leftColor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LeftColor)));
                }
            }
        }
        
        private Color _centerColor;

        /// <inheritdoc />
        public Color CenterColor
        {
            get => _centerColor;
            protected set
            {
                if (_centerColor != value)
                {
                    _centerColor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CenterColor)));
                }
            }
        }
        
        private Color _rightColor;

        /// <inheritdoc />
        public Color RightColor
        {
            get => _rightColor;
            protected set
            {
                if (_rightColor != value)
                {
                    _rightColor = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RightColor)));
                }
            }
        }

        /// <inheritdoc />
        public virtual void SetColor(Pad pad, Color color)
        {
            if (pad.HasFlag(Pad.Left))
            {
                LeftColor = color;
            }

            if (pad.HasFlag(Pad.Right))
            {
                RightColor = color;
            }

            if (pad.HasFlag(Pad.Center))
            {
                CenterColor = color;
            }
        }

        /// <inheritdoc />
        public virtual void FlashColor(Pad pad, Color color, byte onPhase, byte offPhase, byte cycles)
        {

        }

        /// <inheritdoc />
        public virtual void FadeColor(Pad pad, Color color, byte time, byte cycles)
        {

        }

        /// <summary>
        /// Adds the given tag to the public list
        /// </summary>
        /// <param name="tag">tag to add</param>
        protected void AddTag(Tag tag)
        {
            // Add tag and triggers event
            _tags.Add(tag);
            TagAdded?.Invoke(this, tag);
        }

        /// <summary>
        /// Removes the tag with the given index
        /// </summary>
        /// <param name="index">tag index to remove</param>
        /// <returns>true if the tag was available and was removed</returns>
        protected bool RemoveTagByIndex(int index)
        {
            // Try to identify the target tag
            var tag = _tags.FirstOrDefault(t => t.Index == index);
            if (tag is null)
            {
                return false;
            }

            return RemoveTag(tag);
        }

        /// <summary>
        /// Removes the given tag from the tag list
        /// </summary>
        /// <param name="tag">tag to remove</param>
        /// <returns>true if the tag was available and was removed</returns>
        protected bool RemoveTag(Tag tag)
        {
            // Try to remove the tag
            if (_tags.Remove(tag))
            {
                // Trigger event
                TagRemoved?.Invoke(this, tag);
                return true;
            }

            return false;
        }

        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <inheritdoc />
        public event EventHandler<Tag>? TagAdded;
        
        /// <inheritdoc />
        public event EventHandler<Tag>? TagRemoved;
    }
}
