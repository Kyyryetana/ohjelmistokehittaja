using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nopan_heitto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void heitaBTN_Click(object sender, EventArgs e)
        {
            //koodia voisi hieman tarkistaa, koska se arpoo hyvin usein samat nopat

            piirraNoppa(noppa01PB); //kutsutaan piirraNoppa funktiota 2x
            piirraNoppa(noppa02PB);
        }

        private void piirraNoppa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random(); //arpoo satunnaisen
            int noppa = satunnainen.Next(1, 7); //noppa muuttuja joka arpoo satunnaisen välillä 1-6 switch casella
            switch (noppa)
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.noppa1;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.noppa2;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.noppa3;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.noppa4;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.noppa5;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.noppa6;
                    break;
            }
        }
    }
}
