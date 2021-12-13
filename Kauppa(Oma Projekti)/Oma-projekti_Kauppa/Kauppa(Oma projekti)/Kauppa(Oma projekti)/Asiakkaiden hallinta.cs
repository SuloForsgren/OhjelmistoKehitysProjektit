using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kauppa_Oma_projekti_
{
    public partial class Asiakkaiden_hallinta : Form
    {
        ASIAKAS asiakas = new ASIAKAS();

        public Asiakkaiden_hallinta()
        {
            InitializeComponent();
        }

        private void Tyhjenna_Click(object sender, EventArgs e)
        {
            IDTB.Text = "";
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            KtunnusTB.Text = "";
            SalasanaTB.Text = "";
        }

        //Asiakkaan lisäys jotta pääsee ostamaan
        private void LisaaBT_Click(object sender, EventArgs e)
        {
            try
            {
                string etunimi = EtunimiTB.Text;
                string sukunimi = SukunimiTB.Text;
                string ktunnus = KtunnusTB.Text;
                string salasana = SalasanaTB.Text;

                if (EtunimiTB.Text == "" || SukunimiTB.Text == "" || KtunnusTB.Text == "" || SalasanaTB.Text == "")
                {
                    MessageBox.Show("Kentät ovat tyhjiä", "Asiakkaan lisääminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //--Laitetaan lisäys "loppuun" jotta se ei enää jatku ja lisää tyhjiä tietoja--
                    goto loppu;
                }
                
                if (asiakas.lisaaAsiakas(etunimi, sukunimi, ktunnus, salasana))
                {
                    MessageBox.Show("Asiakas lisätty onnistuneesti!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Asiakkaan lisäys ei onnistunut", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Asiakkaan Lisääminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //--Hyppää tänne kohdasta goto loppu;--
            loppu:
            TietoboksiDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void Asiakkaiden_hallinta_Load(object sender, EventArgs e)
        {
            TietoboksiDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void CloseLB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TietoboksiDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void TietoboksiDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTB.Text = TietoboksiDG.CurrentRow.Cells[0].Value.ToString();
            EtunimiTB.Text = TietoboksiDG.CurrentRow.Cells[1].Value.ToString();
            SukunimiTB.Text = TietoboksiDG.CurrentRow.Cells[2].Value.ToString();
            KtunnusTB.Text = TietoboksiDG.CurrentRow.Cells[3].Value.ToString();
            SalasanaTB.Text = TietoboksiDG.CurrentRow.Cells[4].Value.ToString();
        }
    }
}

