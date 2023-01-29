using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //Se comprueba que exista.
            try
            {
                //Obtengo la conexión y los objetos necesarios.
                MySqlConnection con = DataBaseConnectivity.getConnection();
                con.Open();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = $"SELECT COUNT(*) FROM SERIES WHERE nombre LIKE @nombre AND editorial_id = @editorial_id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nombre", tbNombre.Text);
                cmd.Parameters.AddWithValue("@editorial_id", editorial_id);

                //Verifico si la editorial o la categoria existe.
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                    existe = true;

                //Cierro la conexión.
                con.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error al comprobar la existencia de la serie.\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@editorial_id",editorial_id);
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
    }
}
