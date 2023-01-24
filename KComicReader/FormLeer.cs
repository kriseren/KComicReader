using SharpCompress.Archives;
using System;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace KComicReader
{
    public partial class FormLeer : Form
    {
        //Definición de atributos.
        public Comic comic;
        private int numPag = 0;
        private IArchive archive; //Contiene el archivo descomprimido.

        //Constructor general de la clase.
        public FormLeer(Comic comic)
        {
            InitializeComponent();
            this.CenterToParent();
            this.comic = comic;
            archive = ArchiveFactory.Open(comic.ArchivoURL);
            this.Text = comic.Titulo;
        }

        //Método que se ejecuta cuando el formulario es cargado.
        private void FormLeer_Load(object sender, EventArgs e)
        {
            definePagina();
        }

        //Método que define la página que se está visualizando.
        private void definePagina()
        {
            //Obtengo el primer elemento y lo almaceno en la variable imagen.
            IArchiveEntry portada = archive.Entries.ElementAt(numPag);
            //Defino la imagen de la página actual.
            pbPagina.Image = Image.FromStream(portada.OpenEntryStream());
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
            //Si la tecla es la flecha derecha.
            if (e.KeyCode == Keys.D)
            {
                siguientePagina();
            }
            else
                if (e.KeyCode == Keys.A)
            {
                anteriorPagina();
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
        }
    }
}
