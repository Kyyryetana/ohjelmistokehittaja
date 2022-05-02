using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD20
{
    public partial class Form1 : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public Form1()
        {
            InitializeComponent();
        }

        private void Tietotaulu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = tietotauluDG.CurrentRow.Cells[0].Value.ToString();
            enimiTB.Text = tietotauluDG.CurrentRow.Cells[1].Value.ToString();
            snimiTB.Text = tietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhelinTB.Text = tietotauluDG.CurrentRow.Cells[3].Value.ToString();
            emailTB.Text = tietotauluDG.CurrentRow.Cells[4].Value.ToString();
            oNroTB.Text = tietotauluDG.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void tyhjennaBTN_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            enimiTB.Text = "";
            snimiTB.Text = "";
            puhelinTB.Text = "";
            emailTB.Text = "";
            oNroTB.Text = "";
        }

        private void tallennaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                String enimi = enimiTB.Text;
                String snimi = snimiTB.Text;
                String puh = puhelinTB.Text;
                String email = emailTB.Text;
                int oNro = Int32.Parse(oNroTB.Text);

                if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
                {
                    MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, Puhelin, Sähköposti ja Opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean lisaaOpiskelija = opiskelija.lisaaOpiskelija(enimi, snimi, puh, email, oNro);
                    if (lisaaOpiskelija)
                    {
                        MessageBox.Show("Uusi opiskelijaa lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void paivitaBTN_Click(object sender, EventArgs e)
        {
            int oid = Int32.Parse(idTB.Text);
            String enimi = enimiTB.Text;
            String snimi = snimiTB.Text;
            String puh = puhelinTB.Text;
            String email = emailTB.Text;
            int oNro = Int32.Parse(oNroTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puh.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - OID, Etu- ja sukunimi, Puhelin, Sähköposti ja Opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaOpiskelija = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puh, email, oNro);
                if (muokkaaOpiskelija)
                {
                    MessageBox.Show("Opiskelija muokattu onnistuneesti", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty muokkaamaan", "Opiskelijan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void poistaBTN_Click(object sender, EventArgs e)
        {
            string ktunnus = idTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBTN.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }
    }
}
