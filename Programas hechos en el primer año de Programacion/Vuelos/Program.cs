using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Trabajo_con_bases_de_datos
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
            Application.Run(new FrnControlVuelos());
        }
    }
}