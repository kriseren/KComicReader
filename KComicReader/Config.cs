﻿using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KComicReader
{
    internal class Config
    {
        //Definición de propiedades.
        public static string DirectorioInstalacion { get; set; }
        public static bool Conexion { get; set; }
        public static int Tema_id { get; set; }
        public static string Tema_Nombre { get; set; }
        public static string[] Tema { get; set; }
        public static Image Hover { get; set; }
        public static Image ThemeIcon { get; set; }
        public static bool MostrarBienvenida { get; set; }

        public Config() { DefineConfiguracion(); }

        //Método que comprueba la conectividad.
        public static void CompruebaConexion()
        {
            using (MySqlConnection connection = DataBaseConnectivity.getConnection())
            {
                try
                {
                    connection.Open();
                    Conexion = true;
                }
                catch (MySqlException)
                {
                    DefineConfiguracionSinConexion();
                }
            }
        }

        //Método que define la configuración sin conexión.
        public static void DefineConfiguracionSinConexion()
        {
            MessageBox.Show("Estás sin conexión. A partir de ahora podrás seguir utilizando el programa, pero ten en cuenta que los cambios que realices pueden no guardarse.","Sin conexión",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            Conexion = false;
            Tema_id = 1;
            Tema = new string[] { "#b18cd9", "#E2C6FF", "#ece0f8" };
            Hover = Image.FromFile("..\\..\\imgs\\hover\\1.png");
            ThemeIcon = Image.FromFile("..\\..\\imgs\\themeicons\\1.png");
            DirectorioInstalacion = @"C:\KComicReader\Comics";
            ThemeIcon = Image.FromFile(@"..\..\imgs\icons\sinConexion.png");
        }

        //Método que se conecta a la base de datos para cargar la configuración establecida.
        public static void DefineConfiguracion()
        {
            if(Conexion)
            {
                using (MySqlConnection connection = DataBaseConnectivity.getConnection())
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "SELECT directorio_instalacion,tema_id,mostrar_bienvenida FROM AJUSTES WHERE id = @id";
                        cmd.Parameters.AddWithValue("@id", 1);
                        cmd.Prepare();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        DirectorioInstalacion = reader.GetString("directorio_instalacion");
                        Tema_id = reader.GetInt32("tema_id");
                        MostrarBienvenida = reader.GetBoolean("mostrar_bienvenida");
                        Conexion = true;
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se ha podido conectar con la base de datos. Puedes continuar utilizando el programa sin conexión. Los datos no se guardarán.", "Error en la base de datos", MessageBoxButtons.OK);
                    }
                }
                //Defino el tema escogido.
                DefineTema();
            }
        }

        //Método que se conecta a la base de datos y carga en el array los colores del tema.
        public static void DefineTema()
        {
            //Si hay conexión se define el tema.
            if(Conexion)
            {
                using (MySqlConnection connection = DataBaseConnectivity.getConnection())
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "SELECT nombre,color1,color2,color3,seleccionador,icono FROM TEMAS WHERE id = @id";
                        cmd.Parameters.AddWithValue("@id", Tema_id);
                        cmd.Prepare();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        Tema = new string[3];
                        Tema_Nombre = reader.GetString("nombre");
                        Tema[0] = reader.GetString("color1");
                        Tema[1] = reader.GetString("color2");
                        Tema[2] = reader.GetString("color3");
                        try
                        {
                            Hover = Image.FromFile("..\\..\\imgs\\hover\\" + reader.GetString("seleccionador"));
                            ThemeIcon = Image.FromFile("..\\..\\imgs\\themeIcons\\" + reader.GetString("seleccionador"));

                        }
                        catch (IOException)
                        {
                            Hover = Image.FromFile("..\\..\\imgs\\hover\\1.png");
                            ThemeIcon = Image.FromFile("..\\..\\imgs\\themeicons\\1.png");
                        }
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se ha podido obtener el tema.\nPrueba a reiniciar el programa y el servidor de MySQL.", "Error en la base de datos", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Conexion = false;
                    }
                }
            }
        }

        //Método que se conecta a la base de datos para actualizar la configuración establecida.
        public static void GuardaConfiguracion()
        {
            //Si hay conexión se guarda la configuración.
            if(Conexion)
            {
                using (MySqlConnection connection = DataBaseConnectivity.getConnection())
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = @"UPDATE AJUSTES 
                                        SET directorio_instalacion = @valorDirectorio, tema_id = @tema, mostrar_bienvenida = @bienvenida";
                        cmd.Parameters.AddWithValue("@valorDirectorio", DirectorioInstalacion);
                        cmd.Parameters.AddWithValue("@tema", Tema_id);
                        cmd.Parameters.AddWithValue("@bienvenida", MostrarBienvenida);
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
}
