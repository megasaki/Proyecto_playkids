using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playkidsPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Carga las librerías nativas para que el ReportViewer no falle
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            Application.Run(new Login());
        }
    }
}