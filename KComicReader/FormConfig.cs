
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace KComicReader
{
    public partial class FormConfig : Form
    {
        //Definición de propiedades.
        public string DirectorioInstalacion {get;set;}
        public int Tema_id { get; set; }
        public FormConfig()
        {
            InitializeComponent();
        }

        //Método que se ejecuta cuando el ratón entra en el área visible del botón.
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = Image.FromFile(@"..\..\imgs\icons\hover.png");
        }

        //Método que se ejecuta cuando el ratón sale del área visible del botón.
        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackgroundImage = null;
        }

        //Método que se ejecuta cuando se carga el formulario.
        private void FormConfig_Load(object sender, EventArgs e)
        {
            //Se define la configuración y el valor del campo.
            Config.DefineConfiguracion();
            DirectorioInstalacion = Config.DirectorioInstalacion;
            tbDirectorioValue.Text = Config.DirectorioInstalacion;
            Tema_id = Config.Tema_id;

            //Se definen las opciones del combobox de temas.
            DefineTemas();
            //Se define el tema seleccionado.
            cbTema.SelectedValue = Tema_id;
        }

        private void DefineTemas()
        {
            //Obtengo la conexión y los objetos necesarios.
            using (MySqlConnection con = DataBaseConnectivity.getConnection())
            {
                //Defino las opciones de los comboBox haciendo una consulta a la base de datos.
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    //Serie.
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

        //Método que se ejecuta cuando el usuario pulsa en el botón de seleccionar carpeta.
        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            //Creo un OpenDirectoryDialog.
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //Si el usuario selecciona una carpeta, se define la propiedad.
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                tbDirectorioValue.Text = fbd.SelectedPath;
                DirectorioInstalacion = fbd.SelectedPath;
            }
        }

        private void FormConfig_Paint(object sender, PaintEventArgs e)
        {
            Config.DefineTema();
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
                    }
                }
            }
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de guardar.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Tema_id = (int)cbTema.SelectedValue;
        }
    }
}
