using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iän_laskeminen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = synttariDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosissaLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            KuukausissaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            TunneissaLB.Text = (erotus * 24 + " tuntia");
            PaivissaLB.Text = (erotus + " päivää");
            MinuuteissaLB.Text = (erotus * 24 * 60 + " minuuttia");
            SekunneissaLB.Text = (erotus * 24 * 3600 + " sekuntia");
            VuosissaLB.Visible = true;
            KuukausissaLB.Visible = true;
            TunneissaLB.Visible = true;
            PaivissaLB.Visible = true;
            MinuuteissaLB.Visible = true;
            SekunneissaLB.Visible = true;
        }
    }
}
