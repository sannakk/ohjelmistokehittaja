
namespace Hotelli
{
    partial class Huoneikkuna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HuoneennroTB = new System.Windows.Forms.TextBox();
            this.PuhelinTB = new System.Windows.Forms.TextBox();
            this.HuoneetDG = new System.Windows.Forms.DataGridView();
            this.LisaaHuoneBT = new System.Windows.Forms.Button();
            this.MuokkaaHuoneBT = new System.Windows.Forms.Button();
            this.PoistaHuoneBT = new System.Windows.Forms.Button();
            this.TyhjennaHuoneBT = new System.Windows.Forms.Button();
            this.HuoneentyyppiCB = new System.Windows.Forms.ComboBox();
            this.JooRB = new System.Windows.Forms.RadioButton();
            this.EiRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.HuoneetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huoneen nro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Huonetyyppi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puhelin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vapaa";
            // 
            // HuoneennroTB
            // 
            this.HuoneennroTB.Location = new System.Drawing.Point(109, 76);
            this.HuoneennroTB.Name = "HuoneennroTB";
            this.HuoneennroTB.Size = new System.Drawing.Size(120, 22);
            this.HuoneennroTB.TabIndex = 4;

            // 
            // PuhelinTB
            // 
            this.PuhelinTB.Location = new System.Drawing.Point(109, 157);
            this.PuhelinTB.Name = "PuhelinTB";
            this.PuhelinTB.Size = new System.Drawing.Size(120, 22);
            this.PuhelinTB.TabIndex = 5;
            // 
            // HuoneetDG
            // 
            this.HuoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HuoneetDG.Location = new System.Drawing.Point(243, 62);
            this.HuoneetDG.Name = "HuoneetDG";
            this.HuoneetDG.RowHeadersWidth = 51;
            this.HuoneetDG.RowTemplate.Height = 24;
            this.HuoneetDG.Size = new System.Drawing.Size(371, 190);
            this.HuoneetDG.TabIndex = 6;
            // 
            // LisaaHuoneBT
            // 
            this.LisaaHuoneBT.Location = new System.Drawing.Point(26, 258);
            this.LisaaHuoneBT.Name = "LisaaHuoneBT";
            this.LisaaHuoneBT.Size = new System.Drawing.Size(77, 37);
            this.LisaaHuoneBT.TabIndex = 7;
            this.LisaaHuoneBT.Text = "Lisää";
            this.LisaaHuoneBT.UseVisualStyleBackColor = true;
            this.LisaaHuoneBT.Click += new System.EventHandler(this.LisaaHuoneBT_Click);
            // 
            // MuokkaaHuoneBT
            // 
            this.MuokkaaHuoneBT.Location = new System.Drawing.Point(122, 258);
            this.MuokkaaHuoneBT.Name = "MuokkaaHuoneBT";
            this.MuokkaaHuoneBT.Size = new System.Drawing.Size(83, 37);
            this.MuokkaaHuoneBT.TabIndex = 8;
            this.MuokkaaHuoneBT.Text = "Muokkaa";
            this.MuokkaaHuoneBT.UseVisualStyleBackColor = true;
            this.MuokkaaHuoneBT.Click += new System.EventHandler(this.MuokkaaHuoneBT_Click);
            // 
            // PoistaHuoneBT
            // 
            this.PoistaHuoneBT.Location = new System.Drawing.Point(221, 258);
            this.PoistaHuoneBT.Name = "PoistaHuoneBT";
            this.PoistaHuoneBT.Size = new System.Drawing.Size(81, 37);
            this.PoistaHuoneBT.TabIndex = 9;
            this.PoistaHuoneBT.Text = "Poista";
            this.PoistaHuoneBT.UseVisualStyleBackColor = true;
            this.PoistaHuoneBT.Click += new System.EventHandler(this.PoistaHuoneBT_Click);
            // 
            // TyhjennaHuoneBT
            // 
            this.TyhjennaHuoneBT.Location = new System.Drawing.Point(325, 258);
            this.TyhjennaHuoneBT.Name = "TyhjennaHuoneBT";
            this.TyhjennaHuoneBT.Size = new System.Drawing.Size(89, 36);
            this.TyhjennaHuoneBT.TabIndex = 10;
            this.TyhjennaHuoneBT.Text = "Tyhjennä";
            this.TyhjennaHuoneBT.UseVisualStyleBackColor = true;
            this.TyhjennaHuoneBT.Click += new System.EventHandler(this.TyhjennaHuoneBT_Click);
            // 
            // HuoneentyyppiCB
            // 
            this.HuoneentyyppiCB.FormattingEnabled = true;
            this.HuoneentyyppiCB.Location = new System.Drawing.Point(109, 111);
            this.HuoneentyyppiCB.Name = "HuoneentyyppiCB";
            this.HuoneentyyppiCB.Size = new System.Drawing.Size(121, 24);
            this.HuoneentyyppiCB.TabIndex = 11;
            // 
            // JooRB
            // 
            this.JooRB.AutoSize = true;
            this.JooRB.Location = new System.Drawing.Point(109, 195);
            this.JooRB.Name = "JooRB";
            this.JooRB.Size = new System.Drawing.Size(59, 21);
            this.JooRB.TabIndex = 12;
            this.JooRB.TabStop = true;
            this.JooRB.Text = "Kyllä";
            this.JooRB.UseVisualStyleBackColor = true;
            // 
            // EiRB
            // 
            this.EiRB.AutoSize = true;
            this.EiRB.Location = new System.Drawing.Point(109, 223);
            this.EiRB.Name = "EiRB";
            this.EiRB.Size = new System.Drawing.Size(41, 21);
            this.EiRB.TabIndex = 13;
            this.EiRB.TabStop = true;
            this.EiRB.Text = "Ei";
            this.EiRB.UseVisualStyleBackColor = true;
            // 
            // Huoneikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 307);
            this.Controls.Add(this.EiRB);
            this.Controls.Add(this.JooRB);
            this.Controls.Add(this.HuoneentyyppiCB);
            this.Controls.Add(this.TyhjennaHuoneBT);
            this.Controls.Add(this.PoistaHuoneBT);
            this.Controls.Add(this.MuokkaaHuoneBT);
            this.Controls.Add(this.LisaaHuoneBT);
            this.Controls.Add(this.HuoneetDG);
            this.Controls.Add(this.PuhelinTB);
            this.Controls.Add(this.HuoneennroTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Huoneikkuna";
            this.Text = "Huoneet";
            this.Load += new System.EventHandler(this.Huoneikkuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HuoneetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HuoneennroTB;
        private System.Windows.Forms.TextBox PuhelinTB;
        private System.Windows.Forms.DataGridView HuoneetDG;
        private System.Windows.Forms.Button LisaaHuoneBT;
        private System.Windows.Forms.Button MuokkaaHuoneBT;
        private System.Windows.Forms.Button PoistaHuoneBT;
        private System.Windows.Forms.Button TyhjennaHuoneBT;
        private System.Windows.Forms.ComboBox HuoneentyyppiCB;
        private System.Windows.Forms.RadioButton JooRB;
        private System.Windows.Forms.RadioButton EiRB;
    }
}