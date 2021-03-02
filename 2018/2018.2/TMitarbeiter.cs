using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorabi._2018._2
{
    public class TMitarbeiter
    {
        protected string Mitarbeiternummer;
        protected string Name;
        protected Single Grundgehalt;

        public void create(string nr, string name, Single g)
        {
            Mitarbeiternummer = nr;
            Name = name;
            Grundgehalt = g;
        }
        public string getInfo()
        {
            return 
                nameof(Mitarbeiternummer) + ": " + Mitarbeiternummer.ToString() +Environment.NewLine + 
                nameof(Name) + ": " + Name.ToString() + Environment.NewLine +
                nameof(Grundgehalt) + ": " + Grundgehalt.ToString("0000.00") + " €" + Environment.NewLine;
        }
    }
}
