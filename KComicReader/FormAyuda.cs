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
    public partial class FormAyuda : Form
    {
        public FormAyuda()
        {
            InitializeComponent();
        }


        private void FormAyuda_Paint(object sender, PaintEventArgs e)
        {
            //Si tiene conexión, se define el tema.
            Config.DefineTema();

            String[] Tema = Config.Tema;

            if (this.ClientRectangle.Width != 0 || this.ClientRectangle.Height != 0)
            {
                //El fondo se establece como un degradado entre el color 1 y el color 2.
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle,
                    ColorTranslator.FromHtml(Tema[0]), ColorTranslator.FromHtml(Tema[1]), 90f);
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
                //Por cada control de tipo panel se define el color 2.
                foreach (Control c in this.Controls.OfType<Panel>().ToList())
                {
                    c.BackColor = ColorTranslator.FromHtml(Tema[2]);
                    //Si el panel contiene elementos label dentro, se define el color 1.
                    if (c.Controls.OfType<Label>().ToList().Count > 0)
                    {
                        //Por cada control que su nombre comience por lblSpec, su color de fondo es el 4.
                        foreach (Control co in c.Controls.OfType<Label>().Where(co => co.Name.StartsWith("lblSpec")))
                        {
                            co.BackColor = ColorTranslator.FromHtml(Tema[1]);

                            //Si el tema es alguno oscuro.
                            if (Config.Tema_id == 8)
                            {
                                co.ForeColor = ColorTranslator.FromHtml(Tema[2]);
                            }
                            else
                            {
                                co.ForeColor = Color.Black;
                            }
                        }
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
