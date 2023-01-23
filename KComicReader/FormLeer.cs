using SharpCompress.Archives;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace KComicReader
{
    public partial class FormLeer : Form
    {
        //Definición de atributos.
        public Comic comic;
        private int numPag=0;
        private IArchive archive;

        //Constructor general de la clase.
        public FormLeer(Comic comic)
        {
            InitializeComponent();
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
            //Si el número de página no es el último, se carga.
            if(numPag < archive.Entries.Count())
            {
                numPag++;
                definePagina();
            }
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de "Anterior página".
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //Si el número de página es distinto de 0, se carga.
            if(numPag > 0)
            {
                numPag--;
                definePagina();
            }
        }
    }
}
