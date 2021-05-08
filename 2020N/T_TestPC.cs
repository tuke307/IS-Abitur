using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020N
{
    public class T_TestPC
    {
        private string hostname;
        private List<string> fehlermeldung = new List<string>();

        public void create(string pHostName)
        {
            hostname = pHostName;
        }

        public string getHostname()
        {
            return hostname;
        }

        public string getFehlermeldung()
        {
            return string.Join(Environment.NewLine, fehlermeldung);
        }

        public void fehler_anmelden(string pFehlermeldung)
        {
            fehlermeldung.Add(pFehlermeldung);
        }

        public void fehler_beseitigt(int listenindex)
        {
            if (fehlermeldung.Count < listenindex)
                return;

            fehlermeldung.RemoveAt(listenindex - 1);
        }
    }
}