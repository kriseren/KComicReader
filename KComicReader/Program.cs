using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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
                //Process.Start(startInfo);
            }
            catch(Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error al iniciar MySQL.\nSeguramente sea debido a que la ruta de instalación de XAMPP no es la correcta.","Error al iniciar MySQL",MessageBoxButtons.OK);
            }

            //Se comprueba que la base de datos exista En caso contrario se crea mediante un script.
            if (existeDB())
            {
                //Carga la configuración de la base de datos.
                Config.CompruebaConexion();
                Config.DefineConfiguracion();
            }
            else
            {
                if (Config.Conexion)
                {
                    string connectionString = "server=localhost;user=root;password=;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            //Creo el script cargando el fichero y lo ejecuto.
                            MySqlScript script = new MySqlScript(connection, File.ReadAllText(@"..\..\scripts\scriptCreacion.sql"));
                            script.Execute();
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("No se ha podido crear la base de datos", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Config.Conexion = false;
                        }
                    }
                }
            }

            //Inicia el formulario.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormVistaPrincipal());
        }

        //Método que comprueba si la base de datos existe, de lo contrario se crea.
        private static bool existeDB()
        {
            bool existe = false;
            string connectionString = "Server=localhost;Database=information_schema;Uid=root;Pwd=;";
            string db = "kcomicreader";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand($"SELECT COUNT(*) FROM information_schema.schemata WHERE schema_name = '{db}'", connection);
                    existe = Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ha ocurrido un error al conectar con la base de datos.\nPrueba a iniciar el servidor de MYSQL.", "Error al conectar a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Config.DefineConfiguracionSinConexion();
                }
            }
            return existe;
        }
    }
}
