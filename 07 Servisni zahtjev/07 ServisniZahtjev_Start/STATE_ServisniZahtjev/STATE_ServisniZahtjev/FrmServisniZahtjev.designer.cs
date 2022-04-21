namespace STATE_ServisniZahtjev
{
    partial class FrmServisniZahtjev
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
            this.gbPodaciZahtjeva = new System.Windows.Forms.GroupBox();
            this.dtpDatumIzrade = new System.Windows.Forms.DateTimePicker();
            this.btnOdbijZahtjev = new System.Windows.Forms.Button();
            this.txtStatusZahtjeva = new System.Windows.Forms.TextBox();
            this.txtOpisKvara = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPodnesiZahtjev = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbZaprimanjeZahtjeva = new System.Windows.Forms.GroupBox();
            this.dtpDatumZaprimanja = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnZaprimiZahtjev = new System.Windows.Forms.Button();
            this.gbServisiranje = new System.Windows.Forms.GroupBox();
            this.dtpDatumZatvaranja = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZapocniServisiranje = new System.Windows.Forms.Button();
            this.btnZatvoriZahtjev = new System.Windows.Forms.Button();
            this.gbPodaciZahtjeva.SuspendLayout();
            this.gbZaprimanjeZahtjeva.SuspendLayout();
            this.gbServisiranje.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPodaciZahtjeva
            // 
            this.gbPodaciZahtjeva.Controls.Add(this.dtpDatumIzrade);
            this.gbPodaciZahtjeva.Controls.Add(this.btnOdbijZahtjev);
            this.gbPodaciZahtjeva.Controls.Add(this.txtStatusZahtjeva);
            this.gbPodaciZahtjeva.Controls.Add(this.txtOpisKvara);
            this.gbPodaciZahtjeva.Controls.Add(this.label10);
            this.gbPodaciZahtjeva.Controls.Add(this.btnPodnesiZahtjev);
            this.gbPodaciZahtjeva.Controls.Add(this.label3);
            this.gbPodaciZahtjeva.Controls.Add(this.label2);
            this.gbPodaciZahtjeva.Location = new System.Drawing.Point(9, 10);
            this.gbPodaciZahtjeva.Margin = new System.Windows.Forms.Padding(2);
            this.gbPodaciZahtjeva.Name = "gbPodaciZahtjeva";
            this.gbPodaciZahtjeva.Padding = new System.Windows.Forms.Padding(2);
            this.gbPodaciZahtjeva.Size = new System.Drawing.Size(464, 164);
            this.gbPodaciZahtjeva.TabIndex = 2;
            this.gbPodaciZahtjeva.TabStop = false;
            this.gbPodaciZahtjeva.Text = "Osnovni podaci servisnog zahtjeva:";
            // 
            // dtpDatumIzrade
            // 
            this.dtpDatumIzrade.Enabled = false;
            this.dtpDatumIzrade.Location = new System.Drawing.Point(90, 17);
            this.dtpDatumIzrade.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatumIzrade.Name = "dtpDatumIzrade";
            this.dtpDatumIzrade.Size = new System.Drawing.Size(148, 20);
            this.dtpDatumIzrade.TabIndex = 13;
            // 
            // btnOdbijZahtjev
            // 
            this.btnOdbijZahtjev.BackColor = System.Drawing.Color.Red;
            this.btnOdbijZahtjev.Location = new System.Drawing.Point(303, 76);
            this.btnOdbijZahtjev.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdbijZahtjev.Name = "btnOdbijZahtjev";
            this.btnOdbijZahtjev.Size = new System.Drawing.Size(127, 28);
            this.btnOdbijZahtjev.TabIndex = 10;
            this.btnOdbijZahtjev.Text = "Odbij zahtjev";
            this.btnOdbijZahtjev.UseVisualStyleBackColor = false;
            this.btnOdbijZahtjev.Click += new System.EventHandler(this.btnOdbijZahtjev_Click);
            // 
            // txtStatusZahtjeva
            // 
            this.txtStatusZahtjeva.Enabled = false;
            this.txtStatusZahtjeva.Location = new System.Drawing.Point(90, 110);
            this.txtStatusZahtjeva.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatusZahtjeva.Name = "txtStatusZahtjeva";
            this.txtStatusZahtjeva.Size = new System.Drawing.Size(128, 20);
            this.txtStatusZahtjeva.TabIndex = 13;
            // 
            // txtOpisKvara
            // 
            this.txtOpisKvara.Location = new System.Drawing.Point(90, 44);
            this.txtOpisKvara.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpisKvara.Multiline = true;
            this.txtOpisKvara.Name = "txtOpisKvara";
            this.txtOpisKvara.Size = new System.Drawing.Size(208, 60);
            this.txtOpisKvara.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Status:";
            // 
            // btnPodnesiZahtjev
            // 
            this.btnPodnesiZahtjev.Location = new System.Drawing.Point(302, 44);
            this.btnPodnesiZahtjev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodnesiZahtjev.Name = "btnPodnesiZahtjev";
            this.btnPodnesiZahtjev.Size = new System.Drawing.Size(128, 28);
            this.btnPodnesiZahtjev.TabIndex = 6;
            this.btnPodnesiZahtjev.Text = "Podnesi zahtjev";
            this.btnPodnesiZahtjev.UseVisualStyleBackColor = true;
            this.btnPodnesiZahtjev.Click += new System.EventHandler(this.btnPodnesiZahtjev_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opis kvara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum izrade:";
            // 
            // gbZaprimanjeZahtjeva
            // 
            this.gbZaprimanjeZahtjeva.Controls.Add(this.dtpDatumZaprimanja);
            this.gbZaprimanjeZahtjeva.Controls.Add(this.label5);
            this.gbZaprimanjeZahtjeva.Controls.Add(this.btnZaprimiZahtjev);
            this.gbZaprimanjeZahtjeva.Location = new System.Drawing.Point(9, 179);
            this.gbZaprimanjeZahtjeva.Margin = new System.Windows.Forms.Padding(2);
            this.gbZaprimanjeZahtjeva.Name = "gbZaprimanjeZahtjeva";
            this.gbZaprimanjeZahtjeva.Padding = new System.Windows.Forms.Padding(2);
            this.gbZaprimanjeZahtjeva.Size = new System.Drawing.Size(464, 63);
            this.gbZaprimanjeZahtjeva.TabIndex = 3;
            this.gbZaprimanjeZahtjeva.TabStop = false;
            this.gbZaprimanjeZahtjeva.Text = "Zaprimanje zahtjeva u servis:";
            // 
            // dtpDatumZaprimanja
            // 
            this.dtpDatumZaprimanja.Location = new System.Drawing.Point(112, 25);
            this.dtpDatumZaprimanja.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatumZaprimanja.Name = "dtpDatumZaprimanja";
            this.dtpDatumZaprimanja.Size = new System.Drawing.Size(186, 20);
            this.dtpDatumZaprimanja.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Datum zaprimanja:";
            // 
            // btnZaprimiZahtjev
            // 
            this.btnZaprimiZahtjev.Location = new System.Drawing.Point(302, 25);
            this.btnZaprimiZahtjev.Margin = new System.Windows.Forms.Padding(2);
            this.btnZaprimiZahtjev.Name = "btnZaprimiZahtjev";
            this.btnZaprimiZahtjev.Size = new System.Drawing.Size(128, 22);
            this.btnZaprimiZahtjev.TabIndex = 7;
            this.btnZaprimiZahtjev.Text = "Zaprimi zahtjev";
            this.btnZaprimiZahtjev.UseVisualStyleBackColor = true;
            this.btnZaprimiZahtjev.Click += new System.EventHandler(this.btnZaprimiZahtjev_Click);
            // 
            // gbServisiranje
            // 
            this.gbServisiranje.Controls.Add(this.dtpDatumZatvaranja);
            this.gbServisiranje.Controls.Add(this.label4);
            this.gbServisiranje.Controls.Add(this.dtpDatumPocetka);
            this.gbServisiranje.Controls.Add(this.label6);
            this.gbServisiranje.Controls.Add(this.btnZapocniServisiranje);
            this.gbServisiranje.Controls.Add(this.btnZatvoriZahtjev);
            this.gbServisiranje.Location = new System.Drawing.Point(9, 246);
            this.gbServisiranje.Margin = new System.Windows.Forms.Padding(2);
            this.gbServisiranje.Name = "gbServisiranje";
            this.gbServisiranje.Padding = new System.Windows.Forms.Padding(2);
            this.gbServisiranje.Size = new System.Drawing.Size(464, 95);
            this.gbServisiranje.TabIndex = 10;
            this.gbServisiranje.TabStop = false;
            this.gbServisiranje.Text = "Servisiranje:";
            // 
            // dtpDatumZatvaranja
            // 
            this.dtpDatumZatvaranja.Location = new System.Drawing.Point(112, 55);
            this.dtpDatumZatvaranja.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatumZatvaranja.Name = "dtpDatumZatvaranja";
            this.dtpDatumZatvaranja.Size = new System.Drawing.Size(186, 20);
            this.dtpDatumZatvaranja.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Datum zatvaranja:";
            // 
            // dtpDatumPocetka
            // 
            this.dtpDatumPocetka.Location = new System.Drawing.Point(112, 17);
            this.dtpDatumPocetka.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatumPocetka.Name = "dtpDatumPocetka";
            this.dtpDatumPocetka.Size = new System.Drawing.Size(186, 20);
            this.dtpDatumPocetka.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Datum početka:";
            // 
            // btnZapocniServisiranje
            // 
            this.btnZapocniServisiranje.Location = new System.Drawing.Point(303, 17);
            this.btnZapocniServisiranje.Margin = new System.Windows.Forms.Padding(2);
            this.btnZapocniServisiranje.Name = "btnZapocniServisiranje";
            this.btnZapocniServisiranje.Size = new System.Drawing.Size(128, 20);
            this.btnZapocniServisiranje.TabIndex = 7;
            this.btnZapocniServisiranje.Text = "Započni servisiranje";
            this.btnZapocniServisiranje.UseVisualStyleBackColor = true;
            this.btnZapocniServisiranje.Click += new System.EventHandler(this.btnZapocniServisiranje_Click);
            // 
            // btnZatvoriZahtjev
            // 
            this.btnZatvoriZahtjev.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnZatvoriZahtjev.Location = new System.Drawing.Point(304, 55);
            this.btnZatvoriZahtjev.Margin = new System.Windows.Forms.Padding(2);
            this.btnZatvoriZahtjev.Name = "btnZatvoriZahtjev";
            this.btnZatvoriZahtjev.Size = new System.Drawing.Size(127, 20);
            this.btnZatvoriZahtjev.TabIndex = 7;
            this.btnZatvoriZahtjev.Text = "Zatvori zahtjev";
            this.btnZatvoriZahtjev.UseVisualStyleBackColor = false;
            this.btnZatvoriZahtjev.Click += new System.EventHandler(this.btnZatvoriZahtjev_Click);
            // 
            // FrmServisniZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 356);
            this.Controls.Add(this.gbServisiranje);
            this.Controls.Add(this.gbZaprimanjeZahtjeva);
            this.Controls.Add(this.gbPodaciZahtjeva);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmServisniZahtjev";
            this.Text = "Servisni zahtjev";
            this.Load += new System.EventHandler(this.FrmServisniZahtjev_Load);
            this.gbPodaciZahtjeva.ResumeLayout(false);
            this.gbPodaciZahtjeva.PerformLayout();
            this.gbZaprimanjeZahtjeva.ResumeLayout(false);
            this.gbZaprimanjeZahtjeva.PerformLayout();
            this.gbServisiranje.ResumeLayout(false);
            this.gbServisiranje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPodaciZahtjeva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPodnesiZahtjev;
        private System.Windows.Forms.GroupBox gbZaprimanjeZahtjeva;
        private System.Windows.Forms.Button btnZaprimiZahtjev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbServisiranje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnZapocniServisiranje;
        private System.Windows.Forms.Button btnZatvoriZahtjev;
        private System.Windows.Forms.TextBox txtOpisKvara;
        private System.Windows.Forms.TextBox txtStatusZahtjeva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOdbijZahtjev;
        private System.Windows.Forms.DateTimePicker dtpDatumZaprimanja;
        private System.Windows.Forms.DateTimePicker dtpDatumZatvaranja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetka;
        private System.Windows.Forms.DateTimePicker dtpDatumIzrade;
    }
}

