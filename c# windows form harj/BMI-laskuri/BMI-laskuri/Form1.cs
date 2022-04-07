using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //kokeillaan että käyttäjä syöttää numeroita
                double paino = 0, pituus = 0, bmi; //muuttujat desimaaleina mahdollisia
                paino = Convert.ToDouble(painoTB.Text);
                pituus = Convert.ToDouble(pituusTB.Text);
                bmi = Math.Round(paino / (pituus * pituus), 2); //laskukaava, kahdella desimaalilla max

                if(bmi < 18.5)
                {
                    painoindeksiLB.Text = "Painoindeksisi on: " + bmi;
                    painoindeksiLB.ForeColor = Color.DarkBlue; //vastauksen väri muutetaan
                    painoindeksiLB.Visible = true; // vastaus näkyviin
                    painonVariLB.Text = "Alipaino"; //teksti muutettu
                    painonVariLB.ForeColor = Color.DarkBlue; //vastauksen väri muutetaan
                    painonVariLB.Visible = true; // vastaus näkyviin
                }
                else if(bmi < 25)
                {
                    painoindeksiLB.Text = "Painoindeksisi on: " + bmi;
                    painoindeksiLB.ForeColor = Color.LightBlue; //vastauksen väri muutetaan
                    painoindeksiLB.Visible = true; // vastaus näkyviin
                    painonVariLB.Text = "Normaalipaino"; //teksti muutettu
                    painonVariLB.ForeColor = Color.LightBlue; //vastauksen väri muutetaan
                    painonVariLB.Visible = true; // vastaus näkyviin
                }
                else if (bmi < 40)
                {
                    painoindeksiLB.Text = "Painoindeksisi on: " + bmi;
                    painoindeksiLB.ForeColor = Color.OrangeRed; //vastauksen väri muutetaan
                    painoindeksiLB.Visible = true; // vastaus näkyviin
                    painonVariLB.Text = "Ylipaino"; //teksti muutettu
                    painonVariLB.ForeColor = Color.OrangeRed; //vastauksen väri muutetaan
                    painonVariLB.Visible = true; // vastaus näkyviin
                }
                else
                {
                    painoindeksiLB.Text = "Painoindeksisi on: " + bmi;
                    painoindeksiLB.ForeColor = Color.Red; //vastauksen väri muutetaan
                    painoindeksiLB.Visible = true; // vastaus näkyviin
                    painonVariLB.Text = "Huomattava ylipaino"; //teksti muutettu
                    painonVariLB.ForeColor = Color.Red; //vastauksen väri muutetaan
                    painonVariLB.Visible = true; // vastaus näkyviin
                }

            }
            catch (Exception ex)
            {
                painoindeksiLB.Text = ex.Message; //virhe viesti jos käyttäjä syöttää muuta kun numeroita ja desimaali lukuja
                painoindeksiLB.ForeColor = Color.Red; // vastauksen väri muuttuu
                painoindeksiLB.Visible = true; // vastaus näkyviin
                painonVariLB.Text = "Kokeile uudelleen"; // teksti muutetaan
                painonVariLB.ForeColor = Color.Red; // vastausken väri muuttuu
                painonVariLB.Visible = true; // vastaus näkyviin
            }
        }
    }
}
