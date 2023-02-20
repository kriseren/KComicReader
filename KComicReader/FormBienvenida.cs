using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace KComicReader
{
    /// <summary>
    /// Formulario que muestra la bienvenida al programa.
    /// </summary>
    public partial class FormBienvenida : Form
    {
        /// <summary>
        /// Constructor sin parámetros que inicializa el componente.
        /// </summary>
        public FormBienvenida()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            checkBoxMostrarInicio.Checked = Config.MostrarBienvenida;
        }

        /// <summary>
        /// Método que se ejecuta cuando se pinta el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
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
            if (Config.Tema_id == 8 || Config.Tema_id == 11)
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

        /// <summary>
        /// Método que se ejecuta cuando el usuario hace click en el botón de cerrar.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Config.MostrarBienvenida = checkBoxMostrarInicio.Checked;
            Config.GuardaConfiguracion();
        }
    }
}
