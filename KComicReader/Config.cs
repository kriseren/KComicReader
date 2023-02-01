using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public static string ColorFondo1 { get; set; }
        public static string ColorFondo2 { get; set; }

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
                    cmd.CommandText = "SELECT propiedad,valor FROM AJUSTES ORDER BY id";
                    cmd.Parameters.AddWithValue("@propiedad", "directorio_instalacion");
                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    DirectorioInstalacion = reader.GetString("valor");
                    reader.Read();
                    ColorFondo1 = reader.GetString("valor");
                    reader.Read();
                    ColorFondo2 = reader.GetString("valor");
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
                    cmd.CommandText = @"UPDATE AJUSTES 
                                        SET valor = 
                                            CASE 
                                            WHEN propiedad = @directorio THEN @valorDirectorio
                                            WHEN propiedad = @color1 THEN @valorColor1
                                            WHEN propiedad = @color2 THEN @valorColor2
                                            END";
                    cmd.Parameters.AddWithValue("@directorio", "directorio_instalacion");
                    cmd.Parameters.AddWithValue("@valorDirectorio", DirectorioInstalacion);
                    cmd.Parameters.AddWithValue("@color1", "color_fondo1");
                    cmd.Parameters.AddWithValue("@valorColor1", ColorFondo1);
                    cmd.Parameters.AddWithValue("@color2", "color_fondo2");
                    cmd.Parameters.AddWithValue("@valorColor2", ColorFondo2);
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
