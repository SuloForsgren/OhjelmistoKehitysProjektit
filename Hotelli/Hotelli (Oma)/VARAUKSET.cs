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
    
    public partial class VARAUKSET : Form
    {
        //Yhdistetään YHDISTA classin kanssa
        YHDISTA yhdista = new YHDISTA();
        HUONE huone = new HUONE();
        VARAUS varaus = new VARAUS();

        public VARAUKSET()
        {
            InitializeComponent();
        }

        private void VARAUKSET_Load(object sender, EventArgs e)
        {
            HuonetyyppiCB.DataSource = huone.huoneTyyppiLista();
            HuonetyyppiCB.DisplayMember = "Nimi";
            HuonetyyppiCB.ValueMember = "kategoriaid";

            int tyyppi = Convert.ToInt32(HuonetyyppiCB.SelectedValue.ToString());
            HuoneennumeroCB.DataSource = huone.huoneTyypinMukaan(tyyppi);
            HuoneennumeroCB.DisplayMember = "numero";
            HuoneennumeroCB.ValueMember = "numero";

            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void TyhjennaKentatBT_Click(object sender, EventArgs e)
        {
            VarausTB.Text = "";
            AsiakasTB.Text = "";
            HuonetyyppiCB.SelectedIndex = 0;
            SisaanDTP.Value = DateTime.Now;
            UlosDTP.Value = DateTime.Now;
        }

        private void HuonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int tyyppi = Convert.ToInt32(HuonetyyppiCB.SelectedValue.ToString());
                HuoneennumeroCB.DataSource = huone.huoneTyypinMukaan(tyyppi);
                HuoneennumeroCB.DisplayMember = "numero";
                HuoneennumeroCB.ValueMember = "numero";
            }
            catch(Exception)
            {

            }
        }

        //Lisää napin toiminta
        private void LisaaVarausBT_Click(object sender, EventArgs e)
        {
            try
            {
                int asiakasid = Convert.ToInt32(AsiakasTB.Text);
                int numero = Convert.ToInt32(HuoneennumeroCB.SelectedValue);
                DateTime sisaan = SisaanDTP.Value;
                DateTime ulos = UlosDTP.Value;

                if (sisaan < DateTime.Now)
                {
                    MessageBox.Show("Sinun on annettava sisäänmeno aika tänään tai myöhempinä päivinä", "Sisällemeno varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sisaan > ulos)
                {
                    MessageBox.Show("Sinun on annettava sisäänmeno ennen ulosmenon päivää", "Sisäänmeno virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


                if (ulos < DateTime.Now)
                {
                    MessageBox.Show("Sinun on annettava ulosmeno aika tänään tai myöhempinä päivinä", "Ulosmeno varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (ulos < sisaan)
                {
                    MessageBox.Show("Sinun on annettava ulosmeno sisäänmenon jälkeisille päiville", "Ulosmeno virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


                if (varaus.lisaaVaraus(numero, asiakasid, sisaan, ulos))
                {
                    huone.huoneVapaa(numero, "Ei");
                    VarauksetDG.DataSource = varaus.haeVaraukset();
                    MessageBox.Show("Varauksen lisäys onnistui", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Varauksen lisäys epäonnistui", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ongelma asiakkaan lisäämisessä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        //muokkaa napin toiminta
        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            try
            {
                int varausID = Convert.ToInt32(VarausTB.Text);
                int asiakasid = Convert.ToInt32(AsiakasTB.Text);
                int numero = Convert.ToInt32(HuoneennumeroCB.SelectedValue);
                DateTime sisaan = SisaanDTP.Value;
                DateTime ulos = UlosDTP.Value;

                if (sisaan < DateTime.Now)
                {
                    MessageBox.Show("Sinun on annettava sisäänmeno aika tänään tai myöhempinä päivinä", "Sisällemeno varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sisaan > ulos)
                {
                    MessageBox.Show("Sinun on annettava sisäänmeno ennen ulosmenon päivää", "Sisäänmeno virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


                if (ulos < DateTime.Now)
                {
                    MessageBox.Show("Sinun on annettava ulosmeno aika tänään tai myöhempinä päivinä", "Ulosmeno varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (ulos < sisaan)
                {
                    MessageBox.Show("Sinun on annettava ulosmeno sisäänmenon jälkeisille päiville", "Ulosmeno virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


                if (varaus.muokkaaVarausta(varausID, numero, asiakasid, sisaan, ulos))
                {
                    huone.huoneVapaa(numero,"Ei");
                    MessageBox.Show("Varauksen muuttaminen onnistui", "Varauksen muutos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Varauksen muuttaminen epäonnistui", "Varauksen muutos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ongelma varauksen muuttamisessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }
        
        //poiso napin toiminta
        private void PoistaVarausBT_Click(object sender, EventArgs e)
        {
            try
            {
                int varausID = Convert.ToInt32(VarausTB.Text);
                int huonenumero = Convert.ToInt32(VarauksetDG.CurrentRow.Cells[1].Value.ToString());
                if (varaus.poistaVaraus(varausID))
                {
                    VarauksetDG.DataSource = varaus.haeVaraukset();
                    huone.huoneVapaa(huonenumero, "Kyllä");
                    
                    MessageBox.Show("Varaus poistettu", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ongelma poistamisessa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void VarauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VarausTB.Text = VarauksetDG.CurrentRow.Cells[0].Value.ToString();
            AsiakasTB.Text = VarauksetDG.CurrentRow.Cells[2].Value.ToString();
            int varausID = Convert.ToInt32(VarauksetDG.CurrentRow.Cells[1].Value.ToString());

            HuonetyyppiCB.SelectedValue = huone.haeHuoneenTyyppi(varausID);

            HuoneennumeroCB.SelectedValue = varausID;
        }

        private void VarauksetDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
