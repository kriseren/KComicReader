using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KComicReader
{
    public partial class FormItemLabelButton : UserControl
    {
        //Definición de propiedades.
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Etiqueta
        {
            get { return lblItem.Text; }
            set { lblItem.Text = value; }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ValorBoton
        {
            get { return btnItem.Text; }
            set { btnItem.Text = value; }
        }

        public FormItemLabelButton()
        {
            InitializeComponent();
        }

        //Método que se activa cuando se pulsa el botón del 

        private void btnItem_Click(object sender, EventArgs e)
        {

        }

        private void lblItem_Click(object sender, EventArgs e)
        {

        }
    }
}
