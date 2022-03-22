using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kustannus_laskuri
{
    public partial class LaskuriForm : Form
    {
        public LaskuriForm()
        {
            InitializeComponent();
        }

        private void KilometritYhtCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;
            laina = Convert.ToDouble(LainanLyhennysTB.Text);
            nesteet = Convert.ToDouble(LisattavatNesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutusmaksutTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutKulutTB.Text);
            kilometrit = Convert.ToDouble(KilometritYhtCB.Text);
            energia = Convert.ToDouble(PolttonesteTB.Text);
            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + muut + energia) / (kilometrit / 12);
            VastausLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
            VastausLB.Visible = true;
        }
    }
}
