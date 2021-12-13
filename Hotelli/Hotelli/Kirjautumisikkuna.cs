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


namespace Hotelli
{
    public partial class Kirjautumisikkuna : Form
    {
        public Kirjautumisikkuna()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            YHDISTA tietokantaan = new YHDISTA();
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();
            String kysely = "SELECT Ktunnus, Salasana FROM kayttajat WHERE Ktunnus = @kt AND Salasana = @ss";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.OtaYhteys();

            komento.Parameters.Add("@kt", MySqlDbType.VarChar).Value = KayttajaTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = SalasanaTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            if (taulu.Rows.Count > 0)
            {
                this.Hide();
                Hallintaikkuna hikkuna = new Hallintaikkuna();
                hikkuna.Show();
            }
            else
            {
                if (KayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjänimi kirjautuaksesi", "Käyttäjänimi on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (SalasanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasana kirjautuaksesi", "Salasana on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Käyttäjänimeä tai salasanaa ei löydy", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
