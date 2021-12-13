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
    public partial class OstosSivu : Form
    {
        //Yhdistetään olio classin kanssa
        OSTOSTENHALLINTA ostokset = new OSTOSTENHALLINTA();

        public OstosSivu()
        {
            InitializeComponent();
        }

        //Sulkee ikkunan kun painetaan X labelia
        private void CloseLB_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Ladataan tiedot tuotteista kun formi latautuu
        private void OstosSivu_Load(object sender, EventArgs e)
        {
            TuotteetDG.DataSource = ostokset.haeOstokset();
        }

        //Tyhjentää kaikki kentät
        private void TyhjennysBT_Click(object sender, EventArgs e)
        {
            IDTB.Text = "";
            NimiTB.Text = "";
            HintaTB.Text = "";
        }

        
        //Lisää tuotteen tietokantaan ja näyttää sen datagridissä
        private void LisaaBT_Click(object sender, EventArgs e)
        {
            try { 
                    String tuote = NimiTB.Text;
                    int hinta = Convert.ToInt32(HintaTB.Text);


                    if (ostokset.lisaaTavara(tuote, hinta))
                    {
                        MessageBox.Show("Tuote lisätty onnistuneesti!", "Tuotteen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tuotteen lisäys ei onnistunut", "Tuotteen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ongelma tuotteen lisäämisessä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TuotteetDG.DataSource = ostokset.haeOstokset();
        }

        //Päivittää tietokannassa olevaa tuotetta
        private void PäivitäBT_Click(object sender, EventArgs e)
        {
            try
            {
                String tuote = NimiTB.Text;
                int hinta = Convert.ToInt32(HintaTB.Text);
                int id = Int32.Parse(IDTB.Text);

                if (ostokset.muokkaaOstosta(tuote, hinta, id))
                {
                    MessageBox.Show("Tuotteen muokkaus onnistui!", "Tuotteen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tuotteen muokkaus ei onnistunut!", "Tuotteen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ongelma tuotteen muokkaamisessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            TuotteetDG.DataSource = ostokset.haeOstokset();
        }

        //Poistaa tuotteen tietokannasta
        private void PoistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                string tuote = IDTB.Text;
                if (ostokset.poistaTuote(tuote))
                {
                    TuotteetDG.DataSource = ostokset.haeOstokset();
                    MessageBox.Show("Tuote on poistettu onnistuneesti", "Tuotteen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tuotetta ei pystytty poistamaan", "Tuotteen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tuotteen poisto",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TuotteetDG.DataSource = ostokset.haeOstokset();
        }

        //Voit lisätä kenttiin tiedot painamalla cellistä
        private void TuotteetDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTB.Text = TuotteetDG.CurrentRow.Cells[0].Value.ToString();
            NimiTB.Text = TuotteetDG.CurrentRow.Cells[1].Value.ToString();
            HintaTB.Text = TuotteetDG.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

