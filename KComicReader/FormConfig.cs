
using MySql.Data.MySqlClient;
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
    public partial class FormConfig : Form
    {
        //Definición de propiedades.
        public string DirectorioInstalacion {get;set;}
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
            tbDirectorioValue.Text = Config.DirectorioInstalacion;
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
    }
}
