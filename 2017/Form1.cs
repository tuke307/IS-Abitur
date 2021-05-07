using _2017;
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
        private List<string> kaeufe = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaufen_Click(object sender, EventArgs e)
        {
            T_Speicher_Eintrittskarte karte = new T_Speicher_Eintrittskarte();
            DateTime kaufdatum = DateTime.Now;
            double betrag = 0;
            DateTime gueltig_bis = DateTime.Now;

            if (rb_jahreskarte.Checked)
            {
                gueltig_bis = DateTime.Now.AddYears(1);
            }
            //else if (rb_tageskarte.Checked)
            //{
            //    gueltig_bis = DateTime.Now;
            //}

            if (rb_vollerbetrag.Checked)
            {
                betrag = 50;
            }
            else if (rb_ermaeßigt.Checked)
            {
                betrag = 25;
            }

            for (int i = 0; i < nud_karten.Value; i++)
            {
                kaeufe.Add(karte.erstelle_Karte(kaufdatum, gueltig_bis, betrag));
            }
            txtb_karten.Text = string.Join(Environment.NewLine, kaeufe);
        }
    }
}