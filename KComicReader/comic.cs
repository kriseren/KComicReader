using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace KComicReader
{
    public partial class Comic : UserControl
    {
        //Definición de propiedades.
        public int Id { get; set; }
        public String Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }
        public String Editorial { get; set; }
        public int EditorialID { get; set; }
        public String Dibujante { get; set; }
        public String Guionista { get; set; }
        public String Categoria { get; set; }
        public int CategoriaID { get; set; }
        public String Idioma { get; set; }
        public int IdiomaID { get; set; }
        public String Serie { get; set; }
        public int SerieID { get; set; }
        public uint Numero { get; set; }
        public System.Drawing.Image Portada
        {
            get { return pbPortada.Image; }
            set { pbPortada.Image = value; }
        }
        public String ArchivoURL { get; set; }
        public EventHandler eventoClick { get; set; }
        public EventHandler eventoDobleClick { get; set; }
        public uint NumPaginaActual { get; set; }
        public uint NumPaginasTotales { get; set; }

        public Comic()
        {
            InitializeComponent();

            //Se inicializa el número de página actual.
            NumPaginaActual = 0;
            Categoria = "Sin asignar";
            Idioma = "Español";
            ArchivoURL = "";
        }

        //Método que se ejecuta cuando el usuario hace click en cualquiera de los componentes del control.
        //Se invoca el EventHandler eventoClick.
        private void Control_Click(object sender, EventArgs e)
        {
            eventoClick.Invoke(this, e);
        }

        //Método que se ejecuta cuando el usuario hace doble click en cualquiera de los componentes del control.
        //Se invoca el EventHandler eventoDobleClick.
        private void Control_DobleClick(object sender, EventArgs e)
        {
            eventoDobleClick.Invoke(this, e);
        }

        //Método que inserta el comic en la base de datos.
        public void guarda()
        {
            //Obtengo la conexión y los objetos necesarios.
            using (MySqlConnection con = DataBaseConnectivity.getConnection())
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

        //Método que recibe un cómic se actualiza en la base de datos obteniendo las nuevas propiedades.
        public void actualiza(Comic c)
        {
            //Obtengo la conexión y los objetos necesarios.
            using (MySqlConnection con = DataBaseConnectivity.getConnection())
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