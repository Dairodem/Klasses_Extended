using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasses_Extended
{
    public partial class FormAddAttraction : Form
    {
        public string[] Colors = new string[] 
        { 
            "Blauw", "Geel", "Groen", "Rood", "Paars", "Roze", "Cyaan", "Magenta", "Wit", "Zwart" 
        };

        public FormAddAttraction()
        {
            InitializeComponent();
        }
        private void FormAddAttraction_Load(object sender, EventArgs e)
        {
            cbColors.DataSource = Colors;
        }
    }
}
