﻿using MySql.Data.MySqlClient;
using SharpCompress.Archives;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace KComicReader
{
    /// <summary>
    /// Formulario que implementa toda la funcionalidad para leer un cómic.
    /// </summary>
    public partial class FormLeer : Form
    {
        /// <summary>
        /// El control personalizado del cómic que se va a leer.
        /// </summary>
        public Comic comic;

        /// <summary>
        /// El número de página que se está leyendo.
        /// </summary>
        private uint numPag = 0;

        /// <summary>
        /// Objeto que contiene el archivo CBR descomprimido.
        /// </summary>
        private IArchive archive;

        /// <summary>
        /// Define si el zoom está activado o desactivado.
        /// </summary>
        private bool zoomOn = false;

        /// <summary>
        /// La imagen original de la página actual sin zoom.
        /// </summary>
        private Image img;

        /// <summary>
        /// Constructor con parámetros que inicializa el componente.
        /// </summary>
        /// <param name="comic">El control personalizado del cómic que se va a leer.</param>
        public FormLeer(Comic comic)
        {
            InitializeComponent();
            this.CenterToParent();
            this.comic = comic;
            this.numPag = comic.NumPaginaActual;
            archive = ArchiveFactory.Open(comic.ArchivoURL);
            this.Text = comic.Titulo;
        }

        /// <summary>
        /// Método que se ejecuta cuando el formulario es cargado.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormLeer_Load(object sender, EventArgs e)
        {
            Config.LeyendoComic = true;
            DefinePagina();
            lblNumPaginas.Text = "Página " + (numPag + 1) + " de " + comic.NumPaginasTotales;
            if(comic.Id < 1)
            {
                pbBtnFavorito.Visible = false;
            }
        }

        /// <summary>
        /// Método que define la imagen de la página que se está visualizando.
        /// </summary>
        private void DefinePagina()
        {
            try
            {
                archive = ArchiveFactory.Open(comic.ArchivoURL);
                //Obtengo el primer elemento y lo almaceno en la variable imagen.
                var portada = archive.Entries.ElementAt(Convert.ToInt32(numPag));
                //Defino la imagen de la página actual.
                pbPagina.Image = Image.FromStream(portada.OpenEntryStream());
                img = pbPagina.Image;
            }
            catch (Exception ex)
            {
                // Aquí se pueden agregar acciones para manejar la excepción, como mostrar un mensaje de error.
                Console.WriteLine("Ocurrió una excepción: " + ex.Message);
            }

            //Si la página está marcada en favoritos se cambia el botón.
            if(Existe())
            {
                pbBtnFavorito.Enabled = false;
                pbBtnFavorito.Image = pbBtnFavorito.Image = Image.FromFile(Path.Combine(Config.Recursos, "imgs", "icons", "favFull.png"));
            }
            else
            {
                pbBtnFavorito.Enabled = true;
                pbBtnFavorito.Image = pbBtnFavorito.Image = Image.FromFile(Path.Combine(Config.Recursos, "imgs", "icons", "fav.png"));
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de "Siguiente página".
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            SiguientePagina();
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa el botón de "Anterior página".
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            AnteriorPagina();
        }


        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa cualquier tecla dentro del formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Key_Down(object sender, KeyEventArgs e)
        {
            //Dependiendo de la tecla pulsada.
            switch (e.KeyCode)
            {
                case Keys.Right:
                case Keys.D: SiguientePagina(); break;

                case Keys.Left:
                case Keys.A: AnteriorPagina(); break;

                case Keys.Z: Zoom(); break;

                case Keys.F: MarcarFavorito(); break;
            }
        }

        /// <summary>
        /// Método que carga la página anterior.
        /// </summary>
        private void AnteriorPagina()
        {
            //Si el número de página es distinto de 0, se carga.
            if (numPag > 0)
            {
                numPag--;
                DefinePagina();
            }
            CambiaPaginaComun();
        }

        /// <summary>
        /// Método que carga la página siguiente.
        /// </summary>
        private void SiguientePagina()
        {
            //Si el número de página no es el último, se carga.
            if (numPag < archive.Entries.Count() - 1)
            {
                numPag++;
                DefinePagina();
            }
            CambiaPaginaComun();
        }

        /// <summary>
        /// Método que realiza las líneas de código comunes cuando se cambia de página.
        /// </summary>
        private void CambiaPaginaComun()
        {
            //Cambio el texto que indica las páginas.
            lblNumPaginas.Text = "Página " + (numPag + 1) + " de " + comic.NumPaginasTotales;

            //Si el zoom está activo, se define el zoom.
            if (zoomOn)
            {
                ZoomIn();
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa en el botón de zoom.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Zoom_Click(object sender, EventArgs e)
        {
            Zoom();
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario pulsa en el botón de añadir a favoritos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbBtnFavorito_Click(object sender, EventArgs e)
        {
            MarcarFavorito();
        }

        /// <summary>
        /// Método que abre el formulario de agregación a favoritos.
        /// </summary>
        private void MarcarFavorito()
        {
            FormAgregarFavoritos formAgregarFavoritos = new FormAgregarFavoritos(comic,img,numPag);
            if(formAgregarFavoritos.ShowDialog()==DialogResult.OK)
            {
                if (Config.CompruebaConexion())
                {
                    //Creo la conexión y los objetos necesarios.
                    using (MySqlConnection con = DataBaseConnectivity.GetConnection())
                    {
                        try
                        {
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();

                            //Defino la consulta para insertar la serie.
                            cmd.CommandText = "INSERT INTO FAVORITOS (titulo,vinyeta,comic_id,numPagina) VALUES (@titulo,@viñeta,@comic_id,@numPagina)";
                            cmd.Parameters.AddWithValue("@titulo", formAgregarFavoritos.Titulo);
                            cmd.Parameters.AddWithValue("@comic_id", formAgregarFavoritos.Comic.Id);
                            cmd.Parameters.AddWithValue("@numPagina", formAgregarFavoritos.NumPag);
                            //Defino la viñeta.
                            using (var memoryStream = new MemoryStream())
                            {
                                formAgregarFavoritos.Vinyeta.Save(memoryStream, ImageFormat.Jpeg);
                                byte[] imageBytes = memoryStream.ToArray();
                                cmd.Parameters.AddWithValue("@viñeta", imageBytes);
                            }
                            cmd.Prepare();
                            cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("No se ha podido insertar la viñeta en favoritos.", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                //Cambio la imagen del botón para mostrar que se ha agregado a favoritos.
                pbBtnFavorito.Image = Image.FromFile(Path.Combine(Config.Recursos, "imgs", "icons", "favFull.png"));
            }
        }

        /// <summary>
        /// Método que aplica el zoom a la imagen.
        /// </summary>
        private void Zoom()
        {
            //Invierto el valor del zoom.
            zoomOn = !zoomOn;

            //Cambia la imagen dependiendo del zoom.
            if (zoomOn)
            {
                btnZoom.Image = Image.FromFile(Path.Combine(Config.Recursos, "imgs", "icons", "zoomOut.png"));
                ZoomIn();
            }
            else
            {
                btnZoom.Image = Image.FromFile(Path.Combine(Config.Recursos, "imgs", "icons", "zoomIn.png"));
                ZoomOut();
            }
        }

        /// <summary>
        /// Método que redimensiona la imagen dependiendo del ancho del panel tamaño del formulario para hacer un zoom.
        /// </summary>
        private void ZoomIn()
        {
            pbPagina.Anchor = AnchorStyles.Top;
            pbPagina.SizeMode = PictureBoxSizeMode.AutoSize;
            int anchoNuevo = panelImage.Width;
            int altoOriginal = img.Height;

            //Defino un nuevo tamaño calculando el alto con la proporción original.
            Size newSize = new Size(anchoNuevo, (altoOriginal * anchoNuevo) / img.Width);
            pbPagina.Image = new Bitmap(pbPagina.Image, newSize);
        }

        /// <summary>
        /// Método que devuelve la imagen al estado inicial, sin el zoom.
        /// </summary>
        private void ZoomOut()
        {
            pbPagina.Image = img;
            pbPagina.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pbPagina.Dock = DockStyle.Fill;
            pbPagina.SizeMode = PictureBoxSizeMode.Zoom;
        }

        /// <summary>
        /// Método que se ejecuta cuando el usuario redimensiona el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Form_Resize(object sender, EventArgs e)
        {
            ZoomOut();
        }

        /// <summary>
        /// Método que marca la página actual y la almacena.
        /// </summary>
        private void Marcar()
        {
            //Defino la página actual y la almaceno en la base de datos.
            comic.NumPaginaActual = numPag;
            using (MySqlConnection connection = DataBaseConnectivity.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE comics SET numPagina = @numPagina WHERE id = @id";
                    cmd.Parameters.AddWithValue("@numPagina", comic.NumPaginaActual);
                    cmd.Parameters.AddWithValue("@id", comic.Id);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ha ocurrido un error al marcar la página.", "Error en la base de datos", MessageBoxButtons.OK);
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
                    cmd.Parameters.AddWithValue("@comic_id", comic.Id);
                    cmd.Parameters.AddWithValue("@numPagina", numPag);
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
        /// Método que se ejecuta cuando se pinta el formulario.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormLeer_Paint(object sender, PaintEventArgs e)
        {
            //Si tiene conexión, se define el tema.
            Config.DefineTema();

            String[] Tema = Config.Tema;

            if (this.ClientRectangle.Width != 0 || this.ClientRectangle.Height != 0)
            {
                //El fondo se establece como un degradado entre el color 1 y el color 2.
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle,
                    ColorTranslator.FromHtml(Tema[0]), ColorTranslator.FromHtml(Tema[1]), 90f);
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);

                //Si el tema es oscuro se define un color de fondo para el panel de los botones.
                if (Config.Tema_id == 8 || Config.Tema_id == 11)
                {
                    panelButtons.BackColor = ColorTranslator.FromHtml(Tema[2]);
                }
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando el formulario es cerrado.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormLeer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Config.LeyendoComic = false;

            //Se marca la página actual.
            Marcar();
        }
    }
}
