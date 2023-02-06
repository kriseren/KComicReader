using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KComicReader
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {

        }

        //Método que se ejecuta cuando se pinta el formulario.
        private void FormBienvenida_Paint(object sender, PaintEventArgs e)
        {
            if (this.ClientRectangle.Width != 0 || this.ClientRectangle.Height != 0)
            {
                //El fondo se establece como un degradado entre el color 1 y el color 2.
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle,
                    ColorTranslator.FromHtml(Config.Tema[0]), ColorTranslator.FromHtml(Config.Tema[1]), 90f);
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            }
        }
    }
}
