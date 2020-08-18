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
    public partial class Oefening3 : Form
    {
        Dansles dansles;
        List<string> participantsList = new List<string>();

        private string[] Genders = new string[] { "Man", "Vrouw" };
        private string[] arrChosen = new string[6];

        public Oefening3()
        {
            InitializeComponent();
        }


        private string InschrijvingsString(int aantal)
        {
            string myStr = $"Momenteel {aantal} inschrijvingen!!";

            return myStr;
        }
        private void CreateParticipants()
        {
            dansles = new Dansles();
            dansles.InschrijvingenList.Add(new Persoon("Michelle", "Vrouw", 18));
            dansles.InschrijvingenList.Add(new Persoon("Ella", "Vrouw", 13));
            dansles.InschrijvingenList.Add(new Persoon("Sofie", "Vrouw", 20));
            dansles.InschrijvingenList.Add(new Persoon("Mike", "Man", 12));
            dansles.InschrijvingenList.Add(new Persoon("Carla", "Vrouw", 29));
            dansles.InschrijvingenList.Add(new Persoon("Rosie", "Vrouw", 12));
            dansles.InschrijvingenList.Add(new Persoon("Bert", "Man", 32));
            dansles.InschrijvingenList.Add(new Persoon("Daisy", "Vrouw", 18));
            dansles.InschrijvingenList.Add(new Persoon("Cahoun", "Man", 15));
            dansles.InschrijvingenList.Add(new Persoon("Stefanie", "Vrouw", 14));
            dansles.InschrijvingenList.Add(new Persoon("Emma", "Vrouw", 22));
            dansles.InschrijvingenList.Add(new Persoon("Cassandra", "Vrouw", 24));
            dansles.InschrijvingenList.Add(new Persoon("Angelo", "Man", 17));
            dansles.InschrijvingenList.Add(new Persoon("Afita", "Vrouw", 16));
            dansles.InschrijvingenList.Add(new Persoon("Nora", "Vrouw", 24));
        }
        private void FillParticipantsList(List<Persoon> personList)
        {
            participantsList.Clear();

            foreach (Persoon item in personList)
            {
                participantsList.Add(item.Name);
            }

        }
        private void FillChosen()
        {
            for (int i = 0; i < arrChosen.Length; i++)
            {
                arrChosen[i] = RandName();
            }

        }
        private string RandName()
        {
            Random rnd = new Random();
            string chosen = participantsList[rnd.Next(0, participantsList.Count)];
            participantsList.Remove(chosen);

            return chosen;

        }
        private string MessageWinners()
        {
            string message = "";

            message = $"De winnaars zijn \n" +
                      arrChosen[0] + "\n" +
                      arrChosen[1] + "\n" +
                      arrChosen[2] + "\n" +
                      arrChosen[3] + "\n" +
                      arrChosen[4] + "\n" +
                      arrChosen[5] + "\n";

            return message;
        }

        private void Oefening3_Load(object sender, EventArgs e)
        {
            CreateParticipants();

            cbGender.Items.AddRange(Genders);
            cbGender.SelectedIndex = 0;

            lblInschrijvingen.Text = InschrijvingsString(dansles.InschrijvingenList.Count);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dansles.InschrijvingenList.Add(new Persoon(txtName.Text, cbGender.Text, (int)numAge.Value));

            MessageBox.Show($"{txtName.Text} is ingeschreven voor de Dansles\n\n Succes!!");

        }
        private void BtnFinish_Click(object sender, EventArgs e)
        {
            FillParticipantsList(dansles.InschrijvingenList);
            FillChosen();

            MessageBox.Show(MessageWinners());

        }
    }
}
