using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kauppa_Oma_projekti_
{
    class KAUPAN_OLIOT
    {
        YHDISTA yhteys = new YHDISTA();

        //Haetaan tuotteet tietokannasta kuten ylläpitäjän versiossakin
        public DataTable haeOstokset()
        {
            MySqlCommand komero = new MySqlCommand("SELECT `Tuote` FROM tuotteet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komero;
            adapteri.Fill(taulu);

            return taulu;
        }

    }
}
