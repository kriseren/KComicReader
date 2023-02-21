using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace KComicReader
{
    /// <summary>
    /// Control personalizado que representa un objeto cómic.
    /// </summary>
    public partial class Comic : UserControl
    {
        /// <summary>
        /// El identificador del cómic.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// El título del cómic.
        /// </summary>
        public String Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        /// <summary>
        /// El nombre de la editorial del cómic.
        /// </summary>
        public String Editorial { get; set; }

        /// <summary>
        /// El identificador correspondiente a la editorial del cómic.
        /// </summary>
        public int EditorialID { get; set; }

        /// <summary>
        /// El nombre del/la dibujante del cómic.
        /// </summary>
        public String Dibujante { get; set; }

        /// <summary>
        /// El nombre del/la guionista del cómic.
        /// </summary>
        public String Guionista { get; set; }

        /// <summary>
        /// El nombre de la categoría del cómic.
        /// </summary>
        public String Categoria { get; set; }

        /// <summary>
        /// El identificador correspondiente a la categoría del cómic.
        /// </summary>
        public int CategoriaID { get; set; }

        /// <summary>
        /// El nombre del idioma del cómic.
        /// </summary>
        public String Idioma { get; set; }

        /// <summary>
        /// El identificador correspondiente al idioma del cómic.
        /// </summary>
        public int IdiomaID { get; set; }

        /// <summary>
        /// El nombre de la serie del cómic asociada a la editorial.
        /// </summary>
        public String Serie { get; set; }

        /// <summary>
        /// El identificador correspondiente a la serie del cómic asociada a la editorial.
        /// </summary>
        public int SerieID { get; set; }

        /// <summary>
        /// El número del cómic asociado a la serie.
        /// </summary>
        public uint Numero { get; set; }

        /// <summary>
        /// La imagen de la portada del cómic.
        /// </summary>
        public System.Drawing.Image Portada
        {
            get { return pbPortada.Image; }
            set { pbPortada.Image = value; }
        }

        /// <summary>
        /// La ruta de acceso al archivo CBR del cómic.
        /// </summary>
        public String ArchivoURL { get; set; }

        /// <summary>
        /// El evento invocado cuando se hace click en cualquier parte del control.
        /// </summary>
        public EventHandler EventoClick { get; set; }

        /// <summary>
        /// El evento invocado cuando se hace doble click en cualquier parte del control.
        /// </summary>
        public EventHandler EventoDobleClick { get; set; }

        /// <summary>
        /// El número que indica la página por la que se está leyendo.
        /// </summary>
        public uint NumPaginaActual { get; set; }

        /// <summary>
        /// El número de páginas totales del cómic.
        /// </summary>
        public uint NumPaginasTotales { get; set; }

        /// <summary>
        /// Define la fuente que se usará en el texto del título de los cómics.
        /// </summary>
        private static readonly Font Fuente = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);

        /// <summary>
        /// Define la fuente que se usará en el texto del título de los cómics.
        /// </summary>
        private static readonly Font FuenteNegrita = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);

        /// <summary>
        /// Constructor sin parámetros que inicializa el componente y varias propiedades.
        /// </summary>
        public Comic()
        {
            InitializeComponent();

            //Se inicializan varias propiedades.
            NumPaginaActual = 0;
            Categoria = "Sin asignar";
            Idioma = "Español";
            ArchivoURL = "";
        }

        /// <summary>
        /// Método que ejecuta el evento click cuando el usuario hace click en cualquiera de los componentes del control.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Control_Click(object sender, EventArgs e)
        {
            EventoClick.Invoke(this, e);
        }

        /// <summary>
        /// Método que ejecuta el evento doble click cuando el usuario hace doble click en cualquiera de los componentes del control.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Control_DobleClick(object sender, EventArgs e)
        {
            EventoDobleClick.Invoke(this, e);
        }

        /// <summary>
        /// Método que pone en negrita el texto del título.
        /// </summary>
        public void PoneNegrita()
        {
            lblTitulo.Font = FuenteNegrita;
        }

        /// <summary>
        /// Método que elimina la negrita del texto del título.
        /// </summary>
        public void QuitaNegrita()
        {
            lblTitulo.Font = Fuente;
        }

        /// <summary>
        /// Método que inserta el cómic en la base de datos.
        /// </summary>
        public void Guarda()
        {
            if (Config.CompruebaConexion())
            {
                //Obtengo la conexión y los objetos necesarios.
                using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                {
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();

                        //Inserto el comic
                        cmd.CommandText = "INSERT INTO COMICS (titulo, dibujante, guionista,portada, archivoURL, numPagina, numPaginasTotales, categoria_id, idioma_id, editorial_id,serie_id,numero) VALUES (@titulo, @dibujante, @guionista,@portada, @archivoURL, @numPagina, @numPaginasTotales, @categoria_id, @idioma_id, @editorial_id, @serie_id,@numero)";
                        cmd.Parameters.AddWithValue("@titulo", Titulo);
                        cmd.Parameters.AddWithValue("@dibujante", Dibujante);
                        cmd.Parameters.AddWithValue("@guionista", Guionista);
                        cmd.Parameters.AddWithValue("@archivoURL", ArchivoURL);
                        cmd.Parameters.AddWithValue("@numPagina", NumPaginaActual);
                        cmd.Parameters.AddWithValue("@numPaginasTotales", NumPaginasTotales);
                        cmd.Parameters.AddWithValue("@categoria_id", CategoriaID);
                        cmd.Parameters.AddWithValue("@idioma_id", IdiomaID);
                        cmd.Parameters.AddWithValue("@editorial_id", EditorialID);
                        cmd.Parameters.AddWithValue("@serie_id", SerieID);
                        cmd.Parameters.AddWithValue("@numero", Numero);
                        //Defino la portada.
                        using (var memoryStream = new MemoryStream())
                        {
                            Portada.Save(memoryStream, ImageFormat.Jpeg);
                            byte[] imageBytes = memoryStream.ToArray();
                            cmd.Parameters.AddWithValue("@portada", imageBytes);
                        }
                        cmd.Prepare();

                        //Ejecuto la inserción.
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se ha podido dar de alta el cómic. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Método que actualiza un cómic en la base de datos.
        /// </summary>
        /// <param name="c">El cómic que contiene las propiedades del cómic a actualizar.</param>
        public void Actualiza(Comic c)
        {
            if (Config.CompruebaConexion())
            {
                //Obtengo la conexión y los objetos necesarios.
                using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                {
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();

                        //Actualizo el comic.
                        cmd.CommandText = "UPDATE comics SET titulo = @titulo, dibujante = @dibujante, guionista = @guionista, portada = @portada, archivoURL = @archivoURL, numPagina = @numPagina, numPaginasTotales = @numPaginasTotales, categoria_id = @categoria_id, idioma_id = @idioma_id, editorial_id = @editorial_id, serie_id = @serie_id, numero = @numero WHERE id = @id";
                        cmd.Parameters.AddWithValue("@titulo", c.Titulo);
                        cmd.Parameters.AddWithValue("@dibujante", c.Dibujante);
                        cmd.Parameters.AddWithValue("@guionista", c.Guionista);
                        cmd.Parameters.AddWithValue("@archivoURL", c.ArchivoURL);
                        cmd.Parameters.AddWithValue("@numPagina", c.NumPaginaActual);
                        cmd.Parameters.AddWithValue("@numPaginasTotales", c.NumPaginasTotales);
                        cmd.Parameters.AddWithValue("@categoria_id", c.CategoriaID);
                        cmd.Parameters.AddWithValue("@idioma_id", c.IdiomaID);
                        cmd.Parameters.AddWithValue("@editorial_id", c.EditorialID);
                        cmd.Parameters.AddWithValue("@serie_id", c.SerieID);
                        cmd.Parameters.AddWithValue("@numero", c.Numero);
                        cmd.Parameters.AddWithValue("@id", this.Id);
                        //Defino la portada.
                        using (var memoryStream = new MemoryStream())
                        {
                            Portada.Save(memoryStream, ImageFormat.Jpeg);
                            byte[] imageBytes = memoryStream.ToArray();
                            cmd.Parameters.AddWithValue("@portada", imageBytes);
                        }
                        cmd.Prepare();
                        //Realizo la actualización.
                        int res = cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se ha podido actualizar el cómic. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}