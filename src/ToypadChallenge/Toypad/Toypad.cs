using System.ComponentModel;
using LegoDimensions;
using Color = System.Drawing.Color;

namespace Toypad
{
    /// <summary>
    /// Base class for all toy pads
    /// </summary>
    public abstract class Toypad : IToypad
    {
        private const int TickLengthInMilliseconds = 45;

        /// <summary>
        /// Internal list of all known tags
        /// </summary>
        private readonly List<Tag> _tags;

        /// <summary>
        /// Cancellation token source for the animation queue
        /// </summary>
        private readonly CancellationTokenSource _animationTokenSource;

        /// <summary>
        /// Animation queue for the left pad
        /// </summary>
        private readonly Queue<AnimationKeyframe> _leftQueue;

        /// <summary>
        /// Animation queue for the center pad
        /// </summary>
        private readonly Queue<AnimationKeyframe> _centerQueue;

        /// <summary>
        /// Animation queue for the right pad
        /// </summary>
        private readonly Queue<AnimationKeyframe> _rightQueue;

        public IReadOnlyCollection<Tag> Tags => _tags.AsReadOnly();

        protected Toypad()
        {
            _tags = new List<Tag>();
            LeftColor = Color.Black;
            RightColor = Color.Black;
            CenterColor = Color.Black;

            _leftQueue = new Queue<AnimationKeyframe>();
            _centerQueue = new Queue<AnimationKeyframe>();
            _rightQueue = new Queue<AnimationKeyframe>();

            _animationTokenSource = new CancellationTokenSource();
            _ = Task.Run(() => AnimationLoop(_animationTokenSource.Token), _animationTokenSource.Token);
        }

        public void Dispose()
        {
            _animationTokenSource.Cancel();
            _animationTokenSource.Dispose();

            OnDispose();
        }

        /// <summary>
        /// Gets a call on dispose
        /// </summary>
        protected abstract void OnDispose();

        /// <summary>
        /// Animation loop
        /// </summary>
        private async Task AnimationLoop(CancellationToken cancellationToken)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                // Apply left queue
                while (_leftQueue.TryPeek(out var leftAnimation))
                {
                    if (leftAnimation.DateTime > DateTime.Now)
                    {
                        break;
                    }

                    LeftColor = leftAnimation.Color;
                    _leftQueue.Dequeue();
                }

                // Apply center queue
                while (_centerQueue.TryPeek(out var centerAnimation))
                {
                    if (centerAnimation.DateTime > DateTime.Now)
                    {
                        break;
                    }

                    CenterColor = centerAnimation.Color;
                    _centerQueue.Dequeue();
                }

                // Apply right queue
                while (_rightQueue.TryPeek(out var rightAnimation))
                {
                    if (rightAnimation.DateTime > DateTime.Now)
                    {
                        break;
                    }

                    RightColor = rightAnimation.Color;
                    _rightQueue.Dequeue();
                }

                await Task.Delay(TickLengthInMilliseconds, cancellationToken);
            }
        }

        private Color _leftColor;

        /// <inheritdoc />
        public Color LeftColor
        {
            get => _leftColor;
            private set
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
            private set
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
            private set
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
                _leftQueue.Clear();
                _leftQueue.Enqueue(new AnimationKeyframe(DateTime.Now, color));
            }

            if (pad.HasFlag(Pad.Right))
            {
                _rightQueue.Clear();
                _rightQueue.Enqueue(new AnimationKeyframe(DateTime.Now, color));
            }

            if (pad.HasFlag(Pad.Center))
            {
                _centerQueue.Clear();
                _centerQueue.Enqueue(new AnimationKeyframe(DateTime.Now, color));
            }
        }

        /// <inheritdoc />
        public virtual void FlashColor(Pad pad, Color color, byte onPhase, byte offPhase, byte cycles)
        {
            if (pad.HasFlag(Pad.Left))
            {
                CreateFlashQueue(_leftQueue, LeftColor, color, onPhase, offPhase, cycles);
            }

            if (pad.HasFlag(Pad.Right))
            {
                CreateFlashQueue(_rightQueue, RightColor, color, onPhase, offPhase, cycles);
            }

            if (pad.HasFlag(Pad.Center))
            {
                CreateFlashQueue(_centerQueue, CenterColor, color, onPhase, offPhase, cycles);
            }
        }

        /// <summary>
        /// Calculates the flash entries for the animation queue for the given parameters
        /// </summary>
        /// <param name="queue">target queue</param>
        /// <param name="previousColor">pad color before the animation stated</param>
        /// <param name="color">animation color</param>
        /// <param name="onPhase">how many ticks should the color be on</param>
        /// <param name="offPhase">how many ticks should the color be off</param>
        /// <param name="cycles">number of color changes</param>
        private static void CreateFlashQueue(Queue<AnimationKeyframe> queue, Color previousColor, Color color, byte onPhase, byte offPhase, byte cycles)
        {
            // First of all clear the queue because there is a new animation
            queue.Clear();

            var offset = DateTime.Now;
            for (var i = 0; i < cycles; i++)
            {
                if (i % 2 == 0)
                {
                    // On phase
                    queue.Enqueue(new AnimationKeyframe(offset, color));
                    offset = offset.AddMilliseconds(onPhase * TickLengthInMilliseconds);
                }
                else
                {
                    // Off phase
                    queue.Enqueue(new AnimationKeyframe(offset, previousColor));
                    offset = offset.AddMilliseconds(offPhase * TickLengthInMilliseconds);
                }
            }
        }

        /// <inheritdoc />
        public virtual void FadeColor(Pad pad, Color color, byte time, byte cycles)
        {
            if (pad.HasFlag(Pad.Left))
            {
                CreateFadeQueue(_leftQueue, LeftColor, color, time, cycles);
            }

            if (pad.HasFlag(Pad.Right))
            {
                CreateFadeQueue(_rightQueue, RightColor, color, time, cycles);
            }

            if (pad.HasFlag(Pad.Center))
            {
                CreateFadeQueue(_centerQueue, CenterColor, color, time, cycles);
            }
        }

        /// <summary>
        /// Creates the whole fade animation
        /// </summary>
        /// <param name="queue">target queue</param>
        /// <param name="previousColor">pad color before the animation stated</param>
        /// <param name="color">animation color</param>
        /// <param name="cycles">number of color changes</param>
        /// <param name="time">number of ticks the fade should take</param>
        private static void CreateFadeQueue(Queue<AnimationKeyframe> queue, Color previousColor, Color color, byte time,
            byte cycles)
        {
            queue.Clear();

            var offset = DateTime.Now;
            for (var i = 0; i < cycles; i++)
            {
                if (i % 2 == 0)
                {
                    // fade in
                    CreateFadeAnimation(queue, offset, time, previousColor, color);
                    offset = offset.AddMilliseconds(time * TickLengthInMilliseconds);
                }
                else
                {
                    // fade out
                    CreateFadeAnimation(queue, offset, time, color, previousColor);
                    offset = offset.AddMilliseconds(time * TickLengthInMilliseconds);
                }
            }
        }

        /// <summary>
        /// Creates a single fade animation between two colors
        /// </summary>
        /// <param name="queue">target queue</param>
        /// <param name="offset">start time</param>
        /// <param name="time">number of ticks for the animation</param>
        /// <param name="from">source color</param>
        /// <param name="to">target color</param>
        private static void CreateFadeAnimation(Queue<AnimationKeyframe> queue, DateTime offset, byte time, Color from, Color to)
        {
            var dr = (float)(to.R - from.R) / time;
            var dg = (float)(to.G - from.G) / time;
            var db = (float)(to.B - from.B) / time;

            for (var i = 1; i < time; i++)
            {
                var color = Color.FromArgb(
                    from.A,
                    from.R + (int)(dr * i),
                    from.G + (int)(dg * i),
                    from.B + (int)(db * i));
                queue.Enqueue(new AnimationKeyframe(offset, color));
                offset = offset.AddMilliseconds(TickLengthInMilliseconds);
            }

            queue.Enqueue(new AnimationKeyframe(offset, to));
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

        #region Nested classes

        /// <summary>
        /// Represents a single keyframe for color animations
        /// </summary>
        private sealed class AnimationKeyframe(DateTime dateTime, Color color)
        {
            /// <summary>
            /// Time when this key frame gets active
            /// </summary>
            public DateTime DateTime { get; } = dateTime;

            /// <summary>
            /// Color to set when key frame reached
            /// </summary>
            public Color Color { get; } = color;
        }

        #endregion

        #region static fabrics

        /// <summary>
        /// Creates a new toypad. In best case its hardware. But if there is no pad or the emulator flag is set, the result value is an Emulator Instance
        /// </summary>
        /// <param name="enforceEmulator">enforce to use the emulator</param>
        /// <returns>a toypad instance</returns>
        public static IToypad CreateToypad(bool enforceEmulator = false)
        {
            // If flag is set we do not even try to get connected
            if (enforceEmulator)
            {
                return new EmulatorToypad();
            }

            try
            {
                // Try to connect to the first portal. If this fails we fall back to the emulator
                var portal = LegoPortal.GetFirstPortal();
                return new HardwareToypad(portal);
            }
            catch (Exception)
            {
                return new EmulatorToypad();
            }
        }

        #endregion
    }
}
