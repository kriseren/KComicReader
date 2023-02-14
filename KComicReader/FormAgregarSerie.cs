
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace KComicReader
{
    /// <summary>
    /// Formulario que permite agregar una serie a la base de datos.
    /// </summary>
    public partial class FormAgregarSerie : Form
    {
        /// <summary>
        /// El identificador de la editorial a la que pertenece la serie.
        /// </summary>
        public int Editorial_id;

        /// <summary>
        /// Constructor con parámetros.
        /// </summary>
        /// <param name="editorial_id">El identificador de la editorial a la que pertenece la serie.</param>
        public FormAgregarSerie(int editorial_id)
        {
            InitializeComponent();
            this.Editorial_id = editorial_id;
        }



        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de agregar.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Existe())
            {
                MessageBox.Show("La serie que intentas crear ya existe.", "Error al crear la serie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// Método que comprueba si la serie existe en la base de datos.
        /// </summary>
        /// <returns>Devuelve 'true' si existe y 'false' si no existe.</returns>
        private bool Existe()
        {
            bool existe = false;
            //Obtengo la conexión y los objetos necesarios.
            using (MySqlConnection con = DataBaseConnectivity.GetConnection())
            {
                //Se comprueba que exista.
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();

                    cmd.CommandText = $"SELECT COUNT(*) FROM SERIES WHERE nombre LIKE @nombre AND editorial_id = @editorial_id";
                    cmd.Parameters.AddWithValue("@nombre", tbNombre.Text);
                    cmd.Parameters.AddWithValue("@editorial_id", Editorial_id);
                    cmd.Prepare();

                    //Verifico si la editorial o la categoria existe.
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                        existe = true;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ha ocurrido un error al comprobar la existencia de la serie.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return existe;
        }

        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormAgregarSerie_Load(object sender, EventArgs e)
        {
            //Obtengo el nombre de la editorial.
            try
            {
                //Obtengo la conexión y los objetos necesarios.
                MySqlConnection con = DataBaseConnectivity.GetConnection();
                con.Open();
                MySqlCommand cmd = con.CreateCommand();

                //Realizo la consulta.
                cmd.CommandText = $"SELECT NOMBRE FROM EDITORIALES WHERE id = @editorial_id";
                cmd.Parameters.AddWithValue("@editorial_id", Editorial_id);
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                reader.Read();
                lblEditorialValue.Text = reader.GetString("nombre");

                //Cierro la conexión.
                con.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha podido recuperar el nombre de la editorial asociada.", "Error en la base de datos", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando se pinta el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormAgregarSerie_Paint(object sender, PaintEventArgs e)
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
