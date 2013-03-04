using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Promedios_del_alumnado
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
            Application.Run(new FrmPromedio());
        }
    }
}