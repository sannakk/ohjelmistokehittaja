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
    public partial class Huoneikkuna : Form
    {
        public Huoneikkuna()
        {
            InitializeComponent();
        }

        HUONE huone = new HUONE();

        private void LisaaHuoneBT_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(HuoneennroTB.Text);
            int tyyppi = Convert.ToInt32(HuoneentyyppiCB.SelectedValue.ToString());
            String puhelin = PuhelinTB.Text;
            if (huone.lisaaHuone(numero, tyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huonetta ei pystytty lisäämään", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneetDG.DataSource = huone.haeHuoneet();
        }

        private void MuokkaaHuoneBT_Click(object sender, EventArgs e)
        {
            int tyyppi = Convert.ToInt32(HuoneentyyppiCB.SelectedValue.ToString());
            String puhelin = PuhelinTB.Text;
            String vapaa = "";
            try
            {
                int numero = Convert.ToInt32(HuoneennroTB.Text);
                if (JooRB.Checked)
                {
                    vapaa = "Kyllä";
                }
                else
                {
                    vapaa = "Ei";
                }
                if (huone.muokkaaHuonetta(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneetDG.DataSource = huone.haeHuoneet();
        }

        private void PoistaHuoneBT_Click(object sender, EventArgs e)
        {
            try
            {
                String huonenro = HuoneennroTB.Text;
                if (huone.poistaHuone(huonenro))
                {
                    HuoneetDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TyhjennaHuoneBT.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
        }

        private void TyhjennaHuoneBT_Click(object sender, EventArgs e)
        {
            HuoneennroTB.Text = "";
            HuoneentyyppiCB.SelectedIndex = 0;
            PuhelinTB.Text = "";
        }
        private void HuoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HuoneennroTB.Text = HuoneetDG.CurrentRow.Cells[0].Value.ToString();
            HuoneentyyppiCB.SelectedValue = HuoneetDG.CurrentRow.Cells[1].Value.ToString();
            PuhelinTB.Text = HuoneetDG.CurrentRow.Cells[2].Value.ToString();
        }

        private void Huoneikkuna_Load(object sender, EventArgs e)
        {
            // Haetaan listaus funktiosta huonetyyppilista
            // Näytetään huonetyypin nimi (DisplayMember),
            // Mutta lähetetään eteenpäin KategoriaId (ValueMember)
            HuoneentyyppiCB.DataSource = huone.huonetyyppilista();
            HuoneentyyppiCB.DisplayMember = "huoneentyyppi";
            HuoneentyyppiCB.ValueMember = "kategoriaid";

            HuoneetDG.DataSource = huone.haeHuoneet();
        }

        
    }
}
