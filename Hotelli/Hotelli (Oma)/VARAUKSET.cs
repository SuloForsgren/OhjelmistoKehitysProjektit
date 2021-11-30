using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Hotelli__Oma_
{
    
    public partial class VARAUKSET : Form
    {
        //Yhdistetään YHDISTA classin kanssa
        YHDISTA yhdista = new YHDISTA();
        public VARAUKSET()
        {
            InitializeComponent();
        }

        private void VARAUKSET_Load(object sender, EventArgs e)
        {

        }
    }
}
