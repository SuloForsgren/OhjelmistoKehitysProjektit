using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

//SSL Mode = None --> use if needed

namespace Kauppa_Oma_projekti_
{
    class YHDISTA
    {
        //Lisätty yhteyden loppuun tuo zero datatime=True korjasi ongelman varaus lomakkeessa
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=kauppa;");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }
        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}