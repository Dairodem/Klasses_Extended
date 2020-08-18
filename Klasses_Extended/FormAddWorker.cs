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
    public partial class FormAddWorker : Form
    {
        public string[] genders = new string[] { "Man", "Vrouw" };
        public FormAddWorker()
        {
            InitializeComponent();
        }
        public string MyName
        {
            get { return txtName.Text; }
        }
        public string Gender
        {
            get { return cbGender.SelectedItem.ToString(); }
        }

        private void FormAddWorker_Load(object sender, EventArgs e)
        {
            cbGender.Items.AddRange(genders);
            cbGender.SelectedIndex = 0;
            
            
        }

        public void btnAddWorker_Click(object sender, EventArgs e)
        {
            
        }
    }
}
