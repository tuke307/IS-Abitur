using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorabi._2018._2
{
    public class T_SMa :TMitarbeiter
    {
        protected Single Fehltage;
        public void create(string nr, string name, Single g, Single f)
        {
            base.create(nr, name, g);

            Fehltage = f;
        }
        public string getInfo()
        {
            double gehalt;

            if(Fehltage == 0)
            {
                gehalt = Grundgehalt * 1.05;

            }
            else if(Fehltage == 1)
            {
                gehalt = Grundgehalt * 1.03;
            }
            else
            {
                gehalt = Grundgehalt;
            }

            return
                "Außendienstmitarbeiter" + Environment.NewLine + Environment.NewLine +
                base.getInfo() +
                nameof(Fehltage) + ": " + Fehltage.ToString() + " Punkte" + Environment.NewLine + Environment.NewLine +
                "Gehalt: " + gehalt.ToString("0000.00") + " €";
        }
    }
}
