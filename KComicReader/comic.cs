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
        public Image Portada
        {
            get { return pbPortada.Image; }
            set { pbPortada.Image = value; }
        }
        public String PortadaURL { get; set; }
        public String ArchivoURL { get; set; }

        public Comic()
        {
            InitializeComponent();
        }
    }
}
