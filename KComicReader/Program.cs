using MySql.Data.MySqlClient;
using System;
using System.IO;
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
            //Inicio el servidor de MySQL.
            Config.IniciaMySQL();

            //Se comprueba que la base de datos exista En caso contrario se crea mediante un script.
            if (ExisteDB())
            {
                //Carga la configuración de la base de datos.
                Config.DefineConfiguracion();
            }
            else
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
                    }
                }
            }

            //Inicia el formulario.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormVistaPrincipal());
        }

        /// <summary>
        /// Método que comprueba si la base de datos existe, de lo contrario se crea.
        /// </summary>
        /// <returns>Devuelve 'true' si existe y 'false' si no existe.</returns>
        private static bool ExisteDB()
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
                }
            }
            return existe;
        }
    }
}
