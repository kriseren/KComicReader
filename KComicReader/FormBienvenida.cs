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
            checkBoxMostrarInicio.Checked = Config.MostrarBienvenida;
        }

        //Método que se ejecuta cuando se pinta el formulario.
        private void FormBienvenida_Paint(object sender, PaintEventArgs e)
        {
            //Si tiene conexión, se define el tema.
            Config.DefineTema();

            String[] Tema = Config.Tema;
            //El fondo se establece como un degradado entre el color 1 y el color 2.
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle,
                ColorTranslator.FromHtml(Tema[0]), ColorTranslator.FromHtml(Tema[1]), 90f);
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            //Por cada control de tipo panel se define el color 3.
            foreach (Control c in this.Controls.OfType<Panel>().ToList())
            {
                c.BackColor = ColorTranslator.FromHtml(Tema[2]);
            }
            //Si el tema es oscuro cambia el color del label y el checkbox.
            if (Config.Tema_id == 8)
            {
                checkBoxMostrarInicio.ForeColor = ColorTranslator.FromHtml(Tema[2]);
                lblBienvenidaTitulo.ForeColor = ColorTranslator.FromHtml(Tema[2]);
            }
            else
            {
                checkBoxMostrarInicio.ForeColor = Color.Black;
                lblBienvenidaTitulo.ForeColor = Color.Black;
            }
        }

        //Método que se ejecuta cuando el usuario hace click en el botón de cerrar.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Config.MostrarBienvenida = checkBoxMostrarInicio.Checked;
            Config.GuardaConfiguracion();
        }
    }
}
