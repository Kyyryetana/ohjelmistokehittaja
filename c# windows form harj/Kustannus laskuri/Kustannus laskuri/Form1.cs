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
            try
            {
                if (LainanLyhennysTB.Text == "" || LisattavatNesteetTB.Text == "" || VakuutusmaksutTB.Text == "" || PesutTB.Text == "" || 
                    HuollotTB.Text == "" || RenkaatTB.Text == "" || MuutKulutTB.Text == "" || PolttonesteTB.Text == "") //tarkistamme että jokaisessa kohdassa on jotakin
                {
                    MessageBox.Show("Täytä kaikki kohdat!"); //jos joku kohta on tyhjä niin tämä viesti tulee
                }
                else 
                {
                    double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset; //muuttujat
                    laina = Convert.ToDouble(LainanLyhennysTB.Text); //desimaaleiksi
                    nesteet = Convert.ToDouble(LisattavatNesteetTB.Text);
                    vakuutus = Convert.ToDouble(VakuutusmaksutTB.Text);
                    pesut = Convert.ToDouble(PesutTB.Text);
                    huollot = Convert.ToDouble(HuollotTB.Text);
                    renkaat = Convert.ToDouble(RenkaatTB.Text);
                    muut = Convert.ToDouble(MuutKulutTB.Text);
                    kilometrit = Convert.ToDouble(KilometritYhtCB.Text);
                    energia = Convert.ToDouble(PolttonesteTB.Text);
                    kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + muut + energia) / (kilometrit / 12); //laskutoimitus
                    VastausLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset; //laskun vastaus ja muutamme tekstiä näkyväksi
                    VastausLB.Visible = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // jos olet syöttänyt muuta kuin numeroita
                VastausLB.Text = "Käytä numeroita!";
                VastausLB.Visible = true; // vastaus teksti muuttuu
            }
            
        }
    }
}
