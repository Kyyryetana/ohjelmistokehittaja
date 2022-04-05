using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ajastin
{
    public partial class ajastinForm : Form
    {
        //lisää tehtäviin kommentit

        private int kokonaisaika;
        public ajastinForm()
        {
            InitializeComponent();
        }

        private void ajastinForm_Load(object sender, EventArgs e)
        {
            stopBTN.Enabled = false;
            for(int i = 0; i < 60; i++)
            {
                minuutitCB.Items.Add(i.ToString());
                sekunnitCB.Items.Add(i.ToString());
            }
            minuutitCB.SelectedIndex = 0;
            sekunnitCB.SelectedIndex = 0;
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            startBTN.Enabled = false;
            stopBTN.Enabled = true;
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTMR.Enabled = true;
        }

        private void stopBTN_Click(object sender, EventArgs e)
        {
            startBTN.Enabled = true;
            stopBTN.Enabled = false;
            kokonaisaika = 0;
            ajastinTMR.Enabled = false;
            aikaLB.Text = "00:00";
        }

        private void ajastinTMR_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit + ":" + sekunnit;
            }
            else
            {
                ajastinTMR.Stop();
                MessageBox.Show("Aika loppui!");
            }
        }
    }
}
