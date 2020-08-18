using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_Extended
{
    class Pretpark
    {
        public string Name { get; set; }
        public List<Werknemer> WerknemersList { get; set; }
        public List<Attractie> AttractieList { get; set; }

        public Pretpark(string name)
        {
            Name = name;

            WerknemersList = new List<Werknemer>();
            AttractieList = new List<Attractie>();
        }

    }
}
