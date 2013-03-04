using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Objetos_matriciales
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
            Application.Run(new FrmVideo());
        }
    }
}