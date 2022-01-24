
namespace OppilaitostenTiedot
{
    partial class AvainhenkiloForm
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
            this.oppilaitosCB = new System.Windows.Forms.ComboBox();
            this.vastuuhloCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PostinroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.PuhLB = new System.Windows.Forms.Label();
            this.SahkopostiLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // oppilaitosCB
            // 
            this.oppilaitosCB.FormattingEnabled = true;
            this.oppilaitosCB.Location = new System.Drawing.Point(65, 181);
            this.oppilaitosCB.Name = "oppilaitosCB";
            this.oppilaitosCB.Size = new System.Drawing.Size(197, 37);
            this.oppilaitosCB.TabIndex = 2;
            this.oppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCB_SelectedIndexChanged);
            // 
            // vastuuhloCB
            // 
            this.vastuuhloCB.FormattingEnabled = true;
            this.vastuuhloCB.Location = new System.Drawing.Point(432, 181);
            this.vastuuhloCB.Name = "vastuuhloCB";
            this.vastuuhloCB.Size = new System.Drawing.Size(234, 37);
            this.vastuuhloCB.TabIndex = 4;
            this.vastuuhloCB.TextChanged += new System.EventHandler(this.vastuuhloCB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(65, 242);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(84, 29);
            this.OsoiteLB.TabIndex = 5;
            this.OsoiteLB.Text = "Osoite";
            // 
            // PostinroLB
            // 
            this.PostinroLB.AutoSize = true;
            this.PostinroLB.Location = new System.Drawing.Point(65, 291);
            this.PostinroLB.Name = "PostinroLB";
            this.PostinroLB.Size = new System.Drawing.Size(149, 29);
            this.PostinroLB.TabIndex = 6;
            this.PostinroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(65, 340);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(189, 29);
            this.PostitoimipaikkaLB.TabIndex = 7;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(65, 392);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(94, 29);
            this.PuhelinLB.TabIndex = 8;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // PuhLB
            // 
            this.PuhLB.AutoSize = true;
            this.PuhLB.Location = new System.Drawing.Point(427, 392);
            this.PuhLB.Name = "PuhLB";
            this.PuhLB.Size = new System.Drawing.Size(94, 29);
            this.PuhLB.TabIndex = 12;
            this.PuhLB.Text = "Puhelin";
            // 
            // SahkopostiLB
            // 
            this.SahkopostiLB.AutoSize = true;
            this.SahkopostiLB.Location = new System.Drawing.Point(427, 340);
            this.SahkopostiLB.Name = "SahkopostiLB";
            this.SahkopostiLB.Size = new System.Drawing.Size(166, 36);
            this.SahkopostiLB.TabIndex = 11;
            this.SahkopostiLB.Text = "Sähköposti";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Location = new System.Drawing.Point(427, 291);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(111, 36);
            this.OsastoLB.TabIndex = 10;
            this.OsastoLB.Text = "Osasto";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(427, 242);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(91, 36);
            this.TitteliLB.TabIndex = 9;
            this.TitteliLB.Text = "Titteli";
            // 
            // AvainhenkiloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 448);
            this.Controls.Add(this.PuhLB);
            this.Controls.Add(this.SahkopostiLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.PostinroLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.vastuuhloCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oppilaitosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AvainhenkiloForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkiloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox oppilaitosCB;
        private System.Windows.Forms.ComboBox vastuuhloCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OsoiteLB;
        private System.Windows.Forms.Label PostinroLB;
        private System.Windows.Forms.Label PostitoimipaikkaLB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.Label PuhLB;
        private System.Windows.Forms.Label SahkopostiLB;
        private System.Windows.Forms.Label OsastoLB;
        private System.Windows.Forms.Label TitteliLB;
    }
}

