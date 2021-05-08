using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016
{
    public partial class Form1 : Form
    {
        private string BEGIN = "BEGIN:VEVENT";
        private string END = "END:VEVENT";

        private string VALUEDATE = "VALUE=DATE:";
        private string TZIDEUROPE = "TZID=Europe/Berlin:";

        private string SUMMARY = "SUMMARY:";
        private string DTSTART = "DTSTART;";
        private string DTEND = "DTEND;";
        private string LOCATION = "LOCATION:";
        private string DESCRIPTION = "DESCRIPTION:";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_einlesen_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "ics files (*.ics)|*.ics";
                //openFileDialog.FilterIndex = 2;
                //openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    handleicsfile(File.ReadAllLines(filePath));
                }
            }
        }

        private DateTime parseDate(string line)
        {
            string start = string.Empty;
            DateTime startDateTime;

            // TODO: geht noch ne
            if (line.Contains(VALUEDATE))
            {
                //start = line.Substring(DTSTART.Length + VALUEDATE.Length);

                return DateTime.Now;
            }
            else if (line.Contains(TZIDEUROPE))
            {
                //start = line.Substring(DTSTART.Length + TZIDEUROPE.Length);
                //start = start.Remove(start.IndexOf("T"), 1);

                return DateTime.Now;
            }

            return DateTime.Parse(start);
        }

        /// <summary>
        /// ICS content handler. geht bestimmt auch besser lul.
        /// </summary>
        /// <param name="lines">The lines.</param>
        private void handleicsfile(string[] lines)
        {
            string starttag = string.Empty;
            string startzeit = string.Empty;
            string endtag = string.Empty;
            string endzeit = string.Empty;
            string ort = string.Empty;
            string titel = string.Empty;
            string beschreibung = string.Empty;

            foreach (var line in lines)
            {
                if (line.Contains(SUMMARY))
                    titel = line.Substring(SUMMARY.Length);

                if (line.Contains(DTSTART))
                {
                    DateTime startDateTime = parseDate(line);
                    starttag = startDateTime.Date.ToString();
                    startzeit = startDateTime.Hour.ToString() + ":" + startDateTime.Minute.ToString();
                }

                if (line.Contains(DTEND))
                {
                    DateTime endeDateTime = parseDate(line);
                    endtag = endeDateTime.Date.ToString();
                    endzeit = endeDateTime.Hour.ToString() + ":" + endeDateTime.Minute.ToString();
                }

                if (line.Contains(LOCATION))
                    ort = line.Substring(LOCATION.Length);

                if (line.Contains(DESCRIPTION))
                    beschreibung = line.Substring(DESCRIPTION.Length);

                if (line.Contains(END))
                {
                    string[] termin = { starttag, startzeit, endtag, endzeit, ort, titel, beschreibung };
                    dgv_termine.Rows.Add(termin);
                }
            }
        }
    }
}