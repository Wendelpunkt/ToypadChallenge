using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toypad.Launcher.Plugins.Spotify;

[PluginDescription("Spotify", "Integrates Spotify to play your Favorit songs on your devices")]
public class SpotifyPlugin : Plugin<SpotifyConfiguration>
{
    public override Control Control { get; }

    public override void Dispose()
    {

    }

    protected override SpotifyConfiguration GetDefaultConfiguration()
    {
        return new SpotifyConfiguration();
    }

    protected override void SetConfiguration(SpotifyConfiguration configuration)
    {

    }

    protected override void SetToypad(IToypad toypad)
    {

    }

    protected override void UpdateConfiguration()
    {

    }
}
