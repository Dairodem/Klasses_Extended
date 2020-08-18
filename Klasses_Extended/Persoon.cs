using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_Extended
{
    class Persoon
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Persoon(string name, string gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }
    }
}
