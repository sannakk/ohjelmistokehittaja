
namespace Hotelli
{
    partial class Varausikkuna
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LisaaVarausBT = new System.Windows.Forms.Button();
            this.MuokkaaVarausBT = new System.Windows.Forms.Button();
            this.PoistaVarausBT = new System.Windows.Forms.Button();
            this.TyhjennaVarausBT = new System.Windows.Forms.Button();
            this.VarausNroTB = new System.Windows.Forms.TextBox();
            this.AsiakasCB = new System.Windows.Forms.ComboBox();
            this.HuoneTyyppiCB = new System.Windows.Forms.ComboBox();
            this.HuoneNroCB = new System.Windows.Forms.ComboBox();
            this.SisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.UlosDTP = new System.Windows.Forms.DateTimePicker();
            this.VarauksetDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varaus nro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asiakas nro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Huonetyyppi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Huoneen nro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sisään";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ulos";
            // 
            // LisaaVarausBT
            // 
            this.LisaaVarausBT.Location = new System.Drawing.Point(18, 304);
            this.LisaaVarausBT.Name = "LisaaVarausBT";
            this.LisaaVarausBT.Size = new System.Drawing.Size(88, 23);
            this.LisaaVarausBT.TabIndex = 6;
            this.LisaaVarausBT.Text = "Lisää";
            this.LisaaVarausBT.UseVisualStyleBackColor = true;
            this.LisaaVarausBT.Click += new System.EventHandler(this.LisaaVarausBT_Click);
            // 
            // MuokkaaVarausBT
            // 
            this.MuokkaaVarausBT.Location = new System.Drawing.Point(117, 303);
            this.MuokkaaVarausBT.Name = "MuokkaaVarausBT";
            this.MuokkaaVarausBT.Size = new System.Drawing.Size(88, 24);
            this.MuokkaaVarausBT.TabIndex = 7;
            this.MuokkaaVarausBT.Text = "Muokkaa";
            this.MuokkaaVarausBT.UseVisualStyleBackColor = true;
            this.MuokkaaVarausBT.Click += new System.EventHandler(this.MuokkaaVarausBT_Click);
            // 
            // PoistaVarausBT
            // 
            this.PoistaVarausBT.Location = new System.Drawing.Point(221, 303);
            this.PoistaVarausBT.Name = "PoistaVarausBT";
            this.PoistaVarausBT.Size = new System.Drawing.Size(90, 24);
            this.PoistaVarausBT.TabIndex = 8;
            this.PoistaVarausBT.Text = "Poista";
            this.PoistaVarausBT.UseVisualStyleBackColor = true;
            this.PoistaVarausBT.Click += new System.EventHandler(this.PoistaVarausBT_Click);
            // 
            // TyhjennaVarausBT
            // 
            this.TyhjennaVarausBT.Location = new System.Drawing.Point(329, 302);
            this.TyhjennaVarausBT.Name = "TyhjennaVarausBT";
            this.TyhjennaVarausBT.Size = new System.Drawing.Size(94, 25);
            this.TyhjennaVarausBT.TabIndex = 9;
            this.TyhjennaVarausBT.Text = "Tyhjennä";
            this.TyhjennaVarausBT.UseVisualStyleBackColor = true;
            this.TyhjennaVarausBT.Click += new System.EventHandler(this.TyhjennaVarausBT_Click);
            // 
            // VarausNroTB
            // 
            this.VarausNroTB.Enabled = false;
            this.VarausNroTB.Location = new System.Drawing.Point(117, 43);
            this.VarausNroTB.Name = "VarausNroTB";
            this.VarausNroTB.Size = new System.Drawing.Size(121, 22);
            this.VarausNroTB.TabIndex = 10;
            // 
            // AsiakasCB
            // 
            this.AsiakasCB.FormattingEnabled = true;
            this.AsiakasCB.Location = new System.Drawing.Point(117, 83);
            this.AsiakasCB.Name = "AsiakasCB";
            this.AsiakasCB.Size = new System.Drawing.Size(121, 24);
            this.AsiakasCB.TabIndex = 11;
            // 
            // HuoneTyyppiCB
            // 
            this.HuoneTyyppiCB.FormattingEnabled = true;
            this.HuoneTyyppiCB.Location = new System.Drawing.Point(117, 122);
            this.HuoneTyyppiCB.Name = "HuoneTyyppiCB";
            this.HuoneTyyppiCB.Size = new System.Drawing.Size(121, 24);
            this.HuoneTyyppiCB.TabIndex = 12;
            this.HuoneTyyppiCB.SelectedIndexChanged += new System.EventHandler(this.HuoneTyyppiCB_SelectedIndexChanged);
            // 
            // HuoneNroCB
            // 
            this.HuoneNroCB.FormattingEnabled = true;
            this.HuoneNroCB.Location = new System.Drawing.Point(117, 162);
            this.HuoneNroCB.Name = "HuoneNroCB";
            this.HuoneNroCB.Size = new System.Drawing.Size(121, 24);
            this.HuoneNroCB.TabIndex = 13;
            // 
            // SisaanDTP
            // 
            this.SisaanDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SisaanDTP.Location = new System.Drawing.Point(117, 200);
            this.SisaanDTP.Name = "SisaanDTP";
            this.SisaanDTP.Size = new System.Drawing.Size(121, 22);
            this.SisaanDTP.TabIndex = 14;
            // 
            // UlosDTP
            // 
            this.UlosDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UlosDTP.Location = new System.Drawing.Point(117, 238);
            this.UlosDTP.Name = "UlosDTP";
            this.UlosDTP.Size = new System.Drawing.Size(124, 22);
            this.UlosDTP.TabIndex = 15;
            // 
            // VarauksetDG
            // 
            this.VarauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VarauksetDG.Location = new System.Drawing.Point(263, 43);
            this.VarauksetDG.Name = "VarauksetDG";
            this.VarauksetDG.RowHeadersWidth = 51;
            this.VarauksetDG.RowTemplate.Height = 24;
            this.VarauksetDG.Size = new System.Drawing.Size(401, 217);
            this.VarauksetDG.TabIndex = 16;
            this.VarauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellClick);
            // 
            // Varausikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 356);
            this.Controls.Add(this.VarauksetDG);
            this.Controls.Add(this.UlosDTP);
            this.Controls.Add(this.SisaanDTP);
            this.Controls.Add(this.HuoneNroCB);
            this.Controls.Add(this.HuoneTyyppiCB);
            this.Controls.Add(this.AsiakasCB);
            this.Controls.Add(this.VarausNroTB);
            this.Controls.Add(this.TyhjennaVarausBT);
            this.Controls.Add(this.PoistaVarausBT);
            this.Controls.Add(this.MuokkaaVarausBT);
            this.Controls.Add(this.LisaaVarausBT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Varausikkuna";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.Varausikkuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LisaaVarausBT;
        private System.Windows.Forms.Button MuokkaaVarausBT;
        private System.Windows.Forms.Button PoistaVarausBT;
        private System.Windows.Forms.Button TyhjennaVarausBT;
        private System.Windows.Forms.TextBox VarausNroTB;
        private System.Windows.Forms.ComboBox AsiakasCB;
        private System.Windows.Forms.ComboBox HuoneTyyppiCB;
        private System.Windows.Forms.ComboBox HuoneNroCB;
        private System.Windows.Forms.DateTimePicker SisaanDTP;
        private System.Windows.Forms.DateTimePicker UlosDTP;
        private System.Windows.Forms.DataGridView VarauksetDG;
    }
}