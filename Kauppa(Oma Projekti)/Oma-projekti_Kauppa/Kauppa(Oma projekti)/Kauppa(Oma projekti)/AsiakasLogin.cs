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

namespace Kauppa_Oma_projekti_
{
    public partial class AsiakasLogin : Form
    {
        public AsiakasLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDevFM ylläpito = new LoginDevFM();
            ylläpito.Show();
        }

        private void CloseLB_Click(object sender, EventArgs e)
        {
            DialogResult painettunappi = MessageBox.Show("Oletko varma että haluat sulkea ohjelman?", "Ohjelman sulkeminen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (painettunappi == DialogResult.OK)
            {
                this.Hide();
                OhjelmanLopetusRuutu loppu = new OhjelmanLopetusRuutu();
                loppu.Show();
            }
            else if (painettunappi == DialogResult.Cancel)
            {
                //Ei tehdä mitään muuta kuin suljetaan messagebox näkymä
            }
        }

        private void CloseLB_MouseHover(object sender, EventArgs e)
        {
            CloseLB.BackColor = Color.Green;
        }

        private void CloseLB_MouseLeave(object sender, EventArgs e)
        {
            CloseLB.BackColor = Color.Orange;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tämä hakee tietokannan taulusta asujat käyttäjänimeksi etunimen ja salasanaksi sukunimen
            YHDISTA tietokantaan = new YHDISTA();
            DataTable taulu = new DataTable();
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter adapteriloinen = new MySqlDataAdapter();
            String query = "SELECT `Käyttäjätunnus`, `Salasana` FROM `kirjautuminen asiakas` WHERE Käyttäjätunnus = @ktu AND Salasana = @sl;";

            command.CommandText = query;
            command.Connection = tietokantaan.otaYhteys();

            command.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = KtunnusTB.Text;
            command.Parameters.Add("@sl", MySqlDbType.VarChar).Value = SalasanaTB.Text;

            adapteriloinen.SelectCommand = command;
            adapteriloinen.Fill(taulu);

            //Piilotetaan kirjautumis ikkuna ja avataan pääikkuna
            if (taulu.Rows.Count > 0)
            {
                this.Hide();
                Kauppa lomake = new Kauppa();
                lomake.Show();
            }
            else
            {
                //Tarkistetaan että kaikissa kentissä on jotakin
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
                    MessageBox.Show("Olet antanut molemmat väärin taikka molemmat ovat tyhjiä", "Kirjautumis virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
