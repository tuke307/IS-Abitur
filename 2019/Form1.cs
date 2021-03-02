using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVORABI
{
  

    public partial class Form1 : Form
    {
        private Ziffer ziffer = new Ziffer();
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtb_wert_TextChanged(object sender, EventArgs e)
        {
            SetData();
        }

        private void btn_anzeigen_Click(object sender, EventArgs e)
        {
            pb_a.BackColor = ziffer.getSegment('a').BoolToColor();
            pb_b.BackColor = ziffer.getSegment('b').BoolToColor(); 
            pb_c.BackColor = ziffer.getSegment('c').BoolToColor(); 
            pb_d.BackColor = ziffer.getSegment('d').BoolToColor();
            pb_e.BackColor = ziffer.getSegment('e').BoolToColor();
            pb_f.BackColor = ziffer.getSegment('f').BoolToColor();
            pb_g.BackColor = ziffer.getSegment('g').BoolToColor();
        }

        private void btn_wuerfeln_1_Click(object sender, EventArgs e)
        {
            txtb_wert.Text = random.Next(1, 6).ToString();
            btn_anzeigen.PerformClick();
        }

        private void btn_wuerfeln_2_Click(object sender, EventArgs e)
        {
            txtb_wert.Text = random.Next(100, 999).ToString();
            btn_anzeigen.PerformClick();
        }

        private void nud_stellenindex_ValueChanged(object sender, EventArgs e)
        {
            SetData();
        }

        private void SetData()
        {
            if (string.IsNullOrEmpty(txtb_wert.Text))
            {
                return;
            }

            ziffer.setWert(Convert.ToInt32(nud_stellenindex.Value), Convert.ToInt32(txtb_wert.Text));
        }
    }
}
