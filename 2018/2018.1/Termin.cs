using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorabi._2018
{
    public class Termin
    {
        private DateTime Datum;
        public string Mitarbeiter;

        public Termin(DateTime datum, string mitarbeiter)
        {
            Datum = datum;
            Mitarbeiter = mitarbeiter;
        }

        public void setDate(DateTime datum)
        {
            Datum = datum;
        }

        public DateTime getDate()
        {
            return Datum;
        }
    }
}