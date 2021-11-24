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
    public partial class PaisaikkunaFM : Form
    {
        public PaisaikkunaFM()
        {
            InitializeComponent();
        }

        private void asiakkaidenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ASIAKKAAT lomake2 = new ASIAKKAAT();
            lomake2.ShowDialog();
        }
        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VARAUKSET lomake3 = new VARAUKSET();
            lomake3.ShowDialog();
        }

        private void huoneetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HUONEET lomake4 = new HUONEET();
            lomake4.ShowDialog();
        }

        private void PaisaikkunaFM_Load(object sender, EventArgs e)
        {

        }

        private void PaisaikkunaFM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Kirjaudu_ulosBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            KirjautuminenForm kirjaus = new KirjautuminenForm();
            kirjaus.Show();
        }
    }
}
