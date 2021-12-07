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
    class VARAUS
    {
        YHDISTA yhteys = new YHDISTA();
        public DataTable haeVaraukset()
        {
            MySqlCommand komero = new MySqlCommand("SELECT * FROM `varaukset`", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komero;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool lisaaVaraus(int numero, int asiakasid, DateTime sisaan, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO `varaukset`(`huonenumero`, `asiakasID`, `pvmsisaan`, `pvmulos`) VALUES (@hnr,@aid,@pvs,@pvu); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hnr", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@aid", MySqlDbType.Int32).Value = asiakasid;
            komento.Parameters.Add("@pvs", MySqlDbType.DateTime).Value = sisaan;
            komento.Parameters.Add("@pvu", MySqlDbType.DateTime).Value = ulos;

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
        //`huonenumero`=@hnr,
        public bool muokkaaVarausta(int varausID, int numero, int asiakasid, DateTime sisaan, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `varaukset` SET `asiakasID`=@aid,`pvmsisaan`=@pvs,`pvmulos`=@pvu WHERE `varausID`=@vri";

            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@vri", MySqlDbType.Int32).Value = varausID;
            //komento.Parameters.Add("@hnr", MySqlDbType.Int32).Value = numero;
            komento.Parameters.Add("@aid", MySqlDbType.Int32).Value = asiakasid;
            komento.Parameters.Add("@pvs", MySqlDbType.DateTime).Value = sisaan;
            komento.Parameters.Add("@pvu", MySqlDbType.DateTime).Value = ulos;

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

        public bool poistaVaraus(int varaus_id)
        {
            MySqlCommand komentollo = new MySqlCommand();
            String poistokysely = "DELETE FROM `varaukset` WHERE `varausID`= @vri";
            komentollo.CommandText = poistokysely;
            komentollo.Connection = yhteys.otaYhteys();

            komentollo.Parameters.Add("@vri", MySqlDbType.UInt32).Value = varaus_id;

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
