using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vorabi._2018._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            T_AMa außenmitarbeiter = new T_AMa();
            außenmitarbeiter.create("AMa1234", "Max Musterman", 2200.00f, 4.30f);
            txtb_ergebnis.Text = außenmitarbeiter.getInfo();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            T_SMa außenmitarbeiter = new T_SMa();
            außenmitarbeiter.create("SMa9876", "Theo Tester", 2300.00f, 0);
            txtb_ergebnis.Text = außenmitarbeiter.getInfo();
        }
    }
}
