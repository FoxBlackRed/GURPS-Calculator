using System.Globalization;

namespace GURPSCalculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        [STAThread]
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            ApplicationConfiguration.Initialize();
            Application.Run(new GURPScalc());
        }
    }
}