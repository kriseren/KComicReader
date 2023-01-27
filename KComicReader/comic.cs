using MySqlConnector;
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
        public System.Drawing.Image Portada
        {
            get { return pbPortada.Image; }
            set { pbPortada.Image = value; }
        }
        public String ArchivoURL { get; set; }
        public EventHandler eventoClick{ get; set; }
        public EventHandler eventoDobleClick{ get; set; }
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
            try
            {
                //Obtengo la conexión y los objetos necesarios.
                MySqlConnection con = DataBaseConnectivity.getConnection();
                con.Open();
                MySqlCommand cmd = con.CreateCommand();

                //Inserto el comic
                cmd.CommandText = "INSERT INTO COMICS (titulo, dibujante, guionista,portada, archivoURL, numPagina, numPaginasTotales, categoria_id, idioma_id, editorial_id) VALUES (@titulo, @dibujante, @guionista,@portada, @archivoURL, @numPagina, @numPaginasTotales, @categoria_id, @idioma_id, @editorial_id)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@titulo", Titulo);
                cmd.Parameters.AddWithValue("@dibujante", Dibujante);
                cmd.Parameters.AddWithValue("@guionista", Guionista);
                cmd.Parameters.AddWithValue("@archivoURL", ArchivoURL);
                cmd.Parameters.AddWithValue("@numPagina", NumPaginaActual);
                cmd.Parameters.AddWithValue("@numPaginasTotales", NumPaginasTotales);
                cmd.Parameters.AddWithValue("@categoria_id", CategoriaID);
                cmd.Parameters.AddWithValue("@idioma_id", IdiomaID);
                cmd.Parameters.AddWithValue("@editorial_id", EditorialID);
                //Defino la portada.
                using (var memoryStream = new MemoryStream())
                {
                    Portada.Save(memoryStream, ImageFormat.Jpeg);
                    byte[] imageBytes = memoryStream.ToArray();
                    cmd.Parameters.AddWithValue("@portada", imageBytes);
                }

                //Ejecuto la inserción.
                cmd.ExecuteNonQuery();

                //Cierro la conexión.
                con.Close();
            }
            catch(MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error al conectar a la base de datos. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
