namespace Tis.Solving.Chaos.WinExe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new FLorenz());
            //Application.Run(new FBigLorenz());
            //Application.Run(new FWorld());
            Application.Run(new FFeigenbaum());
        }
    }
}