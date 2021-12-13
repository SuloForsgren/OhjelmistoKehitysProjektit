using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Kauppa_Oma_projekti_
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        int aloitus = 0;




        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            aloitus += 1;
            LatausPB.Value = aloitus;
            if (LatausPB.Value == 100)
            {
                LatausPB.Value = 0;
                AjastinTM.Stop();
                Aloitus alku = new Aloitus();
                this.Hide();
                alku.Show();
            }
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            AjastinTM.Start();
        }

            private void LatausPB_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
