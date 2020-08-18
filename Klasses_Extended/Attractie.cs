using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_Extended
{
    class Attractie
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int MinAge { get; set; }
        public int MaxPers { get; set; }

        public Attractie(string name, int minAge, int maxPers)
        {
            Name = name;
            MinAge = minAge;
            MaxPers = maxPers;
            Color = "none";

        }
        public Attractie(string name, string color, int minAge, int maxPers)
        {
            Name = name;
            MinAge = minAge;
            MaxPers = maxPers;
            Color = color;

        }
        public override string ToString()
        {
            return Name;
        }
    }
}
