using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*(mijnMisschienVragen)
 *      *  method in 'Oefening2.cs'voor alles? 
 *         method in 'Afspraak.cs' met een overload zonder datum maar via deze method?
 * 
 * 
 * 
 */




namespace Klasses_Extended
{
    public partial class Oefening2 : Form
    {
        readonly Ziekenhuis ziekenhuis = new Ziekenhuis();
        public Oefening2()
        {
            InitializeComponent();
        }

        private void Oefening2_Load(object sender, EventArgs e)
        {
            cbDoctors.DataSource = ziekenhuis.DokterList;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Afspraak afspraak;

            // (*)  Controleert of er een andere datum is ingegeven of vandaag (of in het verleden)
            if (dtpDate.Value.Date <= DateTime.Now.Date)
            {
                numHour.Value = DateTime.Now.Hour;
                if (numHour.Value > 19)
                {
                    numHour.Value = 7;
                }
                dtpDate.Value = DateTime.Now.Date.AddDays(1);

                afspraak = new Afspraak(txtInfo.Text, dtpDate.Value, (int)numHour.Value);
                ziekenhuis.DokterList[cbDoctors.SelectedIndex].AfsprakenList.Add(afspraak);
            }
            else
            {
                afspraak = new Afspraak(txtInfo.Text, dtpDate.Value, (int)numHour.Value);
                ziekenhuis.DokterList[cbDoctors.SelectedIndex].AfsprakenList.Add(afspraak);

            }

            MessageBox.Show($"Nieuwe afspraak met {ziekenhuis.DokterList[cbDoctors.SelectedIndex]}\n" +
                            $"op {dtpDate.Value.ToString("dd.MM.yyyy")}\n" +
                            $"om {numHour.Value} uur\n" +
                            $"voor {afspraak.Name}."
                            );
        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
