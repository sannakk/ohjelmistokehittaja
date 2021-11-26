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
            MySqlCommand komento = new MySqlCommand("SELECT AsiakasId, Concat(Etunimi, ' ',Sukunimi) AS Nimi FROM asiakkaat", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
        public bool lisaaAsiakas(String enimi, String snimi, String osoite, String pnro, String ppaikka, String kayttaja, String ssana)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO asiakkaat " +
                "(Ktunnus, Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, Salasana) " +
                "VALUES (@ktu, @enm, @snm, @oso, @pno, @ptp, @ssa); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja;
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = ssana;
           



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


        // Luodaan funktio kaikkien asiakastietojan hakemiseksi
        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, Ktunnus FROM asiakkaat", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        // Luodaan funktio asiakkaan tietojen muokkaamiseksi
        public bool muokkaaAsiakasta(String enimi, String snimi, String osoite, String pnro, String ppaikka, String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `asiakkaat` SET `Etunimi`= @enm," +
                "`Sukunimi`= @snm,`Lahiosoite`= @oso,`Postinumero`= @pno,`Postitoimipaikka`= @ptp" +
                " WHERE Ktunnus = @ktu";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();
            //@ktu,@enm, @snm, @oso, @pno, @ptp, @ssa
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;



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

        // Luodaan funktio asiakkaan tietojen poistamiseen
        // tähän tarvitaan vain käyttäjätunnus
        public bool poistaAsiakas(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM asiakkaat WHERE Ktunnus = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();
            //@ktu
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

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

