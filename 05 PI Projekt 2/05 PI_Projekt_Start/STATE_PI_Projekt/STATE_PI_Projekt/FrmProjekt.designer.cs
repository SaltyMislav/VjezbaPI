namespace STATE_PI_Projekt
{
    partial class FrmProjekt
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
            this.txtOpisTeme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZabiljeziTemu = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOznakaTima = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDatumPrveFaze = new System.Windows.Forms.DateTimePicker();
            this.btnPredajPrvuFazu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOdbijTemu = new System.Windows.Forms.Button();
            this.btnPrihvatiTemu = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOcijeniProjekt = new System.Windows.Forms.Button();
            this.btnPredajCijeliProjekt = new System.Windows.Forms.Button();
            this.dtpDatumPredajeCijelogProjekta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBrojBodova = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOpisTeme
            // 
            this.txtOpisTeme.Location = new System.Drawing.Point(134, 32);
            this.txtOpisTeme.Multiline = true;
            this.txtOpisTeme.Name = "txtOpisTeme";
            this.txtOpisTeme.Size = new System.Drawing.Size(243, 20);
            this.txtOpisTeme.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis teme:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZabiljeziTemu);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOznakaTima);
            this.groupBox1.Controls.Add(this.txtOpisTeme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o projektu:";
            // 
            // btnZabiljeziTemu
            // 
            this.btnZabiljeziTemu.Location = new System.Drawing.Point(480, 32);
            this.btnZabiljeziTemu.Name = "btnZabiljeziTemu";
            this.btnZabiljeziTemu.Size = new System.Drawing.Size(85, 23);
            this.btnZabiljeziTemu.TabIndex = 4;
            this.btnZabiljeziTemu.Text = "Zabilježi temu";
            this.btnZabiljeziTemu.UseVisualStyleBackColor = true;
            this.btnZabiljeziTemu.Click += new System.EventHandler(this.btnZabiljeziTemu_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(383, 32);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(91, 20);
            this.txtStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oznaka tima:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            // 
            // txtOznakaTima
            // 
            this.txtOznakaTima.Location = new System.Drawing.Point(12, 32);
            this.txtOznakaTima.Name = "txtOznakaTima";
            this.txtOznakaTima.Size = new System.Drawing.Size(117, 20);
            this.txtOznakaTima.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDatumPrveFaze);
            this.groupBox3.Controls.Add(this.btnPredajPrvuFazu);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(147, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 111);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Predaja 1. faze:";
            // 
            // dtpDatumPrveFaze
            // 
            this.dtpDatumPrveFaze.Location = new System.Drawing.Point(12, 35);
            this.dtpDatumPrveFaze.Name = "dtpDatumPrveFaze";
            this.dtpDatumPrveFaze.Size = new System.Drawing.Size(149, 20);
            this.dtpDatumPrveFaze.TabIndex = 11;
            // 
            // btnPredajPrvuFazu
            // 
            this.btnPredajPrvuFazu.Location = new System.Drawing.Point(72, 61);
            this.btnPredajPrvuFazu.Name = "btnPredajPrvuFazu";
            this.btnPredajPrvuFazu.Size = new System.Drawing.Size(89, 32);
            this.btnPredajPrvuFazu.TabIndex = 5;
            this.btnPredajPrvuFazu.Text = "Predaj";
            this.btnPredajPrvuFazu.UseVisualStyleBackColor = true;
            this.btnPredajPrvuFazu.Click += new System.EventHandler(this.btnPredajPrvuFazu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum predaje:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOdbijTemu);
            this.groupBox4.Controls.Add(this.btnPrihvatiTemu);
            this.groupBox4.Location = new System.Drawing.Point(14, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 111);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Provjera teme:";
            // 
            // btnOdbijTemu
            // 
            this.btnOdbijTemu.Location = new System.Drawing.Point(9, 23);
            this.btnOdbijTemu.Name = "btnOdbijTemu";
            this.btnOdbijTemu.Size = new System.Drawing.Size(108, 32);
            this.btnOdbijTemu.TabIndex = 6;
            this.btnOdbijTemu.Text = "Odbij temu";
            this.btnOdbijTemu.UseVisualStyleBackColor = true;
            this.btnOdbijTemu.Click += new System.EventHandler(this.btnOdbijTemu_Click);
            // 
            // btnPrihvatiTemu
            // 
            this.btnPrihvatiTemu.Location = new System.Drawing.Point(9, 61);
            this.btnPrihvatiTemu.Name = "btnPrihvatiTemu";
            this.btnPrihvatiTemu.Size = new System.Drawing.Size(108, 32);
            this.btnPrihvatiTemu.TabIndex = 5;
            this.btnPrihvatiTemu.Text = "Prihvati temu";
            this.btnPrihvatiTemu.UseVisualStyleBackColor = true;
            this.btnPrihvatiTemu.Click += new System.EventHandler(this.btnPrihvatiTemu_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPredajCijeliProjekt);
            this.groupBox5.Controls.Add(this.dtpDatumPredajeCijelogProjekta);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(328, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(183, 111);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Predaja cijelog projekta";
            // 
            // btnOcijeniProjekt
            // 
            this.btnOcijeniProjekt.Location = new System.Drawing.Point(41, 61);
            this.btnOcijeniProjekt.Name = "btnOcijeniProjekt";
            this.btnOcijeniProjekt.Size = new System.Drawing.Size(89, 32);
            this.btnOcijeniProjekt.TabIndex = 10;
            this.btnOcijeniProjekt.Text = "Ocijeni";
            this.btnOcijeniProjekt.UseVisualStyleBackColor = true;
            this.btnOcijeniProjekt.Click += new System.EventHandler(this.btnOcijeni_Click);
            // 
            // btnPredajCijeliProjekt
            // 
            this.btnPredajCijeliProjekt.Location = new System.Drawing.Point(83, 61);
            this.btnPredajCijeliProjekt.Name = "btnPredajCijeliProjekt";
            this.btnPredajCijeliProjekt.Size = new System.Drawing.Size(89, 32);
            this.btnPredajCijeliProjekt.TabIndex = 6;
            this.btnPredajCijeliProjekt.Text = "Predaj";
            this.btnPredajCijeliProjekt.UseVisualStyleBackColor = true;
            this.btnPredajCijeliProjekt.Click += new System.EventHandler(this.btnPredajCijeliProjekt_Click);
            // 
            // dtpDatumPredajeCijelogProjekta
            // 
            this.dtpDatumPredajeCijelogProjekta.Location = new System.Drawing.Point(19, 35);
            this.dtpDatumPredajeCijelogProjekta.Name = "dtpDatumPredajeCijelogProjekta";
            this.dtpDatumPredajeCijelogProjekta.Size = new System.Drawing.Size(153, 20);
            this.dtpDatumPredajeCijelogProjekta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Datum predaje:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBrojBodova);
            this.groupBox2.Controls.Add(this.btnOcijeniProjekt);
            this.groupBox2.Location = new System.Drawing.Point(517, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 111);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ocjena projekta:";
            // 
            // txtBrojBodova
            // 
            this.txtBrojBodova.Location = new System.Drawing.Point(6, 35);
            this.txtBrojBodova.Name = "txtBrojBodova";
            this.txtBrojBodova.Size = new System.Drawing.Size(124, 20);
            this.txtBrojBodova.TabIndex = 12;
            // 
            // FrmProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 221);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProjekt";
            this.Text = "Projekt";
            this.Load += new System.EventHandler(this.FrmProjekt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtOpisTeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnZabiljeziTemu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOznakaTima;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPredajPrvuFazu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOdbijTemu;
        private System.Windows.Forms.Button btnPrihvatiTemu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpDatumPredajeCijelogProjekta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPredajCijeliProjekt;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOcijeniProjekt;
        private System.Windows.Forms.DateTimePicker dtpDatumPrveFaze;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBrojBodova;
    }
}

