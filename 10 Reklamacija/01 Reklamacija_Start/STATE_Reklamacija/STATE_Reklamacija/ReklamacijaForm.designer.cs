namespace STATE_Reklamacija
{
    partial class ReklamacijaForm
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
            this.txtIdReklamacije = new System.Windows.Forms.TextBox();
            this.txtOpisReklamacije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodijeliAgenta = new System.Windows.Forms.Button();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOcijeni = new System.Windows.Forms.Button();
            this.rbNeutemeljen = new System.Windows.Forms.RadioButton();
            this.radOpravdana = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnObradiŽalbu = new System.Windows.Forms.Button();
            this.rbNijePristigla = new System.Windows.Forms.RadioButton();
            this.rbPristigla = new System.Windows.Forms.RadioButton();
            this.txtStatusReklamacije = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id reklamacije:";
            // 
            // txtIdReklamacije
            // 
            this.txtIdReklamacije.Enabled = false;
            this.txtIdReklamacije.Location = new System.Drawing.Point(106, 23);
            this.txtIdReklamacije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdReklamacije.Name = "txtIdReklamacije";
            this.txtIdReklamacije.Size = new System.Drawing.Size(130, 20);
            this.txtIdReklamacije.TabIndex = 1;
            // 
            // txtOpisReklamacije
            // 
            this.txtOpisReklamacije.Enabled = false;
            this.txtOpisReklamacije.Location = new System.Drawing.Point(106, 56);
            this.txtOpisReklamacije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpisReklamacije.Multiline = true;
            this.txtOpisReklamacije.Name = "txtOpisReklamacije";
            this.txtOpisReklamacije.Size = new System.Drawing.Size(428, 69);
            this.txtOpisReklamacije.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis reklamacije:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodijeliAgenta);
            this.groupBox1.Controls.Add(this.txtAgent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(186, 104);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent:";
            // 
            // btnDodijeliAgenta
            // 
            this.btnDodijeliAgenta.Location = new System.Drawing.Point(48, 64);
            this.btnDodijeliAgenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodijeliAgenta.Name = "btnDodijeliAgenta";
            this.btnDodijeliAgenta.Size = new System.Drawing.Size(105, 26);
            this.btnDodijeliAgenta.TabIndex = 7;
            this.btnDodijeliAgenta.Text = "Dodijeli agenta";
            this.btnDodijeliAgenta.UseVisualStyleBackColor = true;
            this.btnDodijeliAgenta.Click += new System.EventHandler(this.btnDodijeliAgenta_Click);
            // 
            // txtAgent
            // 
            this.txtAgent.Location = new System.Drawing.Point(23, 40);
            this.txtAgent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(130, 20);
            this.txtAgent.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ime i prezime:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOcijeni);
            this.groupBox2.Controls.Add(this.rbNeutemeljen);
            this.groupBox2.Controls.Add(this.radOpravdana);
            this.groupBox2.Location = new System.Drawing.Point(211, 213);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(179, 104);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Obrada reklamacije:";
            // 
            // btnOcijeni
            // 
            this.btnOcijeni.Location = new System.Drawing.Point(23, 64);
            this.btnOcijeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOcijeni.Name = "btnOcijeni";
            this.btnOcijeni.Size = new System.Drawing.Size(105, 26);
            this.btnOcijeni.TabIndex = 8;
            this.btnOcijeni.Text = "Ocijeni";
            this.btnOcijeni.UseVisualStyleBackColor = true;
            this.btnOcijeni.Click += new System.EventHandler(this.btnOcijeni_Click);
            // 
            // rbNeutemeljen
            // 
            this.rbNeutemeljen.AutoSize = true;
            this.rbNeutemeljen.Location = new System.Drawing.Point(23, 42);
            this.rbNeutemeljen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNeutemeljen.Name = "rbNeutemeljen";
            this.rbNeutemeljen.Size = new System.Drawing.Size(90, 17);
            this.rbNeutemeljen.TabIndex = 1;
            this.rbNeutemeljen.TabStop = true;
            this.rbNeutemeljen.Text = "Neopravdana";
            this.rbNeutemeljen.UseVisualStyleBackColor = true;
            // 
            // radOpravdana
            // 
            this.radOpravdana.AutoSize = true;
            this.radOpravdana.Location = new System.Drawing.Point(23, 21);
            this.radOpravdana.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radOpravdana.Name = "radOpravdana";
            this.radOpravdana.Size = new System.Drawing.Size(78, 17);
            this.radOpravdana.TabIndex = 0;
            this.radOpravdana.TabStop = true;
            this.radOpravdana.Text = "Opravdana";
            this.radOpravdana.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnObradiŽalbu);
            this.groupBox3.Controls.Add(this.rbNijePristigla);
            this.groupBox3.Controls.Add(this.rbPristigla);
            this.groupBox3.Location = new System.Drawing.Point(406, 213);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(168, 104);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Žalba:";
            // 
            // btnObradiŽalbu
            // 
            this.btnObradiŽalbu.Location = new System.Drawing.Point(24, 64);
            this.btnObradiŽalbu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObradiŽalbu.Name = "btnObradiŽalbu";
            this.btnObradiŽalbu.Size = new System.Drawing.Size(105, 26);
            this.btnObradiŽalbu.TabIndex = 8;
            this.btnObradiŽalbu.Text = "Obradi";
            this.btnObradiŽalbu.UseVisualStyleBackColor = true;
            this.btnObradiŽalbu.Click += new System.EventHandler(this.btnObradiŽalbu_Click);
            // 
            // rbNijePristigla
            // 
            this.rbNijePristigla.AutoSize = true;
            this.rbNijePristigla.Location = new System.Drawing.Point(24, 40);
            this.rbNijePristigla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNijePristigla.Name = "rbNijePristigla";
            this.rbNijePristigla.Size = new System.Drawing.Size(81, 17);
            this.rbNijePristigla.TabIndex = 1;
            this.rbNijePristigla.TabStop = true;
            this.rbNijePristigla.Text = "Nije pristigla";
            this.rbNijePristigla.UseVisualStyleBackColor = true;
            // 
            // rbPristigla
            // 
            this.rbPristigla.AutoSize = true;
            this.rbPristigla.Location = new System.Drawing.Point(24, 21);
            this.rbPristigla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPristigla.Name = "rbPristigla";
            this.rbPristigla.Size = new System.Drawing.Size(61, 17);
            this.rbPristigla.TabIndex = 0;
            this.rbPristigla.TabStop = true;
            this.rbPristigla.Text = "Pristigla";
            this.rbPristigla.UseVisualStyleBackColor = true;
            // 
            // txtStatusReklamacije
            // 
            this.txtStatusReklamacije.Enabled = false;
            this.txtStatusReklamacije.Location = new System.Drawing.Point(106, 135);
            this.txtStatusReklamacije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatusReklamacije.Name = "txtStatusReklamacije";
            this.txtStatusReklamacije.Size = new System.Drawing.Size(130, 20);
            this.txtStatusReklamacije.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtStatusReklamacije);
            this.groupBox4.Controls.Add(this.txtIdReklamacije);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtOpisReklamacije);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 185);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Osnovne informacije:";
            // 
            // ReklamacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 341);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReklamacijaForm";
            this.Text = "Reklamacija";
            this.Load += new System.EventHandler(this.ReklamacijaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdReklamacije;
        private System.Windows.Forms.TextBox txtOpisReklamacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodijeliAgenta;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOcijeni;
        private System.Windows.Forms.RadioButton rbNeutemeljen;
        private System.Windows.Forms.RadioButton radOpravdana;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnObradiŽalbu;
        private System.Windows.Forms.RadioButton rbNijePristigla;
        private System.Windows.Forms.RadioButton rbPristigla;
        private System.Windows.Forms.TextBox txtStatusReklamacije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

