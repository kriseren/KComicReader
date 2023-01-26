using SharpCompress.Archives;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KComicReader
{
    public partial class FormAgregarComic : Form
    {

        //Definición de atributos.
        public Comic comic = new Comic();
        private OpenFileDialog ofd_FicheroComic;

        public FormAgregarComic()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        //Método que se activa cuando se pulsa el botón de seleccionar archivo.
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            //Creo un OpenFileDialog y le defino las propiedades.
            ofd_FicheroComic = new OpenFileDialog();
            ofd_FicheroComic.Filter = "Fichero CBR (*.cbr)|*.cbr";
            ofd_FicheroComic.Title = "Selecciona el archivo del cómic a importar.";

            if (ofd_FicheroComic.ShowDialog() == DialogResult.OK)
            {
                //Almaceno la url del fichero en las variables.
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
            //Si todos los campos obligatorios han sido rellenados, sino se informa al usuario y se cambia su color para mayor claridad.
            if (tbTitulo.Text !="" && cbIdioma.Text !="" && ofd_FicheroComic.FileName != "")
            {
                //Ruta del directorio donde se guardará el cómic.
                string rutaDirectorio = @"C:\KComicReader\Comics";

                //Crea el directorio si no existe.
                if (!Directory.Exists(rutaDirectorio))
                    Directory.CreateDirectory(rutaDirectorio);

                //Copio el archivo de cómic al directorio especificado si no existe ya.
                if (!File.Exists(Path.Combine(rutaDirectorio, Path.GetFileName(comic.ArchivoURL))))
                    File.Copy(comic.ArchivoURL, Path.Combine(rutaDirectorio, Path.GetFileName(comic.ArchivoURL)));

                //Defino las propiedades del cómic.
                comic.Titulo = tbTitulo.Text;
                comic.Editorial = cbEditorial.Text;
                comic.Portada = pbPortada.Image;
                comic.Guionista = tbGuionista.Text;
                comic.Dibujante = tbDibujante.Text;
                comic.Categoria = cbCategoria.Text;
                comic.ArchivoURL = Path.Combine(rutaDirectorio, Path.GetFileName(comic.ArchivoURL));
                comic.NumPaginasTotales = (uint)ArchiveFactory.Open(comic.ArchivoURL).Entries.Count();

                //Defino el dialogresult del botón.
                btnAgregar.DialogResult = DialogResult.OK;
            }
            else
            {
                //Se cambia el color de la fuente y se vuelve negrita.
                lblTitulo.ForeColor = Color.DarkRed;
                //lblTitulo.Font = new Font(lblTitulo.Font, FontStyle.Bold);
                lblIdioma.ForeColor = Color.DarkRed;
                //lblIdioma.Font = new Font(lblIdioma.Font, FontStyle.Bold);
                lblArchivo.ForeColor = Color.DarkRed;
                //lblArchivo.Font = new Font(lblArchivo.Font, FontStyle.Bold);
                MessageBox.Show(this, "Los campos marcados en rojo son obligatorios.\nPor favor rellénalos antes de agregar un nuevo cómic.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
            }
            
        }

        //Método que extrae la primera imagen de un archivo .CBR y la devuelve.
        private Image extraePortada( string archivoURL)
        {
            Image imagen = null;
            try
            {
                //Abro el arhivo.
                IArchive archive = ArchiveFactory.Open(archivoURL);
                //Obtengo el primer elemento y lo almaceno en la variable imagen.
                IArchiveEntry portada = archive.Entries.First();
                //Intento definir la imagen, si da error se informa al usuario.
                try
                {
                    imagen = Image.FromStream(portada.OpenEntryStream());
                }
                catch(ArgumentException)
                {
                    imagen = Image.FromFile(@"..\..\imgs\icons\comicCover.jpg");
                    MessageBox.Show("Ha ocurrido un error al abrir el archivo. Por favor, selecciona otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el archivo. Por favor, selecciona otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return imagen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
