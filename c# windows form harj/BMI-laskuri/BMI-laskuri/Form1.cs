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
            try // ei toimi, katso jyrin video https://www.youtube.com/watch?v=PoOuK726Lto
            {
                double paino = 0, pituus = 0;
                paino = Convert.ToDouble(painoTB.Text);
                pituus = Convert.ToDouble(pituusTB.Text);
                double bmi = Math.Round(paino / (pituus * pituus),2);

                if(bmi < 18.5)
                {
                    painoindeksiLB.Text = "Painoindeksisi on: " + bmi;
                    painoindeksiLB.ForeColor = Color.DarkBlue;
                    painoindeksiLB.Visible = true;
                    painonVariLB.Text = "Alipaino";
                    painonVariLB.ForeColor = Color.DarkBlue;
                    painonVariLB.Visible = true;
                }
                else if(bmi < 25)
                {
                    painoindeksiLB.Text = "Painoindeksisi on: " + bmi;
                    painoindeksiLB.ForeColor = Color.LightBlue;
                    painoindeksiLB.Visible = true;
                    painonVariLB.Text = "Normaalipaino";
                    painonVariLB.ForeColor = Color.LightBlue;
                    painonVariLB.Visible = true;
                }
                else if (bmi < 40)
                {
                    painoindeksiLB.Text = "Painoindeksisi on: " + bmi;
                    painoindeksiLB.ForeColor = Color.OrangeRed;
                    painoindeksiLB.Visible = true;
                    painonVariLB.Text = "Ylipaino";
                    painonVariLB.ForeColor = Color.OrangeRed;
                    painonVariLB.Visible = true;
                }
                else
                {
                    painoindeksiLB.Text = "Painoindeksisi on: " + bmi;
                    painoindeksiLB.ForeColor = Color.Red;
                    painoindeksiLB.Visible = true;
                    painonVariLB.Text = "Huomattava ylipaino";
                    painonVariLB.ForeColor = Color.Red;
                    painonVariLB.Visible = true;
                }

            }
            catch (Exception ex)
            {
                painoindeksiLB.Text = ex.Message;
                painoindeksiLB.ForeColor = Color.Red;
                painoindeksiLB.Visible = true;
                painonVariLB.Text = "Kokeile uudelleen";
                painonVariLB.ForeColor = Color.Red;
                painonVariLB.Visible = true;
            }
        }
    }
}
