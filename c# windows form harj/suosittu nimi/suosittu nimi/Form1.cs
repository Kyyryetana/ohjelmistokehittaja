using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace suosittu_nimi
{
    public partial class suosittuNimiForm : Form
    {
        public suosittuNimiForm()
        {
            InitializeComponent();
        }

        private void tarkistaBTN_Click(object sender, EventArgs e)
        {
            vastausLB.Text = "";
            vastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:/Users/Oma/source/repos/ohjelmistokehittaja/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Users/Oma/source/repos/ohjelmistokehittaja/tytot.txt");
            string nimi = annettuNimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;

            foreach (string poika in pojat)
            {
                if(nimi == poika)
                {
                    vastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskurip++;
            }

            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    vastausLB.Text = "Nimesi on " + laskurip + ". suosituin tyttöjen nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskurit++;
            }

            if (vastausLB.Visible == false)
            {
                vastausLB.Text = "Nimesi ei löytynyt suositumpien nimien joukosta! :(";
                vastausLB.Visible = true;
            }
        }
    }
}
