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
    public partial class Hallintaikkuna : Form
    {
        public Hallintaikkuna()
        {
            InitializeComponent();
        }
        
        /*private void Hallintaikkuna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }*/

        private void AsiakkaatBT_Click(object sender, EventArgs e)
        {
            Asiakasikkuna asiakkaat = new Asiakasikkuna();
            asiakkaat.ShowDialog();
        }

        private void VarauksetBT_Click(object sender, EventArgs e)
        {
            Varausikkuna varaukset = new Varausikkuna();
            varaukset.ShowDialog();
        }

        private void HuoneetBT_Click(object sender, EventArgs e)
        {
            Huoneikkuna huoneet = new Huoneikkuna();
            huoneet.ShowDialog();
        }

     
    }
}
