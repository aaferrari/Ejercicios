using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Conector_a_la_DB_Vivero_Fenix
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmConector());
        }
    }
}