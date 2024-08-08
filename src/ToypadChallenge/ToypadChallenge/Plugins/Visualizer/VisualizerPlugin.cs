using LegoDimensions;

namespace ToypadChallenge.Plugins.Visualizer
{
    [PluginDescription("Pad visualizer", "Just shows up the current pad state")]
    internal sealed class VisualizerPlugin : IPlugin
    {
        private readonly VisualizerControl _control;

        public VisualizerPlugin()
        {
            _control = new VisualizerControl();
        }

        public void Dispose()
        {
            _control.Dispose();
        }

        public void Init(ILegoPortal portal)
        {
            
        }

        public Control Control => _control;

    }
}
