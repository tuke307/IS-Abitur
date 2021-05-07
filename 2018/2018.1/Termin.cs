using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorabi._2018
{
    public class Termin
    {
        public string Datum { get; set; }
        public string Zeit { get; set; }
        public string Mitarbeiter { get; set; }

        public Termin(string datum, string zeit, string mitarbeiter)
        {
            Datum = datum;
            Zeit = zeit;
            Mitarbeiter = mitarbeiter;
        }
    }
}