using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelli
{
    public partial class Asiakasikkuna : Form
    {
        ASIAKAS asiakas = new ASIAKAS();
        public Asiakasikkuna()
        {
            
            InitializeComponent();
        }

        private void Asiakasikkuna_Load(object sender, EventArgs e)
        {
            AsiakkaatDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void LisaaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String osoite = OsoiteTB.Text;
            String pnro = PostinumeroTB.Text;
            String ppaikka = PostitoimiTB.Text;
            String kayttaja = KayttajaTB.Text;
            String ssana = SalasanaTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("") || ppaikka.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, Osoite, Postinumero ja Postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.lisaaAsiakas(enimi, snimi, osoite, pnro, ppaikka, kayttaja);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty lisäämään", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AsiakkaatDG.DataSource = asiakas.haeAsiakkaat();

            }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String osoite = OsoiteTB.Text;
            String pnro = PostinumeroTB.Text;
            String ppaikka = PostitoimiTB.Text;
            String ktunnus = KayttajaTB.Text;


            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("") || ppaikka.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, Osoite, Postinumero ja Postitoimipaikka", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaAsiakas = asiakas.muokkaaAsiakasta(enimi, snimi, osoite, pnro, ppaikka, ktunnus);
                if (muokkaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas päivitetty onnistuneesti", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty päivittämään", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AsiakkaatDG.DataSource = asiakas.haeAsiakkaat();
        }
        private void PoistaBT_Click(object sender, EventArgs e)
        {
            String kayttaja = KayttajaTB.Text;
            if (asiakas.poistaAsiakas(kayttaja))
            {
                AsiakkaatDG.DataSource = asiakas.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettu onnistuneesti", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakasta ei pystytty poistamaan", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();

        }
        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            OsoiteTB.Text = "";
            PostinumeroTB.Text = "";
            PostitoimiTB.Text = "";
            KayttajaTB.Text = "";
            SalasanaTB.Text = "";
        }
        private void AsiakkaatDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EtunimiTB.Text = AsiakkaatDG.CurrentRow.Cells[0].Value.ToString();
            SukunimiTB.Text = AsiakkaatDG.CurrentRow.Cells[1].Value.ToString();
            OsoiteTB.Text = AsiakkaatDG.CurrentRow.Cells[2].Value.ToString();
            PostinumeroTB.Text = AsiakkaatDG.CurrentRow.Cells[3].Value.ToString();
            PostitoimiTB.Text = AsiakkaatDG.CurrentRow.Cells[4].Value.ToString();
            KayttajaTB.Text = AsiakkaatDG.CurrentRow.Cells[5].Value.ToString();
        }

       
    }
    
}
