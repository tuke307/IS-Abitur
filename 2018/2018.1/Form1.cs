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
            string mitarbeiterStatus;

            lines = File.ReadAllLines(@"C:\Users\Tony\Source\Repos\tuke307\IS-Abitur\2018\2018.1\Termine.txt");

            foreach (string line in lines)
            {
                int leerzeichenPos = line.IndexOf(" ");

                datum = line.Substring(0, leerzeichenPos);
                mitarbeiterStatus = line.Substring(leerzeichenPos);

                Termin termin = new Termin(Convert.ToDateTime(datum), mitarbeiterStatus);
                termine.Add(termin);
            }

            dg_termine.DataSource = termine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = txtb_terminanfrage.Text;

            DateTime datum = Convert.ToDateTime(text);

            //Termin termin = termine.Where(t => t.Datum == datum).First();
            //termine.Remove(termin);

            //// frei
            //if (termin.Mitarbeiter == "frei")
            //{
            //    MessageBox.Show("frei, wird jetzt gebucht");
            //    termin = new Termin(datum, "T");
            //    termine.Add(termin);
            //}
            ////frei
            //else if (termin.Mitarbeiter == "T")
            //{
            //    MessageBox.Show("nicht frei");
            //}
        }

        public void irgendwas()
        {
            // deklaration
            Termin montag;

            // instanzierung
            montag = new Termin(DateTime.Now, "frei");

            // getter
            DateTime montagDatum = montag.getDate();

            // setter
            montag.setDate(DateTime.Now);
        }
    }
}