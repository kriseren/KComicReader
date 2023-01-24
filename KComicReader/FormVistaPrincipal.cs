using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KComicReader
{
    public partial class FormVistaPrincipal : Form
    {
        //Definición de atributos.
        Comic comicSeleccionado;

        public FormVistaPrincipal()
        {
            InitializeComponent();
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de agregar.
        private void pbBtnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarComic formAgregar = new FormAgregarComic();
            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                //Obtengo el comic, defino un controlador de eventos click y lo agrego al flowLayout.
                Comic comic = formAgregar.comic;
                comic.eventoClick += new EventHandler(Comic_Click);
                this.fwpComics.Controls.Add(comic);

                //Ordeno los cómics por título.
                ordenaComicsPorTitulo();
            }
        }

        // TODO: Controlar el click en los cómics para poder mostrar la información.
        //Método que se ejecuta cuando el usuario pulsa encima de un cómic.
        private void Comic_Click(object sender, EventArgs e)
        {
            //Creo el objeto cómic y defino todas las etiquetas de información.
            comicSeleccionado = (Comic)sender;
            lblInfoTitulo.Text = "[TÍTULO]";
            lblInfoTituloValue.Text = comicSeleccionado.Titulo;
            lblInfoEditorial.Text = "[EDITORIAL]";
            lblInfoEditorialValue.Text = comicSeleccionado.Editorial;
            lblInfoGuionista.Text = "[GUIONISTA]";
            lblInfoGuionistaValue.Text = comicSeleccionado.Guionista;
            lblInfoDibujante.Text = "[DIBUJANTE]";
            lblInfoDibujanteValue.Text = comicSeleccionado.Dibujante;

            //Muevo el panel al frente para ocultar el de vista vacía.
            panelRightVacia.Visible = false;
            panelRightInfo.BringToFront();

            //Cambio el color del fondo para todos los cómics.
            foreach( Control c in fwpComics.Controls)
            {
                c.BackColor = Color.Transparent;
            }
            //Defino el color del fondo para el cómic seleccionado.
            comicSeleccionado.BackColor = Color.FromArgb(177, 140, 217);
        }

        //Método que ordena los cómics del FlowLayoutPanel por título, para ello almaceno.
        private void ordenaComicsPorTitulo()
        {
            //Creo un array de controles y cargo en él los controles del fwp (en este caso óbjetos cómic)
            Control[] controls = new Control[fwpComics.Controls.Count];
            fwpComics.Controls.CopyTo(controls, 0);

            //Creo un array de objetos cómic, para almacenar los controles convertidos a cómics.
            Comic[] comics = controls.Select(c => c as Comic).ToArray();

            //Ordeno los cómics por título.
            Array.Sort(comics, (c1, c2) => c1.Titulo.CompareTo(c2.Titulo));

            //Elimino el contenido actual del fwp.
            fwpComics.Controls.Clear();

            //Agrego de nuevo cada cómic ordenado por título.
            foreach (Comic c in comics)
            {
                fwpComics.Controls.Add(c);
            }
        }

        //Método que se ejecuta cuando se carga el formulario.
        private void FormVistaPrincipal_Load(object sender, EventArgs e)
        {
            //Muestro la vista vacía.
            panelRightVacia.BringToFront();
            panelRightVacia.Visible = true;
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de leer cómic.
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Creo un formulario con el cómic seleccionado.
            FormLeer formLeer = new FormLeer(comicSeleccionado);
            formLeer.ShowDialog();
        }
    }
}
