using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_kysymystä
{
    public partial class kysymyksetForm : Form
    {
        string[] vastaukset = new string[11];
        string[] oikeatVastaukset = new string[] {"","B", "D", "A", "A", "C", "A", "B", "A", "C", "D"};
        int laskuri = 0;
        int oikein = 0;

        public kysymyksetForm()
        {
            InitializeComponent();
            vastausARB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastausBRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastausCRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastausDRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void kysymyksetForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri <= 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                kysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen:";
                laskuri++;
            }
            else
            {
                vastausLB.Text = "";
                vastausARB.Enabled = false;
                vastausBRB.Enabled = false;
                vastausCRB.Enabled = false;
                vastausDRB.Enabled = false;

                for(int j = 1; j <= 10; j++)
                {
                    if (vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                vastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                vastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }

        private void TyhjaaVastaus()
        {
            if(vastausARB.Checked == true)
            {
                vastausARB.Checked = false;
                laskuri--;
            }
            if (vastausBRB.Checked == true)
            {
                vastausBRB.Checked = false;
                laskuri--;
            }
            if (vastausCRB.Checked == true)
            {
                vastausCRB.Checked = false;
                laskuri--;
            }
            if (vastausDRB.Checked == true)
            {
                vastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}
