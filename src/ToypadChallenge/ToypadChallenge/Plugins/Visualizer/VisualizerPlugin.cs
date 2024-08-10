using Toypad;

namespace ToypadChallenge.Plugins.Visualizer
{
    [PluginDescription("Pad visualizer", "Just shows up the current pad state")]
    internal sealed class VisualizerPlugin : IPlugin
    {
        private readonly VisualizerControl _control = new();

        public void Dispose()
        {
            _control.SetToypad(null);
            _control.Dispose();
        }

        public void Init(IToypad toypad, IConfiguration? configuration)
        {
            _control.SetToypad(toypad);
        }

        public IConfiguration? GetConfiguration()
        {
            return null;
        }

        public Control Control => _control;

    }
}
