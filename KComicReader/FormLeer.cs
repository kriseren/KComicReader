using MySql.Data.MySqlClient;
using SharpCompress.Archives;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace KComicReader
{
    public partial class FormLeer : Form
    {
        //Definición de atributos.
        public Comic comic;
        private uint numPag = 0;
        private IArchive archive; //Contiene el archivo descomprimido.
        private bool zoomOn = false;
        private Image imgOriginal;

        //Constructor general de la clase.
        public FormLeer(Comic comic)
        {
            InitializeComponent();
            this.CenterToParent();
            this.comic = comic;
            this.numPag = comic.NumPaginaActual;
            archive = ArchiveFactory.Open(comic.ArchivoURL);
            this.Text = comic.Titulo;
        }

        //Método que se ejecuta cuando el formulario es cargado.
        private void FormLeer_Load(object sender, EventArgs e)
        {
            definePagina();
            lblNumPaginas.Text = "Página " + (numPag + 1) + " de " + comic.NumPaginasTotales;
        }

        //Método que define la página que se está visualizando.
        private void definePagina()
        {
            //Obtengo el primer elemento y lo almaceno en la variable imagen.
            IArchiveEntry portada = archive.Entries.ElementAt(Convert.ToInt32(numPag));
            //Defino la imagen de la página actual.
            pbPagina.Image = Image.FromStream(portada.OpenEntryStream());
            imgOriginal = pbPagina.Image;
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de "Siguiente página".
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            siguientePagina();
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de "Anterior página".
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            anteriorPagina();
        }


        //Método que se ejecuta cuando el usuario pulsa cualquier tecla dentro del formulario.
        private void key_Down(object sender, KeyEventArgs e)
        {
            //Dependiendo de la tecla pulsada.
            switch(e.KeyCode)
            {
                case Keys.Right:
                case Keys.D: siguientePagina() ;break;

                case Keys.Left:
                case Keys.A:anteriorPagina();break;

                case Keys.Z: zoom();break;
                case Keys.M: marcar();break;
            }
        }

        //Método que carga la página anterior.
        private void anteriorPagina()
        {
            //Si el número de página es distinto de 0, se carga.
            if (numPag > 0)
            {
                numPag--;
                definePagina();
            }
            cambiaPaginaComun();
        }

        //Método que carga la página siguiente.
        private void siguientePagina()
        {
            //Si el número de página no es el último, se carga.
            if (numPag < archive.Entries.Count()-1)
            {
                numPag++;
                definePagina();
            }
            cambiaPaginaComun();
        }

        //Método que realiza las líneas de código comunes cuando se cambia de página.
        private void cambiaPaginaComun()
        {
            //Cambio el texto que indica las páginas.
            lblNumPaginas.Text = "Página " + (numPag + 1) + " de " + comic.NumPaginasTotales;

            //Si el zoom está activo, se define el zoom.
            if (zoomOn)
            {
                zoomIn();
            }

            //Defino la imagen del botón del marcador.
            btnMarcador.Image = Image.FromFile(@"..\..\imgs\icons\mark.png");
        }

        //Método que se ejecuta cuando el usuario pulsa en el botón de zoom.
        private void Zoom_Click(object sender, EventArgs e)
        {
            zoom();
        }

        //Método que aplica el zoom a la imagen.
        private void zoom()
        {
            //Invierto el valor del zoom.
            zoomOn = !zoomOn;

            //Cambia la imagen dependiendo del zoom.
            if (zoomOn)
            {
                btnZoom.Image = Image.FromFile(@"..\..\imgs\icons\zoomOut.png");
                zoomIn();
            }
            else
            {
                btnZoom.Image = Image.FromFile(@"..\..\imgs\icons\zoomIn.png");
                zoomOut();
            }
        }

        //Método que redimensiona la imagen dependiendo del ancho del panel tamaño del formulario.
        private void zoomIn()
        {
            pbPagina.Anchor = AnchorStyles.Top;
            pbPagina.SizeMode = PictureBoxSizeMode.AutoSize;
            int anchoNuevo = panelImage.Width;
            int altoOriginal = imgOriginal.Height;

            //Defino un nuevo tamaño calculando el alto con la proporción original.
            Size newSize = new Size((int)(anchoNuevo), (int)((altoOriginal * anchoNuevo) / imgOriginal.Width));
            pbPagina.Image = new Bitmap(pbPagina.Image, newSize);
        }

        //Método que devuelve la imagen al estado inicial, sin el zoom.
        private void zoomOut()
        {
            pbPagina.Image = imgOriginal;
            pbPagina.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pbPagina.Dock = DockStyle.Fill;
            pbPagina.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //Método que se ejecuta cuando el usuario redimensiona el formulario.
        private void Form_Resize(object sender, EventArgs e)
        { 
            zoomOut();
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de marcar página.
        private void btnMarcador_Click(object sender, EventArgs e)
        {
            marcar();
        }

        //Método que marca la página actual y la almacena.
        private void marcar()
        {
            //Defino la imagen.
            btnMarcador.Image = Image.FromFile(@"..\..\imgs\icons\marked.png");
            //Defino la página actual y la almaceno en la base de datos.
            comic.NumPaginaActual = numPag;
            using (MySqlConnection connection = DataBaseConnectivity.getConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE comics SET numPagina = @numPagina WHERE id = @id";
                    cmd.Parameters.AddWithValue("@numPagina",comic.NumPaginaActual);
                    cmd.Parameters.AddWithValue("@id", comic.Id);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                catch(MySqlException)
                {
                    MessageBox.Show("Ha ocurrido un error al marcar la página.","Error en la base de datos",MessageBoxButtons.OK);
                }
            }
        }

        //Método que se ejecuta cuando el ratón entra en el área visible del botón.
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = Config.Hover;
        }

        //Método que se ejecuta cuando el ratón sale del área visible del botón.
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = null;
        }

        private void FormLeer_Paint(object sender, PaintEventArgs e)
        {
            Config.DefineTema();
            String[] Tema = Config.Tema;

            //El fondo se establece como un degradado entre el color 1 y el color 2.
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle,
                ColorTranslator.FromHtml(Tema[0]), ColorTranslator.FromHtml(Tema[1]), 90f);
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
        }
    }
}
