using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kauppa_Oma_projekti_
{
    class ASIAKAS
    {
        YHDISTA yhteys = new YHDISTA();

        //Lisätään asiakas tietokantaan
        public bool lisaaAsiakas(String etunimi, String sukunimi, String ktunnus, String salasana)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO `kirjautuminen` " + "(`Etunimi`, `Sukunimi`, `Username`, `Password`) " +  "VALUES (@etu, @suk, @usr, @pass); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@etu", MySqlDbType.VarChar).Value = etunimi;
            komento.Parameters.Add("@suk", MySqlDbType.VarChar).Value = sukunimi;
            komento.Parameters.Add("@usr", MySqlDbType.VarChar).Value = ktunnus;
            komento.Parameters.Add("@pass", MySqlDbType.VarChar).Value = salasana;

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


        public DataTable haeAsiakkaat()
        {
            MySqlCommand komero = new MySqlCommand("SELECT `ID`, `Etunimi`, `Sukunimi`, `Username`, `Password` FROM `kirjautuminen`", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komero;
            adapteri.Fill(taulu);

            return taulu;
        }


        public bool poistaAsiakas(String ktunnus)
        {
            
                MySqlCommand komentollo = new MySqlCommand();
                String poistokysely = "DELETE FROM kirjautuminen WHERE ID = @id";
                komentollo.CommandText = poistokysely;
                komentollo.Connection = yhteys.otaYhteys();

                komentollo.Parameters.Add("@id", MySqlDbType.UInt32).Value = ktunnus;

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
