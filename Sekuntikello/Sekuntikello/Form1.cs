using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sekuntikello
{
    public partial class SekkariForm : Form
    {
        private Stopwatch sekkari;
        public SekkariForm()
        {
            InitializeComponent();
        }

        private void AjanottoTM_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }

        private void KaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void SekkariForm_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch();
        }
    }
}
