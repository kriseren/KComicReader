using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace KComicReader
{
    public partial class FormFavoritos : Form
    {
        public FormFavoritos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que se ejecuta cuando se carga el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>

        private void FormFavoritos_Load(object sender, EventArgs e)
        {
            //Cargo los registros de las viñetas favoritas en el DataGridView.
            if (Config.CompruebaConexion())
            {
                using (MySqlConnection connection = DataBaseConnectivity.GetConnection())
                {
                    try
                    {
                        //Obtengo los datos de la tabla.
                        connection.Open();
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "SELECT f.id, f.titulo, f.vinyeta, c.titulo FROM FAVORITOS f JOIN COMICS c ON f.comic_id = c.id";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        //Agrego el identificador como una nueva columna de datos.
                        dataTable.Columns.Add("id_vinyeta", typeof(int));
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataTable.Rows[i]["id_vinyeta"] = i + 1;
                        }

                        //Configuro el aspecto visual del dataGridView.
                        dtgVinyetas.DataSource = dataTable;
                        dtgVinyetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtgVinyetas.Columns[1].HeaderText = "Título";
                        dtgVinyetas.Columns[2].HeaderText = "Imagen";
                        dtgVinyetas.Columns[3].HeaderText = "Título del comic";
                        dtgVinyetas.RowTemplate.Height = 450;

                        //Oculto la columna del identificador.
                        dtgVinyetas.Columns[0].Visible = false;
                        ((DataGridViewImageColumn)dtgVinyetas.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se ha podido conectar con la base de datos. Puedes continuar utilizando el programa sin conexión. Los datos no se guardarán.", "Error en la base de datos", MessageBoxButtons.OK);
                    }
                }
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando se pinta el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormFavoritos_Paint(object sender, PaintEventArgs e)
        {
            //Si tiene conexión, se define el tema.
            Config.DefineTema();

            String[] Tema = Config.Tema;
            //El fondo se establece como un degradado entre el color 1 y el color 2.
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle,
                ColorTranslator.FromHtml(Tema[0]), ColorTranslator.FromHtml(Tema[1]), 90f);
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);

            //Cambio el color del fondo del dataGridView
            dtgVinyetas.BackgroundColor = ColorTranslator.FromHtml(Tema[2]);

        }

        /// <summary>
        /// Método que se ejecuta cuando se pulsa una celda del dataGridView.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void DtgVinyetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtengo el identificador de la viñeta.
            int id = (int)dtgVinyetas.CurrentRow.Cells[0].Value;

            //Obtengo el título de la viñeta.
            String titulo = dtgVinyetas.CurrentRow.Cells[1].Value.ToString();

            //Obtengo la imagen de la fila actual.
            byte[] bytes = (byte[])dtgVinyetas.CurrentRow.Cells[2].Value;
            Image imagen;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                imagen = Image.FromStream(ms);
            }

            //Creo el formulario y lo muestro.
            FormDetalleVinyetaFav formDetalleVinyetaFav = new FormDetalleVinyetaFav(imagen, titulo,id);
            formDetalleVinyetaFav.ShowDialog();
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de cerrar.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
