
namespace RoomalaisetNrot
{
    partial class RoomalaisiksiForm
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
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(593, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna numero välillä 1-3999 niin muutan sen roomalaiseksi:";
            // 
            // TekstiTB
            // 
            this.TekstiTB.Location = new System.Drawing.Point(625, 101);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(100, 33);
            this.TekstiTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(37, 172);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(92, 27);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            this.MuutaBT.Location = new System.Drawing.Point(625, 157);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(100, 42);
            this.MuutaBT.TabIndex = 4;
            this.MuutaBT.Text = "Muuta";
            this.MuutaBT.UseVisualStyleBackColor = true;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // RoomalaisiksiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 265);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "RoomalaisiksiForm";
            this.Text = "Roomalaiset numerot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button MuutaBT;
    }
}

