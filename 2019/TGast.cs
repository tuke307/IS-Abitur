using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019
{
    public class TGast
    {
        private int gastID;
        private string gName;
        private string vorname;
        private string strasse;
        private string plz;
        private string ort;

        public void neu(string name, string vorname, string strasse, string plz, string ort)
        {
            this.gName = name;
            this.vorname = vorname;
            this.strasse = strasse;
            this.plz = plz;
            this.ort = ort;
        }

        public string getName()
        {
            return gName;
        }

        public string getVorname()
        {
            return vorname;
        }

        public string getStrasse()
        {
            return strasse;
        }

        public string getPLZ()
        {
            return plz;
        }

        public string getOrt()
        {
            return ort;
        }
    }
}