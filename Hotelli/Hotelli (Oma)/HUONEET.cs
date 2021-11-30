using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelli__Oma_
{
    public partial class HUONEET : Form
    {
        //Yhdistetään HUONE classin kanssa
        HUONE huone = new HUONE();
        public HUONEET()
        {
            InitializeComponent();
        }
        //Mitä tapahtuu kun sivu aukeaa
        private void HUONEET_Load(object sender, EventArgs e)
        {
            HuonetyyppiCB.DataSource = huone.huoneTyyppiLista();
            HuonetyyppiCB.DisplayMember = "Nimi";
            HuonetyyppiCB.ValueMember = "kategoriaid";

            HuoneetDG.DataSource = huone.haeHuoneet();
        }
        //Lisätään huoneet nappi
        private void LisaaHuoneBT_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(HuonenumeroTB.Text);
            int tyyppi = Convert.ToInt32(HuonetyyppiCB.SelectedValue.ToString());
            string puhelin = PUHTB.Text;
            
            if (huone.lisaaHuone(numero, tyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti!", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huoneen lisäys ei onnistunut", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneetDG.DataSource = huone.haeHuoneet();
        }
        //Tyhjennetään kaikki kentät nappulan toiminta
        private void TyhjennaKentatBT_Click(object sender, EventArgs e)
        {
            HuonetyyppiCB.SelectedIndex = 0;
            HuonenumeroTB.Text = "";
            PUHTB.Text = "";
            HuonetyyppinumeroTB.Text = "";
            
        }
        //Muokkaa napin toiminta
        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            
            int tyyppi = Convert.ToInt32(HuonetyyppiCB.SelectedValue.ToString());
            String puhelin = PUHTB.Text;
            String vapaa = "";

            try
            {
                int numero = Convert.ToInt32(HuonenumeroTB.Text);

                if (KylläRBT.Checked)
                {
                    vapaa = "Kyllä";
                }
                else if (EiRBT.Checked)
                {
                    vapaa = "Ei";
                }

                if (huone.muokkaaHuonetta(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huoneen muokkaus onnistui!", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneen muokkaus ei onnistunut!", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Huone numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneetDG.DataSource = huone.haeHuoneet();
        }
        //Poista napin toiminta
        private void PoistaHuoneBT_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(HuonenumeroTB.Text);

            if (huone.poistaHuone(numero))
            {
                MessageBox.Show("Huoneen poistaminen onnistui!", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huoneen posto ei onnistunut!", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneetDG.DataSource = huone.haeHuoneet();
        }
        //Data tauluun automaattinen kenttien täyttäminen painettaessa celliä
        private void HuoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuonenumeroTB.Text = HuoneetDG.CurrentRow.Cells[0].Value.ToString();
            HuonetyyppiCB.SelectedValue = HuoneetDG.CurrentRow.Cells[1].Value.ToString();
            HuonetyyppinumeroTB.Text = HuoneetDG.CurrentRow.Cells[1].Value.ToString();
            PUHTB.Text = HuoneetDG.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
