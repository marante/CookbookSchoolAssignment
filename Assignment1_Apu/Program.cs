using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // In order to get exception errors in english, hate Swedish exception messages.
#if DEBUG
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
#endif
            Application.Run(new FormMain());
        }
    }
}