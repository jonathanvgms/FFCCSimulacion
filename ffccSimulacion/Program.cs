using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ffccSimulacion.Dominio;
using ffccSimulacion.Dominio.DataBase;

namespace ffccSimulacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBaseManager db = new DataBaseManager();
            db.PruebasBD();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Simulacion s = new Simulacion(1);
            s.ejecutarSimulacion();
        }
    }
}
