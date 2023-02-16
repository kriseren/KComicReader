
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace KComicReader
{
    /// <summary>
    /// Formulario que permite agregar una editorial a la base de datos.
    /// </summary>
    public partial class FormAgregarEditorial : Form
    {
        /// <summary>
        /// Constructor sin parámetros que inicializa el componente.
        /// </summary>
        public FormAgregarEditorial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de agregar.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Existe())
            {
                MessageBox.Show("La editorial que intentas crear ya existe.", "Error al crear la editorial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// Método que comprueba si la editorial o la serie existen.
        /// </summary>
        /// <returns>Devuelve 'true' si existe y 'false' si no existe.</returns>
        private bool Existe()
        {
            bool existe = false;

            //Se comprueba que no exista.
            using (MySqlConnection con = DataBaseConnectivity.GetConnection())
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = $"SELECT COUNT(*) FROM EDITORIALES WHERE nombre LIKE @nombre";
                    cmd.Parameters.AddWithValue("@nombre", tbNombre.Text);
                    cmd.Prepare();

                    //Verifico si la editorial o la categoria existe.
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                        existe = true;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ha ocurrido un error al comprobar la existencia de la editorial.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return existe;
        }

        /// <summary>
        /// Método que se ejecuta cuando se pinta el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormAgregarEditorial_Paint(object sender, PaintEventArgs e)
        {
            Config.DefineTema();
            String[] Tema = Config.Tema;


            if (this.ClientRectangle.Width != 0 || this.ClientRectangle.Height != 0)
            {
                //El fondo se establece como un degradado entre el color 1 y el color 2.
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle,
                ColorTranslator.FromHtml(Tema[0]), ColorTranslator.FromHtml(Tema[1]), 90f);
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
                //Si el tema es oscuro se cambia el color de la fuente.
                if (Config.Tema_id == 8)
                {
                    foreach (Control c in this.Controls.OfType<Label>().ToList())
                        c.ForeColor = ColorTranslator.FromHtml(Tema[2]);
                }
                else
                {
                    foreach (Control c in this.Controls.OfType<Label>().ToList())
                        c.ForeColor = Color.Black;
                }
            }
        }
    }
}
