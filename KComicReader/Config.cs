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
        public static int Tema_id { get; set; }
        public static string[] Tema { get; set; }

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
                    cmd.CommandText = "SELECT directorio_instalacion,tema_id FROM AJUSTES WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", 1);
                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    DirectorioInstalacion = reader.GetString("directorio_instalacion");
                    reader.Read();
                    Tema_id = reader.GetInt32("tema_id");
                }
                catch(MySqlException)
                {
                    MessageBox.Show("No se ha podido obtener la configuración.\nPrueba a reiniciar el programa y el servidor de MySQL.","Error en la base de datos",MessageBoxButtons.OK);
                }
            }
            //Defino el tema escogido.
            DefineTema();
        }

        //Método que se conecta a la base de datos y carga en el array los colores del tema.
        public static void DefineTema()
        {
            using (MySqlConnection connection = DataBaseConnectivity.getConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT color1,color2,color3 FROM TEMAS WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", Tema_id);
                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    Tema = new string[3];
                    Tema[0] = reader.GetString("color1");
                    Tema[1] = reader.GetString("color2");
                    Tema[2] = reader.GetString("color3");
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha podido obtener el tema.\nPrueba a reiniciar el programa y el servidor de MySQL.", "Error en la base de datos", MessageBoxButtons.OK);
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
                                        SET directorio_instalacion = @valorDirectorio, tema_id = @tema";
                    cmd.Parameters.AddWithValue("@valorDirectorio", DirectorioInstalacion);
                    cmd.Parameters.AddWithValue("@tema", Tema_id);
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
