using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eramake;
using MySql.Data.MySqlClient;

namespace EncryptDecrypt
{
    public partial class salasanaForm : Form
    {
        YHDISTA yhteys = new YHDISTA();
        public salasanaForm()
        {
            InitializeComponent();
        }

        private void cryptaaBTN_Click(object sender, EventArgs e)
        {
            string salattu = eCryptography.Encrypt(salasanaTB.Text);
            MySqlCommand komento = new MySqlCommand();
            string lisayskysely = "INSERT INTO salasana(salasana) VALUES (@ssa); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu;
            yhteys.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                MessageBox.Show("Salasana cryptattu ja viety tietokantaan");
                salasanaTB.Text = "";
                cryptattuTB.Text = "";
                vastausLB.Text = "";
                vastausLB.Visible = false;
            }
            else
            {
                yhteys.suljeYhteys();
                MessageBox.Show("Yhteys ei onnistu");
                cryptattuTB.Text = "";
                vastausLB.Text = "";
                vastausLB.Visible = false;
            }
        }

        private void salasanaBTN_Click(object sender, EventArgs e)
        {
            string salasana = eCryptography.Decrypt(cryptattuTB.Text);
            vastausLB.Text = salasana;
            vastausLB.Visible = true;
        }

        private void tyhjaaBTN_Click(object sender, EventArgs e)
        {
            salasanaTB.Text = "";
            cryptattuTB.Text = "";
            vastausLB.Text = "";
            vastausLB.Visible = false;
        }
    }
}
