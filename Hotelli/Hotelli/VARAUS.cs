using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Hotelli
{
    class VARAUS
    {
        YHDISTA yhteys = new YHDISTA();

        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huonekategoriat", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM varaukset", yhteys.OtaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

    
        public bool lisaaVaraus(int hnro, int anro, DateTime sisaan, DateTime ulos)
        {

            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO `varaukset`" +
               "(huoneennumero, asiakasid, pvmsisaan, pvmulos) " +
               "VALUES (@hno, @aid, @sis, @ulo); ";

            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.Int32).Value = anro;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;
            yhteys.AvaaYhteys();
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }

        }
        public bool muokkaaVarausta(int hnro, int asid, DateTime sisaan, DateTime ulos, int vara)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `varaukset` SET `huoneennumero`= @hno," +
                "`asiakasid`= @aid,`pvmsisaan`= @sis,`pvmulos`= @ulo" +
                " WHERE varausid = @vid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@aid", MySqlDbType.Int32).Value = asid;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;
            komento.Parameters.Add("@vid", MySqlDbType.Int32).Value = vara;

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

        public bool poistaVaraus(String varausnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM varaukset WHERE varausid = @vno";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.OtaYhteys();
            komento.Parameters.Add("@vno", MySqlDbType.VarChar).Value = varausnro;

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

        public bool tarkistaPaiva(DateTime sis, DateTime ulo, int huone)
        {

            List<DateTime> inside = new List<DateTime>();
            List<DateTime> outside = new List<DateTime>();
            bool onValissa = true;
            MySqlCommand komento = new MySqlCommand();
            String kysely = "Select * FROM varaukset WHERE huoneennumero = @hno";
            /* komento.CommandText = kysely;
             komento.Connection = yhteys.otaYhteys();
             // Lisätään annettu huone SQL-parametriksi
             komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = huone;
             yhteys.avaaYhteys();*/

            //Otetaankin yhteys hieman toisella tavalla, jotta voidaan lisätä listamuuttujiin tiedot
            using (MySqlConnection connection = new MySqlConnection(yhteys.YhteysLause()))
            using (MySqlCommand command = new MySqlCommand(kysely, connection))
            {
                command.Parameters.Add("@hno", MySqlDbType.Int32).Value = huone;
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            inside.Add(reader.GetDateTime(3));
                            outside.Add(reader.GetDateTime(4));
                        }
                        reader.Close();
                    }
                }
            }
            for (int i = 0; i < inside.Count; i++)
            {
                if (inside[i] <= sis && sis <= outside[i])
                {
                    i = inside.Count;
                    onValissa = false;
                }
                else
                {
                    onValissa = true;
                }
            }
            return onValissa;
        }

    }
}
