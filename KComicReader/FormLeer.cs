using SharpCompress.Archives;
using System;
using System.Drawing;
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
        private double aspectRatio;
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

            aspectRatio = (double)pbPagina.Image.Height / (double)pbPagina.Image.Width;
        }

        //Método que se ejecuta cuando el formulario es cargado.
        private void FormLeer_Load(object sender, EventArgs e)
        {
            definePagina();
            lblNumPaginas.Text = "Página " + numPag + " de " + comic.NumPaginasTotales;
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
                case Keys.Right: siguientePagina() ;break;
                case Keys.Left: anteriorPagina();break;
                case Keys.Up:
                    pbPagina.AutoScrollOffset = new Point(pbPagina.AutoScrollOffset.X, pbPagina.AutoScrollOffset.Y + 10);
                    break;
                case Keys.Down:
                    pbPagina.AutoScrollOffset = new Point(pbPagina.AutoScrollOffset.X, pbPagina.AutoScrollOffset.Y - 10);
                    break;
                case Keys.Z: zoom();break;
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

            //Cambio el texto.
            lblNumPaginas.Text = "Página " + numPag + " de " + comic.NumPaginasTotales;

            //Si el zoom está activo, se define el zoom.
            if (zoomOn)
                defineZoom();
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
            //Cambio el texto.
            lblNumPaginas.Text = "Página " + numPag + " de " + comic.NumPaginasTotales;

            //Si el zoom está activo, se define el zoom.
            if(zoomOn)
                defineZoom();
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
                defineZoom();
            }
            else
            {
                pbPagina.Image = imgOriginal;
                btnZoom.Image = Image.FromFile(@"..\..\imgs\icons\zoomIn.png");
                pbPagina.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                pbPagina.Dock = DockStyle.Fill;
                pbPagina.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        //Método que redimensiona la imagen dependiendo del tamaño del formulario.
        private void defineZoom()
        {
            pbPagina.Dock = DockStyle.None;
            pbPagina.Anchor = AnchorStyles.Top;
            pbPagina.SizeMode = PictureBoxSizeMode.AutoSize;
            int anchoNuevo = panelImage.Width;
            int altoOriginal = imgOriginal.Height;
            Size newSize = new Size((int)(anchoNuevo), (int)((altoOriginal * anchoNuevo) / imgOriginal.Width));
            pbPagina.Image = new Bitmap(pbPagina.Image, newSize);
        }

        //Método que se ejecuta cuando el usuario redimensiona el formulario.
        private void Form_Resize(object sender, EventArgs e)
        {
            //Si el zoom está activado, se define el zoom.
            if(zoomOn)
                defineZoom();
        }
    }
}
