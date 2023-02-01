using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KComicReader
{
    internal class Config
    {
        //Definición de propiedades.
        public static string DirectorioInstalacion { get; set; }

        public Config() { DefineConfiguracion(); }

        //Método que se conecta a la base de datos para cargar la configuración establecida.
        public static void DefineConfiguracion()
        {
            using(MySqlConnection connection = DataBaseConnectivity.getConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT propiedad,valor FROM AJUSTES WHERE propiedad = @propiedad";
                    cmd.Parameters.AddWithValue("@propiedad", "directorio_instalacion");
                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    DirectorioInstalacion = reader.GetString("valor");
                }
                catch(MySqlException)
                {
                    MessageBox.Show("No se ha podido obtener la configuración.\nPrueba a reiniciar el programa y el servidor de MySQL.","Error en la base de datos",MessageBoxButtons.OK);
                }
            }
        }

        //Método que se conecta a la base de datos para actualizar la configuración establecida.
        public static void GuardaConfiguracion()
        {
            using (MySqlConnection connection = DataBaseConnectivity.getConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE AJUSTES SET valor=@valor WHERE propiedad = @propiedad";
                    cmd.Parameters.AddWithValue("@propiedad", "directorio_instalacion");
                    cmd.Parameters.AddWithValue("@valor", DirectorioInstalacion);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha podido guardar la configuración.\nPrueba a reiniciar el programa y el servidor de MySQL.", "Error en la base de datos", MessageBoxButtons.OK);
                }
            }
        }

    }
}
