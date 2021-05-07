using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017
{
    public class T_Speicher_Eintrittskarte
    {
        private string kartennummer;
        private DateTime kaufdatum;
        private DateTime gueltig_bis;
        private double betrag;
        private bool erloeschen;
        private List<T_Speicher_Besuch> besuche;

        public string erstelle_Karte(DateTime _kaufdatum, DateTime _gueltig_bis, double _betrag)
        {
            // aufgabenstellung unkar!!!!????

            kaufdatum = _kaufdatum;
            gueltig_bis = _gueltig_bis;
            betrag = _betrag;

            kartennummer = "T0085-17V";//naechste_lfd_Kartennummer()

            // ist eigentlich völliger quatsch
            if (DateTime.Now > gueltig_bis)
                erloeschen = true;
            else
                erloeschen = false;

            return kartennummer + "/" + kaufdatum + "/" + gueltig_bis + "/" + betrag + "/" + erloeschen;
        }
    }
}