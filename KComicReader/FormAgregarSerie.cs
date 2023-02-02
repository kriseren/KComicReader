
using MySql.Data.MySqlClient;
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
    public partial class FormAgregarSerie : Form
    {
        //Definición de variables.
        private int editorial_id;
        public FormAgregarSerie(int editorial_id)
        {
            InitializeComponent();
            this.editorial_id=editorial_id;
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de agregar.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (existe())
            {
                MessageBox.Show("La serie que intentas crear ya existe.", "Error al crear la serie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAgregar.DialogResult = DialogResult.None;
            }
            else
                btnAgregar.DialogResult = DialogResult.OK;
        }

        //Método que comprueba si la serie existe en la base de datos.
        private bool existe()
        {
            bool existe = false;
            //Obtengo la conexión y los objetos necesarios.
            using (MySqlConnection con = DataBaseConnectivity.getConnection())
            {
                //Se comprueba que exista.
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();

                    cmd.CommandText = $"SELECT COUNT(*) FROM SERIES WHERE nombre LIKE @nombre AND editorial_id = @editorial_id";
                    cmd.Parameters.AddWithValue("@nombre", tbNombre.Text);
                    cmd.Parameters.AddWithValue("@editorial_id", editorial_id);
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

        //Método que se ejecuta cuando se carga el formulario.
        private void FormAgregarSerie_Load(object sender, EventArgs e)
        {
            //Obtengo el nombre de la editorial.
            try
            {
                //Obtengo la conexión y los objetos necesarios.
                MySqlConnection con = DataBaseConnectivity.getConnection();
                con.Open();
                MySqlCommand cmd = con.CreateCommand();

                //Realizo la consulta.
                cmd.CommandText = $"SELECT NOMBRE FROM EDITORIALES WHERE id = @editorial_id";
                cmd.Parameters.AddWithValue("@editorial_id",editorial_id);
                cmd.Prepare();
                var reader = cmd.ExecuteReader();
                reader.Read();
                lblEditorialValue.Text = reader.GetString("nombre");

                //Cierro la conexión.
                con.Close();
            }
            catch(MySqlException)
            {
                MessageBox.Show("No se ha podido recuperar el nombre de la editorial asociada.","Error en la base de datos",MessageBoxButtons.OK);
            }
        }

        private void FormAgregarSerie_Paint(object sender, PaintEventArgs e)
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
    }
}
