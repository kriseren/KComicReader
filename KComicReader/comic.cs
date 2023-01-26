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
        public String Dibujante { get; set; }
        public String Guionista { get; set; }
        public String Categoria { get; set; }
        public Image Portada
        {
            get { return pbPortada.Image; }
            set { pbPortada.Image = value; }
        }
        public String PortadaURL { get; set; }
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
    }
}
