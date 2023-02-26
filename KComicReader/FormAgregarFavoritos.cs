
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace KComicReader
{
    /// <summary>
    /// Formulario que permite agregar una viñeta a facoritos en la base de datos.
    /// </summary>
    public partial class FormAgregarFavoritos : Form
    {
        /// <summary>
        /// El identificador del cómic al que pertenece la viñeta.
        /// </summary>
        public Comic Comic { get; set; }

        public string Titulo { get; set; }

        /// <summary>
        /// La viñeta del cómic que se quiere almacenar en la base de datos.
        /// </summary>
        public Image Vinyeta { get; set; }

        public uint NumPag { get; set; }

        /// <summary>
        /// Constructor con parámetros.
        /// </summary>
        /// <param name="comic">El comic al que pertenece la viñeta.</param>
        /// <param name="vinyeta">La imagen de la viñeta que se va a </param>
        public FormAgregarFavoritos(Comic Comic, Image vinyeta, uint numPag)
        {
            InitializeComponent();
            this.Comic = Comic;
            this.Vinyeta = vinyeta;
            this.NumPag = numPag;
        }



        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de agregar.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(tbTitulo.Text == "")
            {
                MessageBox.Show("El título de la viñeta no pude estar vacío.", "Error al agregar la viñeta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
            }
            else
            {
                Titulo = tbTitulo.Text;
                if (Existe())
                {
                    MessageBox.Show("La viñeta que intentas agregar a favoritos ya existe.", "Error al agregar la viñeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
        }

        /// <summary>
        /// Método que comprueba si la viñeta existe en la base de datos.
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

                    cmd.CommandText = $"SELECT COUNT(*) FROM FAVORITOS WHERE comic_id = @comic_id AND numPagina=@numPagina";
                    cmd.Parameters.AddWithValue("@comic_id", Comic.Id);
                    cmd.Parameters.AddWithValue("@numPagina", NumPag);
                    cmd.Prepare();

                    //Verifico si la viñeta existe.
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                        existe = true;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ha ocurrido un error al comprobar la existencia de la viñeta.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Cargo el título del cómic.
            lblComicValue.Text = Comic.Titulo;
            //Cargo la imagen de la viñeta.
            pbVinyeta.Image = Vinyeta;
            //Cargo el número de página. Si lees esto Emilio te quiere (coger en latino) <3
            lblNumPaginaValue.Text = (NumPag+1).ToString();
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
                if (Config.Tema_id == 8 || Config.Tema_id == 11)
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
