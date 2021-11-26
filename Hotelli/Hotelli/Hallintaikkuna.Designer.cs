
namespace Hotelli
{
    partial class Hallintaikkuna
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
            this.AsiakkaatBT = new System.Windows.Forms.Button();
            this.VarauksetBT = new System.Windows.Forms.Button();
            this.HuoneetBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AsiakkaatBT
            // 
            this.AsiakkaatBT.Location = new System.Drawing.Point(39, 59);
            this.AsiakkaatBT.Name = "AsiakkaatBT";
            this.AsiakkaatBT.Size = new System.Drawing.Size(179, 47);
            this.AsiakkaatBT.TabIndex = 1;
            this.AsiakkaatBT.Text = "Asiakkaat";
            this.AsiakkaatBT.UseVisualStyleBackColor = true;
            this.AsiakkaatBT.Click += new System.EventHandler(this.AsiakkaatBT_Click);
            // 
            // VarauksetBT
            // 
            this.VarauksetBT.Location = new System.Drawing.Point(39, 150);
            this.VarauksetBT.Name = "VarauksetBT";
            this.VarauksetBT.Size = new System.Drawing.Size(179, 48);
            this.VarauksetBT.TabIndex = 2;
            this.VarauksetBT.Text = "Varaukset";
            this.VarauksetBT.UseVisualStyleBackColor = true;
            this.VarauksetBT.Click += new System.EventHandler(this.VarauksetBT_Click);
            // 
            // HuoneetBT
            // 
            this.HuoneetBT.Location = new System.Drawing.Point(39, 245);
            this.HuoneetBT.Name = "HuoneetBT";
            this.HuoneetBT.Size = new System.Drawing.Size(179, 48);
            this.HuoneetBT.TabIndex = 3;
            this.HuoneetBT.Text = "Huoneet";
            this.HuoneetBT.UseVisualStyleBackColor = true;
            this.HuoneetBT.Click += new System.EventHandler(this.HuoneetBT_Click);
            // 
            // Hallintaikkuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 320);
            this.Controls.Add(this.HuoneetBT);
            this.Controls.Add(this.VarauksetBT);
            this.Controls.Add(this.AsiakkaatBT);
            this.Name = "Hallintaikkuna";
            this.Text = "Hallinta";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AsiakkaatBT;
        private System.Windows.Forms.Button VarauksetBT;
        private System.Windows.Forms.Button HuoneetBT;
    }
}