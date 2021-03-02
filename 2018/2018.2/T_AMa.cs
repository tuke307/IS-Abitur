using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorabi._2018._2
{
    public class T_AMa : TMitarbeiter
    {
        protected Single Bewertung;
        public void create(string nr, string name, Single g, Single b)
        {
            base.create(nr, name, g);

            Bewertung = b;
        }
        public string getInfo()
        {
            return
                "Außendienstmitarbeiter" + Environment.NewLine + Environment.NewLine +
                base.getInfo() +
                nameof(Bewertung) + ": " + Bewertung.ToString("0.0") + " Punkte" + Environment.NewLine + Environment.NewLine +
                "Gehalt: " + (Grundgehalt*(100+Bewertung)).ToString("0000.00") + " €";
        }
    }
}
