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
    public partial class FormItemLabelTextbox : UserControl
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
        public string Valor
        {
            get { return tbItem.Text; }
            set { tbItem.Text = value; }
        }

        public FormItemLabelTextbox()
        {
            InitializeComponent();
        }
    }
}
