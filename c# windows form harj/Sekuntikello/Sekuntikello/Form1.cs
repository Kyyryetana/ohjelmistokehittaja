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

namespace Sekuntikello
{
    public partial class sekuntikelloForm : Form
    {
        private Stopwatch sekuntikello;
        public sekuntikelloForm()
        {
            InitializeComponent();
        }

        private void kaynnistaBTN_Click(object sender, EventArgs e)
        {
            sekuntikello.Start();
        }

        private void lopetaBTN_Click(object sender, EventArgs e)
        {
            sekuntikello.Stop();
        }

        private void tyhjennaBTN_Click(object sender, EventArgs e)
        {
            sekuntikello.Reset();
        }

        private void sekuntikelloForm_Load(object sender, EventArgs e)
        {
            sekuntikello = new Stopwatch();
        }

        private void ajanottoTM_Tick(object sender, EventArgs e)
        {
            aikaLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekuntikello.Elapsed);
        }
    }
}
