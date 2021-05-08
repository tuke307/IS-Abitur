using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020N
{
    public partial class Form1 : Form
    {
        private T_TestPC pc = new T_TestPC();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_test_pc_instanzieren_Click(object sender, EventArgs e)
        {
            pc.create("Test_PC");
        }

        private void btn_fehler_melden_Click(object sender, EventArgs e)
        {
            pc.fehler_anmelden(txtb_fehlermeldung.Text);

            refresh_fehlerliste();
        }

        private void btn_fehler_beseitigt_Click(object sender, EventArgs e)
        {
            pc.fehler_beseitigt(Convert.ToInt32(txtb_listenindex.Text));

            refresh_fehlerliste();
        }

        private void refresh_fehlerliste()
        {
            txtb_fehlerliste.Text = pc.getFehlermeldung();
        }
    }
}