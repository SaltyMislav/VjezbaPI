namespace Bankomat
{
    partial class frmBankomat
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
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblIspravanPIN = new System.Windows.Forms.Label();
            this.lblIspravanPIN2 = new System.Windows.Forms.Label();
            this.lblStanje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaxIznos = new System.Windows.Forms.Label();
            this.lblMaxIznos2 = new System.Windows.Forms.Label();
            this.btnKartica = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.btnIznos = new System.Windows.Forms.Button();
            this.lblIznos = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIsplati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(232, 177);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(104, 26);
            this.txtPin.TabIndex = 0;
            this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(228, 154);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(80, 20);
            this.lblPin.TabIndex = 1;
            this.lblPin.Text = "Unesi PIN";
            // 
            // lblIspravanPIN
            // 
            this.lblIspravanPIN.AutoSize = true;
            this.lblIspravanPIN.Location = new System.Drawing.Point(43, 282);
            this.lblIspravanPIN.Name = "lblIspravanPIN";
            this.lblIspravanPIN.Size = new System.Drawing.Size(100, 20);
            this.lblIspravanPIN.TabIndex = 2;
            this.lblIspravanPIN.Text = "Ispravan PIN";
            // 
            // lblIspravanPIN2
            // 
            this.lblIspravanPIN2.BackColor = System.Drawing.SystemColors.Control;
            this.lblIspravanPIN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIspravanPIN2.ForeColor = System.Drawing.Color.Red;
            this.lblIspravanPIN2.Location = new System.Drawing.Point(4, 307);
            this.lblIspravanPIN2.Name = "lblIspravanPIN2";
            this.lblIspravanPIN2.Size = new System.Drawing.Size(183, 29);
            this.lblIspravanPIN2.TabIndex = 3;
            this.lblIspravanPIN2.Text = "0000";
            this.lblIspravanPIN2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStanje
            // 
            this.lblStanje.BackColor = System.Drawing.SystemColors.Control;
            this.lblStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStanje.ForeColor = System.Drawing.Color.Red;
            this.lblStanje.Location = new System.Drawing.Point(248, 58);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(316, 46);
            this.lblStanje.TabIndex = 3;
            this.lblStanje.Text = "Mirovanje";
            this.lblStanje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trenutno stanje";
            // 
            // lblMaxIznos
            // 
            this.lblMaxIznos.AutoSize = true;
            this.lblMaxIznos.Location = new System.Drawing.Point(34, 350);
            this.lblMaxIznos.Name = "lblMaxIznos";
            this.lblMaxIznos.Size = new System.Drawing.Size(124, 20);
            this.lblMaxIznos.TabIndex = 2;
            this.lblMaxIznos.Text = "Trenutno stanje:";
            // 
            // lblMaxIznos2
            // 
            this.lblMaxIznos2.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaxIznos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaxIznos2.ForeColor = System.Drawing.Color.Red;
            this.lblMaxIznos2.Location = new System.Drawing.Point(3, 370);
            this.lblMaxIznos2.Name = "lblMaxIznos2";
            this.lblMaxIznos2.Size = new System.Drawing.Size(179, 29);
            this.lblMaxIznos2.TabIndex = 3;
            this.lblMaxIznos2.Text = "1000 kn";
            this.lblMaxIznos2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnKartica
            // 
            this.btnKartica.Enabled = false;
            this.btnKartica.Location = new System.Drawing.Point(38, 150);
            this.btnKartica.Name = "btnKartica";
            this.btnKartica.Size = new System.Drawing.Size(130, 53);
            this.btnKartica.TabIndex = 4;
            this.btnKartica.Text = "UNESI KARTICU";
            this.btnKartica.UseVisualStyleBackColor = true;
            this.btnKartica.Click += new System.EventHandler(this.btnKartica_Click);
            // 
            // btnPin
            // 
            this.btnPin.Enabled = false;
            this.btnPin.Location = new System.Drawing.Point(342, 150);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(130, 53);
            this.btnPin.TabIndex = 4;
            this.btnPin.Text = "UNESI PIN";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(532, 177);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(104, 26);
            this.txtIznos.TabIndex = 0;
            this.txtIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIznos.TextChanged += new System.EventHandler(this.txtIznos_TextChanged);
            // 
            // btnIznos
            // 
            this.btnIznos.Enabled = false;
            this.btnIznos.Location = new System.Drawing.Point(642, 150);
            this.btnIznos.Name = "btnIznos";
            this.btnIznos.Size = new System.Drawing.Size(130, 53);
            this.btnIznos.TabIndex = 4;
            this.btnIznos.Text = "UNESI  IZNOS";
            this.btnIznos.UseVisualStyleBackColor = true;
            this.btnIznos.Click += new System.EventHandler(this.btnIznos_Click);
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(528, 154);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(91, 20);
            this.lblIznos.TabIndex = 1;
            this.lblIznos.Text = "Unesi iznos";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Enabled = false;
            this.btnOdustani.Location = new System.Drawing.Point(342, 225);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(130, 53);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIsplati
            // 
            this.btnIsplati.Enabled = false;
            this.btnIsplati.Location = new System.Drawing.Point(642, 225);
            this.btnIsplati.Name = "btnIsplati";
            this.btnIsplati.Size = new System.Drawing.Size(130, 53);
            this.btnIsplati.TabIndex = 4;
            this.btnIsplati.Text = "ISPLATI GOTOVINU";
            this.btnIsplati.UseVisualStyleBackColor = true;
            this.btnIsplati.Click += new System.EventHandler(this.btnIsplati_Click);
            // 
            // frmBankomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIznos);
            this.Controls.Add(this.btnIsplati);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.btnKartica);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMaxIznos2);
            this.Controls.Add(this.lblIspravanPIN2);
            this.Controls.Add(this.lblMaxIznos);
            this.Controls.Add(this.lblIspravanPIN);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.txtPin);
            this.Name = "frmBankomat";
            this.Text = "Bankomat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblIspravanPIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaxIznos;
        public System.Windows.Forms.TextBox txtPin;
        public System.Windows.Forms.Label lblIspravanPIN2;
        public System.Windows.Forms.Label lblStanje;
        public System.Windows.Forms.Label lblMaxIznos2;
        public System.Windows.Forms.Button btnKartica;
        public System.Windows.Forms.Button btnPin;
        public System.Windows.Forms.TextBox txtIznos;
        public System.Windows.Forms.Button btnIznos;
        private System.Windows.Forms.Label lblIznos;
        public System.Windows.Forms.Button btnOdustani;
        public System.Windows.Forms.Button btnIsplati;
    }
}

