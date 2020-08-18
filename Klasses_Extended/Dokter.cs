using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_Extended
{
    class Dokter
    {
        public string Name { get; set; }
        public List<Afspraak> AfsprakenList { get; set; }

        public Dokter(string name)
        {
            Name = name;
            AfsprakenList = new List<Afspraak>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
