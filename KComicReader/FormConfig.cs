
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
    public partial class FormConfig : Form
    {
        //Definición de propiedades.
        public string DirectorioInstalacion {get;set;}
        public string ColorFondo1 { get; set; }
        public string ColorFondo2 { get; set; }
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
            ColorFondo1 = Config.ColorFondo1;
            ColorFondo2 = Config.ColorFondo2;
            tbDirectorioValue.Text = Config.DirectorioInstalacion;
            pbBtnColor1.BackColor = ColorTranslator.FromHtml(Config.ColorFondo1);
            pbBtnColor2.BackColor = ColorTranslator.FromHtml(Config.ColorFondo2);
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
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
               this.ClientRectangle,
               ColorTranslator.FromHtml(Config.ColorFondo1),
               ColorTranslator.FromHtml(Config.ColorFondo2), 90f);
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
        }

        //Método que se ejecuta cuando el usuario hace click en el botón de seleccionar color 1.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                ColorFondo1 = ColorTranslator.ToHtml(cd.Color);
                pbBtnColor1.BackColor = cd.Color;
                lblColorSeleccionado1.Text = ColorFondo1;
            }
        }

        //Método que se ejecuta cuando el usuario hace click en el botón de seleccionar color 2.
        private void pbBtnColor2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                ColorFondo2 = ColorTranslator.ToHtml(cd.Color);
                pbBtnColor2.BackColor = cd.Color;
                lblColorSeleccionado2.Text = ColorFondo2;
            }
        }
    }
}
