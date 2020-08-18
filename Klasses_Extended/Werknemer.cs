using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_Extended
{
    class Werknemer
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

        public Werknemer(string name, string gender, DateTime birthdate)
        {
            Name = name;
            BirthDate = birthdate;
            Gender = gender;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
