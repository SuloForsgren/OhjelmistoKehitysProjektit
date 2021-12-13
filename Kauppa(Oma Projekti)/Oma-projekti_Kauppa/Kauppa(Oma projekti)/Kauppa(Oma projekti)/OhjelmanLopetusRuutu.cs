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
    public partial class OhjelmanLopetusRuutu : Form
    {
        public OhjelmanLopetusRuutu()
        {
            InitializeComponent();
        }

        int aloitus = 0;



        private void LatausPB_Click(object sender, EventArgs e)
        {

        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            aloitus += 1;
            LatausPB.Value = aloitus;
            if (LatausPB.Value == 100)
            {
                LatausPB.Value = 0;
                AjastinTM.Stop();
                Application.Exit();
            }
        }

        private void OhjelmanLopetusRuutu_Load(object sender, EventArgs e)
        {
            AjastinTM.Start();
        }
    }
}
