using MySql.Data.MySqlClient;
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
    public partial class FormDetalleVinyetaFav : Form
    {
        /// <summary>
        /// Define si el zoom está activado o desactivado.
        /// </summary>
        private bool zoomOn = false;

        /// <summary>
        /// La imagen original de la página actual sin zoom.
        /// </summary>
        private Image img;

        /// <summary>
        /// El título de la viñeta favorita a mostrar.
        /// </summary>
        private String titulo;

        /// <summary>
        /// Constructor con parámetros que inicializa el componente.
        /// </summary>
        /// <param name="img">La imagen de la viñeta a mostrar.</param>
        /// <param name="titulo">El título de la viñeta a mostrar.</param>
        public FormDetalleVinyetaFav(Image img, String titulo)
        {
            InitializeComponent();
            this.CenterToParent();
            this.img = img;
            this.titulo = titulo;
        }

        /// <summary>
        /// Método que se ejecuta cuando el formulario es cargado.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FormLeer_Load(object sender, EventArgs e)
        {
            pbPagina.Image = img;
            lblTituloVinyeta.Text = titulo;
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
                case Keys.Z: Zoom(); break;

                case Keys.D: Descarga(); break;
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
        /// Método que se ejecuta cuando el usuario pulsa en el botón de descargar viñeta favorita.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void pbBtnDescargar_Click(object sender, EventArgs e)
        {
            Descarga();
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
        /// Método que se ejecuta cuando el usuario pulsa el botón de descargar la imagen.
        /// </summary>
        private void Descarga()
        {
            //Ruta del directorio donde se guardará la viñeta.
            string rutaDirectorio = Path.Combine(Config.DirectorioInstalacion, "viñetasFavoritas");
            //El nombre del archivo se saca reemplazando los espacios por barras bajas y añadiendo la extensión jpg.
            string nombreArchivo = titulo.Replace(" ","_") + ".jpg";

            //Crea el directorio si no existe.
            if (!Directory.Exists(rutaDirectorio))
                Directory.CreateDirectory(rutaDirectorio);


            //TODO HACER QUE FUNCIONE EL MÉTODO, PUESTO QUE DA UN ERROR DE PARÁMETRO INVÁLIDO.
            //Copio el archivo de cómic al directorio especificado si no existe ya.
            if (!File.Exists(Path.Combine(rutaDirectorio, nombreArchivo)))
            {
                img.Dispose();
                img.Save(Path.Combine(rutaDirectorio, nombreArchivo));
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
    }
}
