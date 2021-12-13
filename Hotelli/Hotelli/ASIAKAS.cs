using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelli
{
    class ASIAKAS
    {
        YHDISTA yhteys = new YHDISTA();
      
        public DataTable asiakaslista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT asiakasid, Concat(Etunimi, ' ',Sukunimi) AS Nimi FROM asiakkaat", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
        public bool lisaaAsiakas(String enimi, String snimi, String osoite, String pnro, String ppaikka, String asiid)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO asiakkaat " +
                "(asiakasid, Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka) " +
                "VALUES (@asid, @enm, @snm, @oso, @pno, @ptp); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@asid", MySqlDbType.VarChar).Value = asiid;
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;

           

            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }
        }

        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, asiakasid FROM asiakkaat", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        
        public bool muokkaaAsiakasta(String enimi, String snimi, String osoite, String pnro, String ppaikka, String asiid)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `asiakkaat` SET `Etunimi`= @enm," +
                "`Sukunimi`= @snm,`Lahiosoite`= @oso,`Postinumero`= @pno,`Postitoimipaikka`= @ptp" +
                " WHERE asiakasid = @asid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();
          
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@asid", MySqlDbType.VarChar).Value = asiid;



            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }
        }

    
        public bool poistaAsiakas(String asiid)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM asiakkaat WHERE asiakasid = @asid";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();
            
            komento.Parameters.Add("@asid", MySqlDbType.VarChar).Value = asiid;

            yhteys.AvaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.SuljeYhteys();
                return true;
            }
            else
            {
                yhteys.SuljeYhteys();
                return false;
            }
        }


    }
}

