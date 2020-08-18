using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_Extended
{
    class Ziekenhuis
    {
        public List<Dokter> DokterList { get; set; }

        private readonly List<string> nameList = new List<string>() 
        {
            "A. Naessens",
            "D. Klaus",
            "K. Walters",
            "L. Deleeuw",
            "L. Naessens",
            "O. Vertonghen",
            "W. Michiels",

        };

        public Ziekenhuis()
        {
            DokterList = new List<Dokter>();
            AddDoctors();
        }
        private void AddDoctors()
        {
            for (int i = 0; i < nameList.Count; i++)
            {
                DokterList.Add(new Dokter(nameList[i]));
            }
        }
    }
}
