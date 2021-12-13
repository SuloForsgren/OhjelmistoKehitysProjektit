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
    public partial class Ylläpitosivu : Form
    {
        public Ylläpitosivu()
        {
            InitializeComponent();
        }

        private void hallitseOstoksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OstosSivu lomake = new OstosSivu();
            lomake.Show();
        }

        private void CloseLB_Click(object sender, EventArgs e)
        {
            DialogResult painettunappi = MessageBox.Show("Oletko varma että haluat sulkea ohjelman?", "Ohjelman sulkeminen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (painettunappi == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (painettunappi == DialogResult.Cancel)
            {
                //Ei tehdä mitään muuta kuin suljetaan messagebox näkymä
            }
        }

        private void CloseLB_MouseHover(object sender, EventArgs e)
        {  
        }

        private void CloseLB_MouseLeave(object sender, EventArgs e)
        { 
        }

        private void hallitseAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asiakkaiden_hallinta lomake = new Asiakkaiden_hallinta();
            lomake.Show();
        }

        private void kirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDevFM lomake = new LoginDevFM();
            lomake.Show();
        }
    }
}
