using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_laskuri
{
    public partial class BMIform : Form
    {
        public BMIform()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            if (bmi <18.5)
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Aqua;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Aqua;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
            else if (bmi < 25)
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
            else if (bmi < 40)
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Gold;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Gold;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
            else 
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
        }
    }
}
