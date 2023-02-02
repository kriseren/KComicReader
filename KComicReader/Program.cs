using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KComicReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Inicia el servidor de MYSQL.
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C C:\\xampp\\mysql\\bin\\mysqld";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(startInfo);
            }
            catch(Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error al iniciar MySQL.\nSeguramente sea debido a que la ruta de instalación de XAMPP no es la correcta.","Error al iniciar MySQL",MessageBoxButtons.OK);
            }

            //Inicia el formulario.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormVistaPrincipal());
        }
    }
}
