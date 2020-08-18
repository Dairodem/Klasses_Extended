using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses_Extended
{
    class Afspraak
    {
        public string Name { get;set;}
        public DateTime Date { get; set; }
        public int Hour { get; set; }

        public Afspraak(string name, DateTime date, int hour)
        {
            Name = name;
            Date = date;
            Hour = hour;
        }
    }
}
