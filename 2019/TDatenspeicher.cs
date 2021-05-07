using System;
using System.IO;

namespace _2019
{
    /// <summary>
    /// Datenspeicherklasse
    /// </summary>
    public class TDatenspeicher
    {
        private static string gastfile = @"C:\Users\Tony\Source\Repos\tuke307\IS-Abitur\2019\Gast.txt";
        private static string ortfile = @"C:\Users\Tony\Source\Repos\tuke307\IS-Abitur\2019\Ort.txt";

        /// <summary>
        /// gibt einen neuen ortsID (maximaler vorhandener ortsID+1) zurück
        /// </summary>
        /// <returns></returns>
        public int getNeuerOrtsId()
        {
            string[] lines = File.ReadAllLines(ortfile);
            string lastline = lines[lines.GetUpperBound(0)];

            // {ortsID, plz, ortsname}
            string[] ortLine = lastline.Split(",");

            return Convert.ToInt32(ortLine[0]) + 1;
        }

        /// <summary>
        /// gibt einen neuen gastID (maximaler vorhandener gastID+1) zurück
        /// </summary>
        /// <returns></returns>
        public int getNeuerGastId()
        {
            string[] lines = File.ReadAllLines(gastfile);
            string lastline = lines[lines.GetUpperBound(0)];

            // {gastID, gName, vorname, strasse, ortsID}
            string[] ortLine = lastline.Split(",");

            return Convert.ToInt32(ortLine[0]) + 1;
        }

        /// <summary>
        /// prüft, ob Ort/PLZ in Ort.txt vorhanden sind und gibt den vorhandenen ortsID zurück oder trägt einen neuen Ort ein und gibt diesen neuen ortsID zurück
        /// </summary>
        /// <param name="plz">The PLZ.</param>
        /// <param name="ort">The ort.</param>
        /// <returns></returns>
        public int ortEintragen(string plz, string ort)
        {
            int neuerOrtid;
            string[] lines = File.ReadAllLines(ortfile);

            foreach (var line in lines)
            {
                // {ortsID, plz, ortsname}
                string[] ortLine = line.Split(",");
                if (ortLine[1] == plz && ortLine[2] == ort)
                    return Convert.ToInt32(ortLine[0]);
            }
            neuerOrtid = getNeuerOrtsId();
            string ortneu = Environment.NewLine + neuerOrtid + ", " + plz + ", " + ort;

            File.AppendAllText(ortfile, ortneu);

            // wenn nicht return wird, wurde kein passender ort gefunden
            return neuerOrtid;
        }

        /// <summary>
        /// ruft ortEintragen(..), trägt in Gast.txt gastID, gName, vorname, strasse, ortsID ein.
        /// </summary>
        /// <param name="gast">The gast.</param>
        public void gastEintragen(TGast gast)
        {
            // {gastID, gName, vorname, strasse, ortsID}
            string gastneu = Environment.NewLine + getNeuerGastId() + ", " + gast.getName() + ", " + gast.getVorname() + ", " + gast.getStrasse() + ", " + ortEintragen(gast.getPLZ(), gast.getOrt());

            File.AppendAllText(gastfile, gastneu);
        }
    }
}