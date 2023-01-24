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
    public partial class AgregarComicBtn : UserControl
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
        public Image Portada
        {
            get { return pbPortada.Image; }
            set { pbPortada.Image = value; }
        }
        public String PortadaURL { get; set; }
        public String ArchivoURL { get; set; }
        public EventHandler eventoClick{ get; set;}

        public AgregarComicBtn()
        {
            InitializeComponent();
        }

        //Método que se ejecuta cuando el usuario hace click en cualquiera de los componentes del control.
        //Se invoca el EventHandler eventoClick.
        private void Control_Click(object sender, EventArgs e)
        {
            eventoClick.Invoke(this, e);
        }
    }
}
