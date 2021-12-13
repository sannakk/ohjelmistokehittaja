using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotelli
{
    class YHDISTA
    {
        public string YhteysLause()
        {
            return "datasource=localhost; port=3306;username=root;password=;database=hotelli";
        }

        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=hotelli; SSL Mode=None");

        public MySqlConnection OtaYhteys()
        {
            return yhteys;
        }

        public void AvaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void SuljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
