using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Patratul_unui_numar_folosind_functii
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
            Application.Run(new Form1());
        }
    }
}
