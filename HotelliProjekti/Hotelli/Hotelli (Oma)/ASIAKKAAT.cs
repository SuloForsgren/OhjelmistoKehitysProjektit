using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotelli__Oma_
{
    public partial class ASIAKKAAT : Form
    {
        ASIAKKAIDENHALLINTA_OLIOT asiakas = new ASIAKKAIDENHALLINTA_OLIOT();
        YHDISTA yhteys = new YHDISTA();
        public ASIAKKAAT()
        {
            InitializeComponent();
        }
        // Haetaan asiakkaat heti ikkunan avauduttua
        private void ASIAKKAAT_Load(object sender, EventArgs e)
        {
            TietoboksiDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void IDTB_TextChanged(object sender, EventArgs e)
        {

        }
        // Viedään tiedot niille kuuluville paikoille kun painetaan cellistä
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTB.Text = TietoboksiDG.CurrentRow.Cells[0].Value.ToString();
            ETTB.Text = TietoboksiDG.CurrentRow.Cells[1].Value.ToString();
            SNTB.Text = TietoboksiDG.CurrentRow.Cells[2].Value.ToString();
            PUHTB.Text = TietoboksiDG.CurrentRow.Cells[3].Value.ToString();
            EMAILTB.Text = TietoboksiDG.CurrentRow.Cells[4].Value.ToString();
        }

        //Tyhjennetään kaikki tiedot kentistä
        private void Tyhjenna_Click(object sender, EventArgs e)
        {
            ETTB.Text = "";
            SNTB.Text = "";
            IDTB.Text = "";
            EMAILTB.Text = "";
            PUHTB.Text = "";
            TietoboksiDG.DataSource = asiakas.haeAsiakkaat();
        }

        // Lisäys napin toiminnot eli lisätään asiakas ja hänen tiedot
        private void LisaaBT_Click(object sender, EventArgs e)
        {
            String enimi = ETTB.Text;
            String snimi = SNTB.Text;
            String puhelin = PUHTB.Text;
            String email = EMAILTB.Text;


            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals(""))
            {
                MessageBox.Show("Virhe - vaaditut kentät - etu ja sukunimi, puhelin ja sähköposti", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.lisaaAsiakas(enimi, snimi, puhelin, email);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty lisäämään", "asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietoboksiDG.DataSource = asiakas.haeAsiakkaat();
        }

        //Päivitetään asiakkaan tietoja
        private void PaivitysBT_Click(object sender, EventArgs e)
        {
            String enimi = ETTB.Text;
            String snimi = SNTB.Text;
            String puhelin = PUHTB.Text;
            String email = EMAILTB.Text;
            int oid = Int32.Parse(IDTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE vaaditut kentät ID, Etu ja sukunimi, puhelin sähköposti sekä opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.muokkaaAsiakasta(oid, enimi, snimi, puhelin, email);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Asiakkaan tiedot päivitetty onnistuneesti", "Asiakkaan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Asiakkaan tietoja ei pystytty päivittämään", "Asiakkaan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            TietoboksiDG.DataSource = asiakas.haeAsiakkaat();
        }
        // Poistetaan asiakkaan tiedot
        private void PoistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = IDTB.Text;
            if (asiakas.poistaAsiakas(ktunnus))
            {
                TietoboksiDG.DataSource = asiakas.haeAsiakkaat();
                MessageBox.Show("Asiakas on poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakasta ei pystytty poistamaan", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TietoboksiDG.DataSource = asiakas.haeAsiakkaat();
        }
    }
}
