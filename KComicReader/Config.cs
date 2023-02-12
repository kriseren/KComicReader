using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
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

        //Método que inicia el servidor de MySQL.
        public static void IniciaMySQL()
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
            catch (Win32Exception)
            {
                MessageBox.Show("Ha ocurrido un error al iniciar MySQL.\nSeguramente sea debido a que la ruta de instalación de XAMPP no es la correcta.", "Error al iniciar MySQL", MessageBoxButtons.OK);
            }
        }

        //Método que comprueba la conectividad.
        public static bool CompruebaConexion()
        {
            bool conexion = false;
            using (MySqlConnection connection = DataBaseConnectivity.getConnection())
            {
                //Se repite mientras que no haya conexión.
                do
                {
                    try
                    {
                        connection.Open();
                        conexion = true;
                    }
                    catch (MySqlException)
                    {
                        conexion = false;
                        
                        if (MessageBox.Show("Se ha perdido la conexión :(\nPulsa el botón de 'reintentar'.\nSi el error persiste, reinicia la aplicación y el servidor de MySQL.", "Sin conexión", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) == DialogResult.Retry)
                        {
                            CompruebaConexion();
                        }
                    }
                }
                while (!conexion);
                
                return conexion;
            }
        }

        //Método que define la configuración sin conexión.
        public static void DefineConfiguracionSinConexion()
        {
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
            if (Config.CompruebaConexion())
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
            if (Config.CompruebaConexion())
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
                    }
                }
            }
        }

        //Método que se conecta a la base de datos para actualizar la configuración establecida.
        public static void GuardaConfiguracion()
        {
            //Si hay conexión se guarda la configuración.
            if (Config.CompruebaConexion())
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
