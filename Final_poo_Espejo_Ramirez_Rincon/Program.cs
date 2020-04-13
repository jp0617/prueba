using System;
using System.Windows.Forms;
using Final_poo_Espejo_Ramirez_Rincon.Views;

namespace Final_poo_Espejo_Ramirez_Rincon
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
            Application.Run(new frmHome());
        }
    }
}
