using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Hotelli__Oma_
{
    class HUONE
    {
        YHDISTA yhteys = new YHDISTA();

        //Haetaan huonetyypit tietokannasta
        public DataTable huoneTyyppiLista()
        {
            MySqlCommand komero = new MySqlCommand("SELECT * FROM `huonekategoria`", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komero;
            adapteri.Fill(taulu);

            return taulu;
        }
        //Haetaan huoneet tyypin mukaan
        public DataTable huoneTyypinMukaan(int tyyppi)
        {
            MySqlCommand komero = new MySqlCommand("SELECT * FROM `huoneet` WHERE `tyyppi`=@tyy AND vapaa='Kyllä'", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            komero.Parameters.Add("@tyy", MySqlDbType.Int32).Value = tyyppi;

            adapteri.SelectCommand = komero;
            adapteri.Fill(taulu);

            return taulu;
        }
        //Tarkistetaan ja haetaan huoneen tyyppi
        public int haeHuoneenTyyppi(int numero)
        {
            MySqlCommand komero = new MySqlCommand("SELECT `tyyppi` FROM `huoneet` WHERE `numero`=@num", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            komero.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;

            adapteri.SelectCommand = komero;
            adapteri.Fill(taulu);

            return Convert.ToInt32(taulu.Rows[0][0].ToString());
        }

        //Tehdään uusi funktio jonka avulla syötämme UUDET tiedot tietokantaan
        public bool lisaaHuone(int numero, int tyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO `huoneet`(`numero`, `tyyppi`, `puhelin`, `vapaa`) VALUES (@nro,@tp,@puh,@vap); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@nro", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

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
        //Tässä taas haemme kaikki huoneet
        public DataTable haeHuoneet()
        {
            MySqlCommand komero = new MySqlCommand("SELECT * FROM `huoneet`", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komero;
            adapteri.Fill(taulu);

            return taulu;
        }
        //Tehdään funktio jonka avulla muokataan huoneita
        public bool muokkaaHuonetta(int numero, int tyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `huoneet` SET `tyyppi`=@tp,`puhelin`=@puh,`vapaa`=@vap WHERE `numero`=@nro";

            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@nro", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@tp", MySqlDbType.Int32).Value = tyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

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
        // Tehdään tähän kohtaan funktio joka poistaa tietyn huoneen tietokannasta
        public bool poistaHuone(int numero)
        {
            MySqlCommand komentollo = new MySqlCommand();
            String poistokysely = "DELETE FROM `huoneet` WHERE `numero`=@nro";
            komentollo.CommandText = poistokysely;
            komentollo.Connection = yhteys.otaYhteys();

            komentollo.Parameters.Add("@nro", MySqlDbType.UInt32).Value = numero;

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
        //Funktio jolla tarkistetaan onko huone vapaa
        public bool huoneVapaa(int numero, String Kyllä_tai_ei)
        {
            MySqlCommand komero = new MySqlCommand("UPDATE `huoneet` SET `vapaa`=@Kyllä_Ei WHERE `numero`=@num;", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            komero.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;
            komero.Parameters.Add("@Kyllä_Ei", MySqlDbType.VarChar).Value = Kyllä_tai_ei;

            yhteys.avaaYhteys();
            if (komero.ExecuteNonQuery() == 1)
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

        /*public bool huoneVapaa(int numero)
        {
            MySqlCommand komero = new MySqlCommand("UPDATE `huoneet` SET `vapaa`= 'Ei' WHERE `numero`=@num;", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            komero.Parameters.Add("@num", MySqlDbType.Int32).Value = numero;

            yhteys.avaaYhteys();
            if (komero.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }*/
    }
}
