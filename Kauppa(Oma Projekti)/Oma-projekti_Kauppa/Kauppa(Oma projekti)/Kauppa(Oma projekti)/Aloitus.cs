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
    public partial class Aloitus : Form
    {
        public Aloitus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDevFM ylläpitäjä = new LoginDevFM();
            ylläpitäjä.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsiakasLogin asiakas = new AsiakasLogin();
            asiakas.Show();
        }
    }
}
