using SharpCompress.Archives;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KComicReader
{
    public partial class FormAgregarComic : Form
    {

        //Definición de propiedades.
        public Comic comic = new Comic();

        public FormAgregarComic()
        {
            InitializeComponent();
            CenterToParent();
        }

        //Método que se activa cuando se pulsa el botón de seleccionar archivo.
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            //Creo un OpenFileDialog y le defino las propiedades.
            OpenFileDialog ofd_FicheroComic = new OpenFileDialog();
            ofd_FicheroComic.Filter = "Fichero CBR (*.cbr)|*.cbr";
            ofd_FicheroComic.Title = "Selecciona el archivo del cómic a importar.";

            if (ofd_FicheroComic.ShowDialog() == DialogResult.OK)
            {
                //Almaceno la url del fichero en las variables.
                lblPortada.Text = ofd_FicheroComic.SafeFileName;
                comic.ArchivoURL = ofd_FicheroComic.FileName;

                //Extraigo la portada y la muestro. 
                pbPortada.Image = extraePortada(comic.ArchivoURL);

                //Defino el título del cómic para ayudar al usuario.
                tbTitulo.Text = ofd_FicheroComic.SafeFileName.Split('.')[0];
            }
        }

        //Método que se activa cuando el usuario pulsa el botón de agregar el cómic.    
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Ruta del directorio donde se guardará el cómic.
            string rutaDirectorio = @"C:\KComicReader\Comics";

            //Crea el directorio si no existe.
            if (!Directory.Exists(rutaDirectorio))
                Directory.CreateDirectory(rutaDirectorio);

            //Copio el archivo de cómic al directorio especificado si no existe ya.
            if(!File.Exists(Path.Combine(rutaDirectorio, Path.GetFileName(comic.ArchivoURL))))
                File.Copy(comic.ArchivoURL, Path.Combine(rutaDirectorio, Path.GetFileName(comic.ArchivoURL)));

            //Defino las propiedades del cómic.
            comic.Titulo = tbTitulo.Text;
            comic.Portada = pbPortada.Image;
            comic.Guionista = tbGuionista.Text;
            comic.Dibujante = tbDibujante.Text;
            comic.ArchivoURL = Path.Combine(rutaDirectorio, Path.GetFileName(comic.ArchivoURL));
        }

        //Método que extrae la primera imagen de un archivo .CBR y la devuelve.
        private System.Drawing.Image extraePortada( string archivoURL)
        {
            Image imagen = null;
            try
            {
                //Abro el arhivo.
                IArchive archive = ArchiveFactory.Open(archivoURL);
                //Obtengo el primer elemento y lo almaceno en la variable imagen.
                IArchiveEntry portada = archive.Entries.First();
                imagen = Image.FromStream(portada.OpenEntryStream());
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el archivo. Por favor, selecciona otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return imagen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
