using System;
using System.Windows.Forms;
using Taref.Main.Wins;

namespace Taref.Main.Class
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitialWin());
        }
    }
}
