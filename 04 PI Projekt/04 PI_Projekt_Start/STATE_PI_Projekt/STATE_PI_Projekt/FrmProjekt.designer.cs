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
            this.txtOpisProjekta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZabiljeziTemu = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOznakaTima = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDatumPredaje = new System.Windows.Forms.DateTimePicker();
            this.btnPredajProjekt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOdbijProjekt = new System.Windows.Forms.Button();
            this.btnPrihvatiProjekt = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOznaciKaoObranjen = new System.Windows.Forms.Button();
            this.btnZakaziObranu = new System.Windows.Forms.Button();
            this.dtpDatumObrane = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOpisProjekta
            // 
            this.txtOpisProjekta.Location = new System.Drawing.Point(134, 32);
            this.txtOpisProjekta.Multiline = true;
            this.txtOpisProjekta.Name = "txtOpisProjekta";
            this.txtOpisProjekta.Size = new System.Drawing.Size(243, 20);
            this.txtOpisProjekta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis projekta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZabiljeziTemu);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOznakaTima);
            this.groupBox1.Controls.Add(this.txtOpisProjekta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 79);
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
            this.groupBox3.Controls.Add(this.dtpDatumPredaje);
            this.groupBox3.Controls.Add(this.btnPredajProjekt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 111);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Predaja projekta:";
            // 
            // dtpDatumPredaje
            // 
            this.dtpDatumPredaje.Location = new System.Drawing.Point(12, 35);
            this.dtpDatumPredaje.Name = "dtpDatumPredaje";
            this.dtpDatumPredaje.Size = new System.Drawing.Size(149, 20);
            this.dtpDatumPredaje.TabIndex = 11;
            // 
            // btnPredajProjekt
            // 
            this.btnPredajProjekt.Location = new System.Drawing.Point(72, 61);
            this.btnPredajProjekt.Name = "btnPredajProjekt";
            this.btnPredajProjekt.Size = new System.Drawing.Size(89, 23);
            this.btnPredajProjekt.TabIndex = 5;
            this.btnPredajProjekt.Text = "Predaj projekt";
            this.btnPredajProjekt.UseVisualStyleBackColor = true;
            this.btnPredajProjekt.Click += new System.EventHandler(this.btnPredajProjekt_Click);
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
            this.groupBox4.Controls.Add(this.btnOdbijProjekt);
            this.groupBox4.Controls.Add(this.btnPrihvatiProjekt);
            this.groupBox4.Location = new System.Drawing.Point(193, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 111);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Provjera projekta:";
            // 
            // btnOdbijProjekt
            // 
            this.btnOdbijProjekt.Location = new System.Drawing.Point(20, 23);
            this.btnOdbijProjekt.Name = "btnOdbijProjekt";
            this.btnOdbijProjekt.Size = new System.Drawing.Size(108, 32);
            this.btnOdbijProjekt.TabIndex = 6;
            this.btnOdbijProjekt.Text = "Odbij projekt";
            this.btnOdbijProjekt.UseVisualStyleBackColor = true;
            this.btnOdbijProjekt.Click += new System.EventHandler(this.btnOdbijProjekt_Click);
            // 
            // btnPrihvatiProjekt
            // 
            this.btnPrihvatiProjekt.Location = new System.Drawing.Point(20, 61);
            this.btnPrihvatiProjekt.Name = "btnPrihvatiProjekt";
            this.btnPrihvatiProjekt.Size = new System.Drawing.Size(108, 32);
            this.btnPrihvatiProjekt.TabIndex = 5;
            this.btnPrihvatiProjekt.Text = "Prihvati projekt";
            this.btnPrihvatiProjekt.UseVisualStyleBackColor = true;
            this.btnPrihvatiProjekt.Click += new System.EventHandler(this.btnPrihvatiProjekt_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOznaciKaoObranjen);
            this.groupBox5.Controls.Add(this.btnZakaziObranu);
            this.groupBox5.Controls.Add(this.dtpDatumObrane);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(351, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(232, 111);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Obrana projekta:";
            // 
            // btnOznaciKaoObranjen
            // 
            this.btnOznaciKaoObranjen.Location = new System.Drawing.Point(114, 61);
            this.btnOznaciKaoObranjen.Name = "btnOznaciKaoObranjen";
            this.btnOznaciKaoObranjen.Size = new System.Drawing.Size(89, 39);
            this.btnOznaciKaoObranjen.TabIndex = 10;
            this.btnOznaciKaoObranjen.Text = "Označi kao obranjen";
            this.btnOznaciKaoObranjen.UseVisualStyleBackColor = true;
            this.btnOznaciKaoObranjen.Click += new System.EventHandler(this.btnOznaciKaoObranjen_Click);
            // 
            // btnZakaziObranu
            // 
            this.btnZakaziObranu.Location = new System.Drawing.Point(19, 61);
            this.btnZakaziObranu.Name = "btnZakaziObranu";
            this.btnZakaziObranu.Size = new System.Drawing.Size(89, 39);
            this.btnZakaziObranu.TabIndex = 6;
            this.btnZakaziObranu.Text = "Zakaži obranu";
            this.btnZakaziObranu.UseVisualStyleBackColor = true;
            this.btnZakaziObranu.Click += new System.EventHandler(this.btnZakaziObranu_Click);
            // 
            // dtpDatumObrane
            // 
            this.dtpDatumObrane.Location = new System.Drawing.Point(19, 35);
            this.dtpDatumObrane.Name = "dtpDatumObrane";
            this.dtpDatumObrane.Size = new System.Drawing.Size(184, 20);
            this.dtpDatumObrane.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Datum obrane:";
            // 
            // FrmProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 224);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtOpisProjekta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnZabiljeziTemu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOznakaTima;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPredajProjekt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOdbijProjekt;
        private System.Windows.Forms.Button btnPrihvatiProjekt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpDatumObrane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnZakaziObranu;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOznaciKaoObranjen;
        private System.Windows.Forms.DateTimePicker dtpDatumPredaje;
    }
}

