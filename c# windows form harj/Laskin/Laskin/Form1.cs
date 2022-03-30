using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            int eka, toka;
            try
            {
                eka = Int32.Parse(LukuYksiTB.Text);
                toka = Int32.Parse(LukuKaksiTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Yritä uudelleen käyttämällä numeroita");
                return;
            }

            float luku1, luku2, vastaus;
            string merkki;
            luku1 = float.Parse(LukuYksiTB.Text);
            luku2 = float.Parse(LukuKaksiTB.Text);
            merkki = LaskutoimitusCB.Text;

            switch (merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    MessageBox.Show("Valitse laskutoimituksen tyyli");
                    return;
            }

            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true; 
        }
    }
}
