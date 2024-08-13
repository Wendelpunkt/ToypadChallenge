namespace Toypad
{
    /// <summary>
    /// Toypad Emulation
    /// </summary>
    public sealed class EmulatorToypad : Toypad
    {
        private readonly List<Tag> _tags = new();

        protected override void OnDispose()
        {
        }

        public int AddEmulatedTag(Pad pad, byte[] uid, string name = "")
        {
            // Make sure pad is pure
            if (pad != Pad.Left && pad != Pad.Right && pad != Pad.Center)
            {
                throw new ArgumentException("Invalid pad position");
            }

            var tag = _tags.FirstOrDefault(t => t.Uid.SequenceEqual(uid));
            if (tag is not null)
            {
                if (tag.Pad != pad)
                {
                    _tags.Remove(tag);
                    RemoveTag(tag);
                }
                else
                {
                    return tag.Index;
                }
            }

            tag = new Tag(FindFreeIndex(), pad, uid, name);
            _tags.Add(tag);
            AddTag(tag);
            return tag.Index;
        }

        public bool RemoveEmulatedTag(byte[] uid)
        {
            var tag = _tags.FirstOrDefault(t => t.Uid.SequenceEqual(uid));
            if (tag is null)
            {
                return false;
            }

            _tags.Remove(tag);
            return RemoveTag(tag);
        }

        private int FindFreeIndex()
        {
            var index = 0;
            while (_tags.Any(t => t.Index == index))
            {
                index++;
            }

            return index;
        }
    }
}
