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

namespace Muistio
{
    public partial class muistioForm : Form
    {
        string tiedostopolku = "";
        public muistioForm()
        {
            InitializeComponent();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstiTB.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                tekstiTB.Text = "";
            }
            else
            {
                tekstiTB.Text = "";
            }
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog() {Filter="TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames=true, Multiselect=false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader jonolukija = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> text = jonolukija.ReadToEndAsync();
                        tekstiTB.Rtf = text.Result;
                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tiedostopolku))
            {
                using(SaveFileDialog ttk = new SaveFileDialog() {Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames=true })
                {
                    if(ttk.ShowDialog() == DialogResult.OK)
                    {
                        using(StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                        {
                            jonokirjoittaja.WriteLineAsync(tekstiTB.Rtf);
                        }
                    }
                    else
                    {
                        using(StreamWriter jonokirjoittaja = new StreamWriter(tiedostopolku))
                        {
                            jonokirjoittaja.WriteLineAsync(tekstiTB.Rtf);
                        }
                    }
                }
            }
        }

        private void tallennaNimellaEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog() { Filter = "TextDocument|*.txt|Rich Text Format|*.rtf", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(tekstiTB.Rtf);
                    }
                }
                else
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(tiedostopolku))
                    {
                        jonokirjoittaja.WriteLineAsync(tekstiTB.Rtf);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiTB.Cut();
        }

        private void liitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiTB.SelectAll();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            tekstiTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekstiTB.SelectionBackColor = Color.Yellow;
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivitysToolStripMenuItem.Checked == true)
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                tekstiTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                tekstiTB.WordWrap = true;
            }
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa();
            tietoa.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tekstiTB.Text, tekstiTB.Font, Brushes.Black, 12, 10);
        }

        private void tekstiTB_TextChanged(object sender, EventArgs e)
        {
            if(tekstiTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }
    }
}
