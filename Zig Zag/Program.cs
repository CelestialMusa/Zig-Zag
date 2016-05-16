using System;
using System.Data;
using System.Windows.Forms;

namespace Zig_Zag
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Home());
            }
            catch (ConstraintException)
            {
            }
        }
    }
}