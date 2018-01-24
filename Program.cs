using System;
using System.Windows.Forms;

namespace lb5_deviseman
{
    static class Program
    {
        /// <summary>
        /// Entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}