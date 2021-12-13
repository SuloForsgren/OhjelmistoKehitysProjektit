using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kauppa_Oma_projekti_
{
    class OSTOSTENHALLINTA
    {

        //Yhdistetään YHDISTA olio classin kanssa
        YHDISTA yhteys = new YHDISTA();

        //Hakee tuotteet tietokannasta
        public DataTable haeOstokset()
        {
            MySqlCommand komero = new MySqlCommand("SELECT * FROM tuotteet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komero;
            adapteri.Fill(taulu);

            return taulu;
        }

        //Lisää tuotteet tietokantaan 
        public bool lisaaTavara(String tuote, int hinta)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO `tuotteet`(`Tuote`, `Hinta`) VALUES (@tut,@hit);";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@tut", MySqlDbType.VarChar).Value = tuote;
            komento.Parameters.Add("@hit", MySqlDbType.Int32).Value = hinta;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        //Muokkaa tuotteita tietoja tietokannassa
        public bool muokkaaOstosta(String tuote, int hinta, int id)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "update `tuotteet` SET `Tuote` = @tut," + "`Hinta` = @hit" + " WHERE ID = @id";

            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@tut", MySqlDbType.VarChar).Value = tuote;
            komento.Parameters.Add("@hit", MySqlDbType.Int32).Value = hinta;
            komento.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        //Poistaa tuotteen tietokannasta
        public bool poistaTuote(String tuote)
        {
            MySqlCommand komentollo = new MySqlCommand();
            String poistokysely = "DELETE FROM tuotteet WHERE ID = @id";
            komentollo.CommandText = poistokysely;
            komentollo.Connection = yhteys.otaYhteys();

            komentollo.Parameters.Add("@id", MySqlDbType.UInt32).Value = tuote;

            yhteys.avaaYhteys();
            if (komentollo.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
