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
        //Definición de variables.
        private string pag1 = @"KComicReader es un gestor de cómics que permite registrar y leer archivos CBR para montar tu propia biblioteca de cómics personal.

Si es tu primera vez utilizando el programa, pulsa 'Siguiente' y déjame enseñarte cómo funciona ;)
                            ";
        private string pag2 = @"El primer paso para poder agregar un cómic a tu colección es obtener el correspondiente arhivo CBR.";

        private string pag3 = @"";
        private int contPag = 1;

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
            String[] Tema = Config.Tema;
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

        //Método que se ejecuta cuando el usuario hace click en el botón de siguiente.
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(contPag<3)
                contPag++;
            defineTexto();
        }

        //Método que se ejecuta cuando el usuario hace click en el botón de anterior.
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (contPag >= 2)
                contPag--;
            defineTexto();
        }

        //Método que define el texto del label del panel dependiendo de la página que se muestre.
        private void defineTexto()
        {
            switch (contPag)
            {
                case 1: lblContenido.Text = pag1; break;
                case 2: lblContenido.Text = pag2; break;
                case 3: lblContenido.Text = pag3; break;
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
