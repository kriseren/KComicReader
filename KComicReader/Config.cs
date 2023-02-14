using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KComicReader
{
    /// <summary>
    /// Clase que define las propiedades de configuración del programa.
    /// </summary>
    internal class Config
    {
        /// <summary>
        /// La ruta del directorio donde se almacenarán los archivos CBR de los cómics dados de alta.
        /// </summary>
        public static string DirectorioInstalacion { get; set; }

        /// <summary>
        /// El nombre del esquema de colores definido en la configuración.
        /// </summary>
        public static string Tema_Nombre { get; set; }

        /// <summary>
        /// El identificador correspondiente al esquema de colores definido en la configuración.
        /// </summary>
        public static int Tema_id { get; set; }

        /// <summary>
        /// El conjunto de los valores correspondientes a los colores del tema definido en la configuración.
        /// </summary>
        public static string[] Tema { get; set; }

        /// <summary>
        /// La imagen que se mostrará como seleccionador cuando el usuario pase el ratón por encima de los botones.
        /// </summary>
        public static Image Hover { get; set; }

        /// <summary>
        /// La imagen de icono del tema correspondiente al esquema de colores definido en la configuración.
        /// </summary>
        public static Image ThemeIcon { get; set; }

        /// <summary>
        /// Define si se mostrará o no el formulario de bienvenida al inicio del programa.
        /// </summary>
        public static bool MostrarBienvenida { get; set; }


        /// <summary>
        /// Método que inicia el servidor de MySQL dentro de XAMPP.
        /// </summary>
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

        /// <summary>
        /// Método que comprueba la conectividad con la base de datos.
        /// </summary>
        /// <returns>Devuelve 'true' si existe conectividad y 'false' si no existe conectividad.</returns>
        public static bool CompruebaConexion()
        {
            bool conexion = false;
            using (MySqlConnection connection = DataBaseConnectivity.GetConnection())
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

                        if (MessageBox.Show("Se ha perdido la conexión :(\nPulsa el botón de 'reintentar'.\nSi el error persiste, reinicia la aplicación y el servidor de MySQL.", "Sin conexión", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                            Environment.Exit(0);
                        else
                            Config.IniciaMySQL();
                    }
                }
                while (!conexion);

                return conexion;
            }
        }

        /// <summary>
        /// Método que se conecta a la base de datos para cargar la configuración establecida.
        /// </summary>
        public static void DefineConfiguracion()
        {
            if (Config.CompruebaConexion())
            {
                using (MySqlConnection connection = DataBaseConnectivity.GetConnection())
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

        /// <summary>
        /// Método que se conecta a la base de datos y carga en el array de Tema los valores de los colores del tema.
        /// </summary>
        public static void DefineTema()
        {
            //Si hay conexión se define el tema.
            if (Config.CompruebaConexion())
            {
                using (MySqlConnection connection = DataBaseConnectivity.GetConnection())
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
                        MessageBox.Show("No se ha podido obtener el tema.\nPrueba a reiniciar el programa y el servidor de MySQL.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Método que se conecta a la base de datos para actualizar la configuración establecida
        /// </summary>
        public static void GuardaConfiguracion()
        {
            //Si hay conexión se guarda la configuración.
            if (Config.CompruebaConexion())
            {
                using (MySqlConnection connection = DataBaseConnectivity.GetConnection())
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
