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
    public partial class Oefening1 : Form
    {
        Pretpark myPark = new Pretpark("CottonCandyMountain");
        FormAddWorker addWorkerForm;

        public Oefening1()
        {
            InitializeComponent();
        }
        private void Oefening1_Load(object sender, EventArgs e)
        {

            myPark.WerknemersList.Add(new Werknemer("Dummy", "Unknown", new DateTime(1991, 5, 8)));
            lbWerknemers.DataSource = myPark.WerknemersList;

            myPark.AttractieList.Add(new Attractie("Merry-Go-Round","Rood", 5, 30));
            lbAttracties.DataSource = myPark.AttractieList;
            gbPretpark.Text = myPark.Name;
        }

        private void btnAddWerker_Click(object sender, EventArgs e)
        {
            addWorkerForm = new FormAddWorker();
            addWorkerForm.Show();
            addWorkerForm.btnAddWorker.Click += new EventHandler(btnAddWorker_Click);

        }
        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            myPark.WerknemersList.Add(new Werknemer(addWorkerForm.txtName.Text, addWorkerForm.cbGender.SelectedItem.ToString(), addWorkerForm.calBirthDate.SelectionRange.Start.Date));
            addWorkerForm.Close();
            lbWerknemers.DataSource = null;
            lbWerknemers.DataSource = myPark.WerknemersList;
        }

        private void btnRemoveWerker_Click(object sender, EventArgs e)
        {
            myPark.WerknemersList.RemoveAt(lbWerknemers.SelectedIndex);
        }
        public void AddWorker(string name, string gender, DateTime birthdate)
        {
            myPark.WerknemersList.Add(new Werknemer(name, gender, birthdate));
        }
        private void UpdateList(List<Attractie> list)
        {

        }

        private void lbWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWerknemers.SelectedIndex >= 0)
            {
                lblNameW.Text = "Naam:       " + myPark.WerknemersList[lbWerknemers.SelectedIndex].Name;
                lblGender.Text = "Geslacht:   " + myPark.WerknemersList[lbWerknemers.SelectedIndex].Gender;
                lblBirthDate.Text = "Geboren op:\n" + myPark.WerknemersList[lbWerknemers.SelectedIndex].BirthDate.ToString("dd.MM.yyyy");

            }
        }

        private void lbAttracties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWerknemers.SelectedIndex >= 0)
            {
                lblNameA.Text = "Naam: " + myPark.AttractieList[lbAttracties.SelectedIndex].Name;
                lblColor.Text = "Kleur:         " + myPark.AttractieList[lbAttracties.SelectedIndex].Color;
                lblMinAge.Text = "Min. leeftijd: " + myPark.AttractieList[lbAttracties.SelectedIndex].MinAge.ToString();
                lblMaxPers.Text = "Max. Pers.  :  " + myPark.AttractieList[lbAttracties.SelectedIndex].MaxPers.ToString();

            }

        }
    }
}
