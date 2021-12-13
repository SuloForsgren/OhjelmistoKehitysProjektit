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
    public partial class LoginDevFM : Form
    {

        YHDISTA yhteys = new YHDISTA();
        public LoginDevFM()
        {
            InitializeComponent();
        }

        //Määritetään muuttujia ja niiden arvoja jotta voimme myöhemmin liikuttaa lomaketta
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        //Tässä kerromme että otamme lomakkeesta kiinni
        private void LoginFM_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        //Tässä kerromme että kun liikutamme hiirtä kun pidämme lomakkeesta kiinni niin lomake liikkuu hiiren mukana siihen asti kunnes päästämme irti lomakkeesta
        private void LoginFM_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        //Tässä kerrotaan että kun lasketaan irti lomakkeesta niin lomake ei seuraa enää hiirtä vaan jää paikalleen siihen kohti missä laskimme irti lomakkeesta
        private void LoginFM_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        //Tässä tehdään varmistus siitä että haluaako käyttäjä sulkea varmasti ohjelman ja suljetaan jos painaa 'ok' ja ei suljeta jos painaa 'peruuta'
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
            CloseLB.BackColor = Color.SteelBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tämä hakee tietokannan taulusta asujat käyttäjänimeksi etunimen ja salasanaksi sukunimen
            YHDISTA tietokantaan = new YHDISTA();
            DataTable taulu = new DataTable();
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter adapteriloinen = new MySqlDataAdapter();
            String query = "SELECT `Username`, `Password` FROM `kirjautuminen` WHERE Username = @kn AND Password = @sl;";

            command.CommandText = query;
            command.Connection = tietokantaan.otaYhteys();

            command.Parameters.Add("@kn", MySqlDbType.VarChar).Value = KtunnusTB.Text;
            command.Parameters.Add("@sl", MySqlDbType.VarChar).Value = SalasanaTB.Text;

            adapteriloinen.SelectCommand = command;
            adapteriloinen.Fill(taulu);

            //Piilotetaan kirjautumis ikkuna ja avataan pääikkuna
            if (taulu.Rows.Count > 0)
            {
                this.Hide();
                Ylläpitosivu lomake = new Ylläpitosivu();
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
        
        private void VARAUKSET_Load(object sender, EventArgs e)
        {

        }

        private void LoginFM_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsiakasLogin asiakas = new AsiakasLogin();
            asiakas.Show();
        }
    }
}
 