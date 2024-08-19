using Toypad;
using Color = System.Drawing.Color;

namespace ToypadCli;

internal static class Program
{
    private static IToypad? _toypad;

    private static void Main()
    {
        Console.WriteLine("Toypad.Cli");

        _toypad = Toypad.Toypad.CreateToypad();
        _toypad.SetColor(Pad.Left, Color.DarkRed);
        _toypad.SetColor(Pad.Right, Color.DarkRed);
        _toypad.SetColor(Pad.Center, Color.DarkRed);
        
        _toypad.TagAdded += ToypadOnTagAdded;
        _toypad.TagRemoved += ToypadOnTagRemoved;

        Console.ReadLine();
    }

    private static void ToypadOnTagRemoved(object? sender, Tag tag)
    {
        Console.WriteLine($"Event Sender={sender}");
        _toypad?.SetColor(tag.Pad, Color.DarkBlue);
    }

    private static void ToypadOnTagAdded(object? sender, Tag tag)
    {
        Console.WriteLine($"Event Sender={sender}");
        _toypad?.SetColor(tag.Pad, Color.Yellow);
    }

}