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
    public partial class KirjautuminenForm : Form
    {
        public KirjautuminenForm()
        {
            InitializeComponent();
        }

        private void KirjautumisBT_Click(object sender, EventArgs e)
        {
            YHDISTA tietokantaan = new YHDISTA();
            DataTable taulu = new DataTable();
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter adapteriloinen = new MySqlDataAdapter();
            String query = "SELECT käyttäjänimi, salasana FROM asiakkaat WHERE käyttäjänimi = @knm AND Salasana = @ssa";
            command.CommandText = query;
            command.Connection = tietokantaan.otaYhteys();

            command.Parameters.Add("@knm", MySqlDbType.VarChar).Value = KtunnusTB.Text;
            command.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = SalasanaTB.Text;

            adapteriloinen.SelectCommand = command;
            adapteriloinen.Fill(taulu);

            if (taulu.Rows.Count > 0)
            {
                this.Hide();
                PaisaikkunaFM lomake = new PaisaikkunaFM();
                lomake.Show();
            }
            else
            {
                if (KtunnusTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Anna käyttäjänimi", "Käyttäjänimi tyhjä tai väärin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (KtunnusTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Anna salasana", "Salasana kenttä tyhjä tai väärin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Anna käyttäjänimi ja salasana", "Käyttäjänimi ja salasana kenttä tyhjä tai väärin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void KirjautuminenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
