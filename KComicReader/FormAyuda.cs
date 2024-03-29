﻿using System;
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
    /// <summary>
    /// Formulario que permite visualizar la ayuda.
    /// </summary>
    public partial class FormAyuda : Form
    {
        /// <summary>
        /// Constructor sin parámetros que inicializa el componente.
        /// </summary>
        public FormAyuda()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Método que se ejecuta cuando se pinta el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
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
                            if (Config.Tema_id == 8 || Config.Tema_id == 11)
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

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de cerrar.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario hace click en un apartado dentro del listBox.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void lbApartados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambio la pestaña en el TabControl según el índice seleccionado.
            tabControlContenido.SelectedIndex = lbApartados.SelectedIndex+1;
        }

        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormAyuda_Load(object sender, EventArgs e)
        {
            tabControlContenido.Appearance = TabAppearance.FlatButtons;
            tabControlContenido.ItemSize = new Size(0, 1);
        }
    }
}
