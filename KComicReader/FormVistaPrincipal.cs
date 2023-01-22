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
                comic.Click += new EventHandler(Comic_Click);
                this.fwpComics.Controls.Add(comic);

                //Ordeno los cómics por título.
                ordenaComicsPorTitulo();
            }
        }

        // TODO: Controlar el click en los cómics para poder mostrar la información.
        //Método que se ejecuta cuando el usuario pulsa encima de un cómic.
        private void Comic_Click(object sender, EventArgs e)
        {
            Comic comic = (Comic)sender;
            lblInfoTitulo.Text = comic.Titulo;
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
    }
}
