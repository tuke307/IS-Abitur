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

namespace Vorabi._2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dg_termine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private List<Termin> termine = new List<Termin>();

        private void button1_Click(object sender, EventArgs e)
        {
            termine = new List<Termin>();
            string[] lines;
            string datum;
            string zeit;
            string mitarbeiterStatus;

            lines = File.ReadAllLines(@"C:\Users\Tony\Source\Repos\tuke307\IS-Abitur\2018\2018.1\Termine.txt");

            foreach (string line in lines)
            {
                string[] subs = line.Split(' ');

                datum = subs[0];
                zeit = subs[1];
                mitarbeiterStatus = subs[2];

                Termin termin = new Termin(datum, zeit, mitarbeiterStatus);
                termine.Add(termin);
            }

            dg_termine.DataSource = termine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Termin termin;
            string line = txtb_terminanfrage.Text;
            string datum;
            string zeit;

            int datumEndePos = line.IndexOf(",");

            datum = line.Substring(0, datumEndePos);
            zeit = line.Substring(datumEndePos + 1);

            try
            {
                termin = termine.Where(t => t.Datum == datum && t.Zeit == zeit).First();
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler bei Termineingabe");
                return;
            }

            // frei
            if (termin.Mitarbeiter == "frei")
            {
                MessageBox.Show("Der Termin wird bestätigt");
                termine.Where(t => t.Datum == datum && t.Zeit == zeit).First().Mitarbeiter = "T";
                refreshdatasrouce();
                return;
            }

            // alternativer termin
            if (termin.Mitarbeiter == "T")
            {
                MessageBox.Show("Es wurde ein alternativer Termin gefunden");
                termine.Where(t => t.Datum == datum && t.Zeit == zeit).First().Mitarbeiter = "R"; refreshdatasrouce();
                return;
            }

            // kein termin verfügbar
            if (termin.Mitarbeiter == "R")
            {
                MessageBox.Show("Es ist kein Termin verfügbar. Der Kunde muss seine Anfrage später noch einmal wiederholen");
            }
        }

        private void refreshdatasrouce()
        {
            dg_termine.DataSource = termine;
            dg_termine.Refresh();
        }

        public void irgendwas()
        {
            // deklaration
            Termin montag;

            // instanzierung
            //montag = new Termin(DateTime.Now, "frei");

            //// getter
            //DateTime montagDatum = montag.getDate();

            //// setter
            //montag.setDate(DateTime.Now);
        }
    }
}