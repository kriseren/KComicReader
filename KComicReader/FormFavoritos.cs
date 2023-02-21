﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                        cmd.CommandText = "SELECT f.titulo, f.vinyeta, c.titulo FROM FAVORITOS f JOIN COMICS c ON f.comic_id = c.id";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtgVinyetas.DataSource = dataTable;

                        //Configuro el aspecto visual del dataGridView.
                        dtgVinyetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtgVinyetas.Columns[0].HeaderText = "Título";
                        dtgVinyetas.Columns[1].HeaderText = "Imagen";
                        dtgVinyetas.Columns[2].HeaderText = "Título del comic";
                        dtgVinyetas.RowTemplate.Height = 450;
                        ((DataGridViewImageColumn)dtgVinyetas.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Zoom;

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
    }
}
