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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnOef1_Click(object sender, EventArgs e)
        {
            Oefening1 oefening1 = new Oefening1();

            oefening1.Show();
        }

        private void btnOef2_Click(object sender, EventArgs e)
        {
            Oefening2 oefening2 = new Oefening2();

            oefening2.Show();

        }

        private void btnOef3_Click(object sender, EventArgs e)
        {
            Oefening3 oefening3 = new Oefening3();

            oefening3.Show();

        }
    }
}
