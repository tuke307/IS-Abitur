using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019
{
    public partial class Form1 : Form
    {
        private TGast person = new TGast();
        private TDatenspeicher datenspeicher = new TDatenspeicher();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_instanzieren_Click(object sender, EventArgs e)
        {
            person.neu("Muster", "Max", "Stübelallee 12", "01307", "Dresden");
            txtb_instanzieren.Text = person.getVorname() + " " + person.getName() + ", " + person.getStrasse() + ", " + person.getPLZ() + " " + person.getOrt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datenspeicher.gastEintragen(person);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datenspeicher.ortEintragen(txtb_plz.Text, txtb_ort.Text);
        }
    }
}