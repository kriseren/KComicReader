
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace KComicReader
{
    /// <summary>
    /// Formulario que permite definir la configuración del programa.
    /// </summary>
    public partial class FormConfig : Form
    {
        /// <summary>
        /// La ruta del directorio de instalación del programa.
        /// </summary>
        public string DirectorioInstalacion { get; set; }

        /// <summary>
        /// El identificador del tema definido en la configuracíón.
        /// </summary>
        public int Tema_id { get; set; }

        /// <summary>
        /// Define si se ha de mostrar el formulario de bienvenida al inicio del programa.
        /// </summary>
        public bool MostrarBienvenida { get; set; }

        /// <summary>
        /// Constructor sin parámtros que inicializa el componente.
        /// </summary>
        public FormConfig()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormConfig_Load(object sender, EventArgs e)
        {
            //Se define la configuración y el valor del campo.
            if (Config.CompruebaConexion())
            {
                Config.DefineConfiguracion();
                DefineTemas();
            }

            DirectorioInstalacion = Config.DirectorioInstalacion;
            tbDirectorioValue.Text = Config.DirectorioInstalacion;
            Tema_id = Config.Tema_id;
            MostrarBienvenida = Config.MostrarBienvenida;

            //Se define el tema seleccionado y la bienvenida.
            cbTema.SelectedValue = Tema_id;
            checkBoxMostrarInicio.Checked = MostrarBienvenida;
        }

        /// <summary>
        /// Método que se ejecuta cuando se pinta el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormConfig_Paint(object sender, PaintEventArgs e)
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
                    {
                        c.ForeColor = ColorTranslator.FromHtml(Tema[2]);
                    }
                    foreach (Control c in this.Controls.OfType<CheckBox>().ToList())
                    {
                        c.ForeColor = ColorTranslator.FromHtml(Tema[2]);
                    }
                }
                else
                {
                    foreach (Control c in this.Controls.OfType<Label>().ToList())
                    {
                        c.ForeColor = Color.Black;
                    }
                }
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el ratón entra en el área visible del botón.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = Config.Hover;
        }

        /// <summary>
        /// Método que se ejecuta cuando el ratón sale del área visible del botón.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = null;
        }

        /// <summary>
        /// Método que se conecta a la base de datos para definir las opciones del comboBox.
        /// </summary>
        private void DefineTemas()
        {
            //Obtengo la conexión y los objetos necesarios.
            using (MySqlConnection con = DataBaseConnectivity.GetConnection())
            {
                //Defino las opciones de los comboBox haciendo una consulta a la base de datos.
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT id, nombre FROM TEMAS ORDER BY nombre";
                    cmd.Prepare();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    cbTema.DataSource = ds.Tables[0];
                    cbTema.DisplayMember = "nombre";
                    cbTema.ValueMember = "id";
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se han podido obtener los temas. Por favor, reinicia el servidor MySQL.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa en el botón de seleccionar carpeta.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            //Creo un OpenDirectoryDialog.
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //Si el usuario selecciona una carpeta, se define la propiedad.
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbDirectorioValue.Text = fbd.SelectedPath;
                DirectorioInstalacion = fbd.SelectedPath;
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de guardar.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Config.CompruebaConexion())
            {
                if (cbTema.SelectedValue != null)
                    Tema_id = (int)cbTema.SelectedValue;
                MostrarBienvenida = checkBoxMostrarInicio.Checked;
            }
        }
    }
}
