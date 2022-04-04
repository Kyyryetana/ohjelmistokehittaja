using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celcius_to_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muunnaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                double annettu = Int32.Parse(asteetTB.Text);
                vastausLB.Visible = false;
                double vastaus;

                if (celciusRB.Checked)
                {
                    vastaus = annettu * 1.8 + 32;
                    vastausLB.Text = annettu + " Fahrenheitia on " + vastaus + " Celcius astetta";
                    vastausLB.Visible = true;
                    vastausLB.ForeColor = System.Drawing.Color.Black;
                }
                else if (fahrenheitRB.Checked)
                {
                    vastaus = (annettu - 32) / 1.8;
                    vastausLB.Text = annettu + " Celciusta on " + vastaus + " Fahrenheit astetta";
                    vastausLB.Visible = true;
                    vastausLB.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    vastausLB.Text = "Et antanut muunnettavaa astetta!";
                    vastausLB.Visible = true;
                    vastausLB.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                vastausLB.Text = ex.Message;
                vastausLB.Visible = true;
                vastausLB.ForeColor = System.Drawing.Color.Red;
            }

            
        }
    }
}
