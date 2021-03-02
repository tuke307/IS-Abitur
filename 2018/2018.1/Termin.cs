using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorabi._2018
{
    public class Termin
    {
        public DateTime Datum { get; set; }
        public string Mitarbeiter { get; set; }

        public Termin()
        {

        }
        public Termin(DateTime datum, string mitarbeiter)
        {
            Datum = datum;
            Mitarbeiter = mitarbeiter;

        }
    }
}
