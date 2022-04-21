namespace STATE_RadniNalog
{
    partial class RadniNalogForm
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
            this.gbPodaciNaloga = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnZakljucaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPredajaUProizvodnju = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPredajNalog = new System.Windows.Forms.Button();
            this.gbProizvodnja = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZapocniProizvodnju = new System.Windows.Forms.Button();
            this.btnDovrsiProizvodnju = new System.Windows.Forms.Button();
            this.btnOtkaziNalog = new System.Windows.Forms.Button();
            this.dtpDatumPredaje = new System.Windows.Forms.DateTimePicker();
            this.txtDatumKreiranja = new System.Windows.Forms.TextBox();
            this.dtpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDovrsetka = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPodaciNaloga.SuspendLayout();
            this.gbPredajaUProizvodnju.SuspendLayout();
            this.gbProizvodnja.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPodaciNaloga
            // 
            this.gbPodaciNaloga.Controls.Add(this.btnOtkaziNalog);
            this.gbPodaciNaloga.Controls.Add(this.txtStatus);
            this.gbPodaciNaloga.Controls.Add(this.txtOpis);
            this.gbPodaciNaloga.Controls.Add(this.label10);
            this.gbPodaciNaloga.Controls.Add(this.btnZakljucaj);
            this.gbPodaciNaloga.Controls.Add(this.label3);
            this.gbPodaciNaloga.Controls.Add(this.txtDatumKreiranja);
            this.gbPodaciNaloga.Controls.Add(this.label2);
            this.gbPodaciNaloga.Location = new System.Drawing.Point(12, 12);
            this.gbPodaciNaloga.Name = "gbPodaciNaloga";
            this.gbPodaciNaloga.Size = new System.Drawing.Size(619, 202);
            this.gbPodaciNaloga.TabIndex = 2;
            this.gbPodaciNaloga.TabStop = false;
            this.gbPodaciNaloga.Text = "Osnovni podaci radnog naloga:";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(432, 46);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(170, 22);
            this.txtStatus.TabIndex = 13;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(21, 99);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(580, 47);
            this.txtOpis.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Status:";
            // 
            // btnZakljucaj
            // 
            this.btnZakljucaj.Location = new System.Drawing.Point(432, 152);
            this.btnZakljucaj.Name = "btnZakljucaj";
            this.btnZakljucaj.Size = new System.Drawing.Size(170, 34);
            this.btnZakljucaj.TabIndex = 6;
            this.btnZakljucaj.Text = "Zaključaj nalog";
            this.btnZakljucaj.UseVisualStyleBackColor = true;
            this.btnZakljucaj.Click += new System.EventHandler(this.btnZakljucaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opis radnog naloga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum kreiranja:";
            // 
            // gbPredajaUProizvodnju
            // 
            this.gbPredajaUProizvodnju.Controls.Add(this.dtpDatumPredaje);
            this.gbPredajaUProizvodnju.Controls.Add(this.label5);
            this.gbPredajaUProizvodnju.Controls.Add(this.btnPredajNalog);
            this.gbPredajaUProizvodnju.Location = new System.Drawing.Point(12, 220);
            this.gbPredajaUProizvodnju.Name = "gbPredajaUProizvodnju";
            this.gbPredajaUProizvodnju.Size = new System.Drawing.Size(220, 136);
            this.gbPredajaUProizvodnju.TabIndex = 3;
            this.gbPredajaUProizvodnju.TabStop = false;
            this.gbPredajaUProizvodnju.Text = "Predaja naloga u proizvodnju:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Datum predaje:";
            // 
            // btnPredajNalog
            // 
            this.btnPredajNalog.Location = new System.Drawing.Point(20, 79);
            this.btnPredajNalog.Name = "btnPredajNalog";
            this.btnPredajNalog.Size = new System.Drawing.Size(170, 34);
            this.btnPredajNalog.TabIndex = 7;
            this.btnPredajNalog.Text = "Predaj nalog";
            this.btnPredajNalog.UseVisualStyleBackColor = true;
            this.btnPredajNalog.Click += new System.EventHandler(this.btnPredajNalog_Click);
            // 
            // gbProizvodnja
            // 
            this.gbProizvodnja.Controls.Add(this.dtpDatumDovrsetka);
            this.gbProizvodnja.Controls.Add(this.label4);
            this.gbProizvodnja.Controls.Add(this.dtpDatumPocetka);
            this.gbProizvodnja.Controls.Add(this.label6);
            this.gbProizvodnja.Controls.Add(this.btnZapocniProizvodnju);
            this.gbProizvodnja.Controls.Add(this.btnDovrsiProizvodnju);
            this.gbProizvodnja.Location = new System.Drawing.Point(238, 220);
            this.gbProizvodnja.Name = "gbProizvodnja";
            this.gbProizvodnja.Size = new System.Drawing.Size(393, 136);
            this.gbProizvodnja.TabIndex = 10;
            this.gbProizvodnja.TabStop = false;
            this.gbProizvodnja.Text = "Proizvodnja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Datum početka:";
            // 
            // btnZapocniProizvodnju
            // 
            this.btnZapocniProizvodnju.Location = new System.Drawing.Point(21, 74);
            this.btnZapocniProizvodnju.Name = "btnZapocniProizvodnju";
            this.btnZapocniProizvodnju.Size = new System.Drawing.Size(170, 37);
            this.btnZapocniProizvodnju.TabIndex = 7;
            this.btnZapocniProizvodnju.Text = "Započni proizvodnju";
            this.btnZapocniProizvodnju.UseVisualStyleBackColor = true;
            this.btnZapocniProizvodnju.Click += new System.EventHandler(this.btnZapocniProizvodnju_Click);
            // 
            // btnDovrsiProizvodnju
            // 
            this.btnDovrsiProizvodnju.Location = new System.Drawing.Point(206, 74);
            this.btnDovrsiProizvodnju.Name = "btnDovrsiProizvodnju";
            this.btnDovrsiProizvodnju.Size = new System.Drawing.Size(169, 34);
            this.btnDovrsiProizvodnju.TabIndex = 7;
            this.btnDovrsiProizvodnju.Text = "Dovrši proizvodnju";
            this.btnDovrsiProizvodnju.UseVisualStyleBackColor = true;
            this.btnDovrsiProizvodnju.Click += new System.EventHandler(this.btnDovrsiProizvodnju_Click);
            // 
            // btnOtkaziNalog
            // 
            this.btnOtkaziNalog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOtkaziNalog.Location = new System.Drawing.Point(257, 152);
            this.btnOtkaziNalog.Name = "btnOtkaziNalog";
            this.btnOtkaziNalog.Size = new System.Drawing.Size(169, 34);
            this.btnOtkaziNalog.TabIndex = 10;
            this.btnOtkaziNalog.Text = "Otkaži nalog";
            this.btnOtkaziNalog.UseVisualStyleBackColor = false;
            this.btnOtkaziNalog.Click += new System.EventHandler(this.btnOtkaziNalog_Click);
            // 
            // dtpDatumPredaje
            // 
            this.dtpDatumPredaje.Location = new System.Drawing.Point(20, 51);
            this.dtpDatumPredaje.Name = "dtpDatumPredaje";
            this.dtpDatumPredaje.Size = new System.Drawing.Size(170, 22);
            this.dtpDatumPredaje.TabIndex = 12;
            // 
            // txtDatumKreiranja
            // 
            this.txtDatumKreiranja.Enabled = false;
            this.txtDatumKreiranja.Location = new System.Drawing.Point(21, 46);
            this.txtDatumKreiranja.Name = "txtDatumKreiranja";
            this.txtDatumKreiranja.Size = new System.Drawing.Size(169, 22);
            this.txtDatumKreiranja.TabIndex = 3;
            // 
            // dtpDatumPocetka
            // 
            this.dtpDatumPocetka.Location = new System.Drawing.Point(20, 46);
            this.dtpDatumPocetka.Name = "dtpDatumPocetka";
            this.dtpDatumPocetka.Size = new System.Drawing.Size(170, 22);
            this.dtpDatumPocetka.TabIndex = 13;
            // 
            // dtpDatumDovrsetka
            // 
            this.dtpDatumDovrsetka.Location = new System.Drawing.Point(205, 46);
            this.dtpDatumDovrsetka.Name = "dtpDatumDovrsetka";
            this.dtpDatumDovrsetka.Size = new System.Drawing.Size(170, 22);
            this.dtpDatumDovrsetka.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Datum početka:";
            // 
            // RadniNalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 368);
            this.Controls.Add(this.gbProizvodnja);
            this.Controls.Add(this.gbPredajaUProizvodnju);
            this.Controls.Add(this.gbPodaciNaloga);
            this.Name = "RadniNalogForm";
            this.Text = "Radni nalog";
            this.Load += new System.EventHandler(this.RadniNalogForm_Load);
            this.gbPodaciNaloga.ResumeLayout(false);
            this.gbPodaciNaloga.PerformLayout();
            this.gbPredajaUProizvodnju.ResumeLayout(false);
            this.gbPredajaUProizvodnju.PerformLayout();
            this.gbProizvodnja.ResumeLayout(false);
            this.gbProizvodnja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPodaciNaloga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZakljucaj;
        private System.Windows.Forms.GroupBox gbPredajaUProizvodnju;
        private System.Windows.Forms.Button btnPredajNalog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbProizvodnja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnZapocniProizvodnju;
        private System.Windows.Forms.Button btnDovrsiProizvodnju;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOtkaziNalog;
        private System.Windows.Forms.TextBox txtDatumKreiranja;
        private System.Windows.Forms.DateTimePicker dtpDatumPredaje;
        private System.Windows.Forms.DateTimePicker dtpDatumDovrsetka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetka;
    }
}

