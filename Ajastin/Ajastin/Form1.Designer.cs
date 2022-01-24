
namespace Ajastin
{
    partial class CounterForm
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
            this.components = new System.ComponentModel.Container();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.AikaLB = new System.Windows.Forms.Label();
            this.MinuutitCB = new System.Windows.Forms.ComboBox();
            this.SekunnitCB = new System.Windows.Forms.ComboBox();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.AjastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Location = new System.Drawing.Point(84, 57);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(166, 44);
            this.MinuutitLB.TabIndex = 0;
            this.MinuutitLB.Text = "Minuutit:";
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Location = new System.Drawing.Point(328, 57);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(179, 44);
            this.SekunnitLB.TabIndex = 1;
            this.SekunnitLB.Text = "Sekunnit:";
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AikaLB.Location = new System.Drawing.Point(171, 190);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(237, 91);
            this.AikaLB.TabIndex = 2;
            this.AikaLB.Text = "00:00";
            // 
            // MinuutitCB
            // 
            this.MinuutitCB.FormattingEnabled = true;
            this.MinuutitCB.Location = new System.Drawing.Point(92, 115);
            this.MinuutitCB.Name = "MinuutitCB";
            this.MinuutitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinuutitCB.Size = new System.Drawing.Size(165, 50);
            this.MinuutitCB.TabIndex = 4;
            // 
            // SekunnitCB
            // 
            this.SekunnitCB.FormattingEnabled = true;
            this.SekunnitCB.Location = new System.Drawing.Point(336, 115);
            this.SekunnitCB.Name = "SekunnitCB";
            this.SekunnitCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SekunnitCB.Size = new System.Drawing.Size(168, 50);
            this.SekunnitCB.TabIndex = 5;
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(92, 334);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(172, 62);
            this.StartBT.TabIndex = 6;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(332, 334);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(172, 62);
            this.StopBT.TabIndex = 7;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinTM
            // 
            this.AjastinTM.Interval = 1000;
            this.AjastinTM.Tick += new System.EventHandler(this.AjastinTM_Tick);
            // 
            // CounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 446);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.SekunnitCB);
            this.Controls.Add(this.MinuutitCB);
            this.Controls.Add(this.AikaLB);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.MinuutitLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "CounterForm";
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.CounterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MinuutitLB;
        private System.Windows.Forms.Label SekunnitLB;
        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.ComboBox MinuutitCB;
        private System.Windows.Forms.ComboBox SekunnitCB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}

