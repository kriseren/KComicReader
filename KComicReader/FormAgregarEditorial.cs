
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
    public partial class FormAgregarEditorial : Form
    {
        //Definición de variables.
        private string elemento;
        public FormAgregarEditorial(string elemento)
        {
            InitializeComponent();

            //Defino el elemento que se va a agregar. (Categoría, Serie o Editorial)
            this.elemento = elemento;

            //Defino el título del formulario.
            this.lblTituloFormulario.Text = "AGREGAR UNA NUEVA " + elemento.ToUpper();
        }

        //Método que se ejecuta cuando el usuario pulsa el botón de agregar.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (existe())
            {
                MessageBox.Show("La " + elemento + " que intentas crear ya existe.", "Error al crear la " + elemento, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                btnAgregar.DialogResult = DialogResult.OK;
        }

        //Método que comprueba si la editorial o la serie existen.
        private bool existe()
        {
            bool existe = false;

            //Se comprueba que no exista.
            //Obtengo la conexión y los objetos necesarios.
            using (MySqlConnection con = DataBaseConnectivity.getConnection())
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();

                    //Dependiendo del elemento a agregar, se ejecuta un comando u otro.
                    switch (elemento)
                    {
                        case "categoria":
                            cmd.CommandText = $"SELECT COUNT(*) FROM CATEGORIAS WHERE nombre LIKE @nombre";
                            cmd.Parameters.AddWithValue("@nombre", tbNombre.Text);
                            cmd.Prepare();
                            break;
                        case "editorial":
                            cmd.CommandText = $"SELECT COUNT(*) FROM EDITORIALES WHERE nombre LIKE @nombre";
                            cmd.Parameters.AddWithValue("@nombre", tbNombre.Text);
                            cmd.Prepare();
                            break;
                    }

                    //Verifico si la editorial o la categoria existe.
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                        existe = true;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ha ocurrido un error al comprobar la existencia de la " + elemento + ".\nSi continúas usando el programa puede que no se guarden los datos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return existe;       
        }

        private void FormAgregarEditorial_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
               this.ClientRectangle,
               ColorTranslator.FromHtml(Config.ColorFondo1),
               ColorTranslator.FromHtml(Config.ColorFondo2), 90f);
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
        }
    }
}
