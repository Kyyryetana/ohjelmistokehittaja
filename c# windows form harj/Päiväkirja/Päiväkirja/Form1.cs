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

namespace Päiväkirja
{
    public partial class diaryForm : Form
    {
        public diaryForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:/Users/Oma/source/repos/ohjelmistokehittaja/c# windows form harj/Päiväkirja/Päiväkirja/demo.txt");
            syottoTB.Text = teksti;
        }

        private void tallennaBTN_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += syottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:/Users/Oma/source/repos/ohjelmistokehittaja/c# windows form harj/Päiväkirja/Päiväkirja/demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
