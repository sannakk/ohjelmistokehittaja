using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Sanna" && SalasanaTB.Text == "123")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                virheviestiLB.Text = "Virhe";
                virheviestiLB.Visible = true;
            }
        }
    }
}
