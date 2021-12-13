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
    public partial class Kauppa : Form
    {
        KAUPAN_OLIOT kauppa = new KAUPAN_OLIOT();
        public Kauppa()
        {
            InitializeComponent();
        }

        private void Kauppa_Load(object sender, EventArgs e)
        {
            TuotteetDG.DataSource = kauppa.haeOstokset();
        }

        private void TuotteetDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TuotteenimiTB.Text = TuotteetDG.CurrentRow.Cells[0].Value.ToString();
        }

        
        private void KoriBT_Click(object sender, EventArgs e)
        {

            KoriLB.Text = "\n" + TuotteenimiTB.Text + KoriLB.Text;
            TuotteenimiTB.Text = "";

        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            KoriLB.Text = "";
        }

        private void MaksaBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            TilausVahvistus lomake = new TilausVahvistus();
            lomake.Show();
        }

        private void CloseLB_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsiakasLogin lomake = new AsiakasLogin();
            lomake.Show();
        }
    }
}
