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
    public partial class comic : UserControl
    {
        //Definición de propiedades.
        private int id;
        private String titulo;
        
        public comic()
        {
            InitializeComponent();
        }
    }
}
