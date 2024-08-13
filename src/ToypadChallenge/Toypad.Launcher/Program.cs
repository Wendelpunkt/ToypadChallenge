namespace Toypad.Launcher
{
    internal static class Program
    {
        /// <summary>
        /// Parameter string to enable emulator
        /// </summary>
        private const string EmulatorParameterText = "emulator";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(params string[] args)
        {
            // See if emulator command parameter is set
            var emulator = args.Length > 0 && string.Equals(args[0], EmulatorParameterText, StringComparison.InvariantCultureIgnoreCase);

            using var toypad = Toypad.CreateToypad(emulator);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(toypad));

            // Switch off everything after shutdown
            toypad.SetColor(Pad.All, Color.Black);
        }
    }
}