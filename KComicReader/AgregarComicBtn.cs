using System;
using System.Drawing;
using System.Windows.Forms;

namespace KComicReader
{
    /// <summary>
    /// Control personalizado que representa el botón de agregar un cómic.
    /// </summary>
    public partial class AgregarComicBtn : UserControl
    {
        /// <summary>
        /// El número identificador del botón de agregar cómic.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// El título del botón de agregar cómic.
        /// </summary>
        public String Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }
        /// <summary>
        /// La imagen de portada del botón de agregar cómic.
        /// </summary>
        public Image Portada
        {
            get { return pbPortada.Image; }
            set { pbPortada.Image = value; }
        }
        /// <summary>
        /// El evento invocado cuando se hace click en cualquier parte del control.
        /// </summary>
        public EventHandler EventoClick { get; set; }

        /// <summary>
        /// Constructor sin parámetros que inicializa el componente.
        /// </summary>
        public AgregarComicBtn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que ejecuta el evento click cuando el usuario hace click en cualquiera de los componentes del control.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void Control_Click(object sender, EventArgs e)
        {
            EventoClick.Invoke(this, e);
        }
    }
}
