
namespace STATE_Oven
{
    partial class FrmPecnica
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.btn150C = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnIstekloVrijeme = new System.Windows.Forms.Button();
            this.btn180C = new System.Windows.Forms.Button();
            this.btn200C = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOhladiPecnicu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Courier New", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Maroon;
            this.txtStatus.Location = new System.Drawing.Point(213, 18);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(318, 47);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOnOff
            // 
            this.btnOnOff.BackColor = System.Drawing.SystemColors.Control;
            this.btnOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOnOff.Location = new System.Drawing.Point(20, 29);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(75, 47);
            this.btnOnOff.TabIndex = 1;
            this.btnOnOff.Text = "On/Off";
            this.btnOnOff.UseVisualStyleBackColor = false;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btn150C
            // 
            this.btn150C.BackColor = System.Drawing.SystemColors.Control;
            this.btn150C.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn150C.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn150C.Location = new System.Drawing.Point(140, 29);
            this.btn150C.Name = "btn150C";
            this.btn150C.Size = new System.Drawing.Size(75, 47);
            this.btn150C.TabIndex = 2;
            this.btn150C.Text = "Program\r\n150°C";
            this.btn150C.UseVisualStyleBackColor = false;
            this.btn150C.Click += new System.EventHandler(this.btn150C_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(422, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 47);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnIstekloVrijeme
            // 
            this.btnIstekloVrijeme.BackColor = System.Drawing.SystemColors.Control;
            this.btnIstekloVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIstekloVrijeme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIstekloVrijeme.Location = new System.Drawing.Point(503, 29);
            this.btnIstekloVrijeme.Name = "btnIstekloVrijeme";
            this.btnIstekloVrijeme.Size = new System.Drawing.Size(75, 47);
            this.btnIstekloVrijeme.TabIndex = 4;
            this.btnIstekloVrijeme.Text = "Isteklo vrijeme";
            this.btnIstekloVrijeme.UseVisualStyleBackColor = false;
            this.btnIstekloVrijeme.Click += new System.EventHandler(this.btnIstekloVrijeme_Click);
            // 
            // btn180C
            // 
            this.btn180C.BackColor = System.Drawing.SystemColors.Control;
            this.btn180C.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn180C.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn180C.Location = new System.Drawing.Point(221, 29);
            this.btn180C.Name = "btn180C";
            this.btn180C.Size = new System.Drawing.Size(75, 47);
            this.btn180C.TabIndex = 5;
            this.btn180C.Text = "Program\r\n180°C";
            this.btn180C.UseVisualStyleBackColor = false;
            this.btn180C.Click += new System.EventHandler(this.btn180C_Click);
            // 
            // btn200C
            // 
            this.btn200C.BackColor = System.Drawing.SystemColors.Control;
            this.btn200C.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200C.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn200C.Location = new System.Drawing.Point(302, 29);
            this.btn200C.Name = "btn200C";
            this.btn200C.Size = new System.Drawing.Size(75, 47);
            this.btn200C.TabIndex = 6;
            this.btn200C.Text = "Program\r\n200°C\r\n";
            this.btn200C.UseVisualStyleBackColor = false;
            this.btn200C.Click += new System.EventHandler(this.btn200C_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOhladiPecnicu);
            this.groupBox1.Controls.Add(this.btnIstekloVrijeme);
            this.groupBox1.Controls.Add(this.btn200C);
            this.groupBox1.Controls.Add(this.btnOnOff);
            this.groupBox1.Controls.Add(this.btn180C);
            this.groupBox1.Controls.Add(this.btn150C);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije:";
            // 
            // btnOhladiPecnicu
            // 
            this.btnOhladiPecnicu.BackColor = System.Drawing.SystemColors.Control;
            this.btnOhladiPecnicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOhladiPecnicu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOhladiPecnicu.Location = new System.Drawing.Point(584, 29);
            this.btnOhladiPecnicu.Name = "btnOhladiPecnicu";
            this.btnOhladiPecnicu.Size = new System.Drawing.Size(75, 47);
            this.btnOhladiPecnicu.TabIndex = 7;
            this.btnOhladiPecnicu.Text = "Ohladi \r\npečnicu";
            this.btnOhladiPecnicu.UseVisualStyleBackColor = false;
            this.btnOhladiPecnicu.Click += new System.EventHandler(this.btnOhladiPecnicu_Click);
            // 
            // FrmPecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 183);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStatus);
            this.Name = "FrmPecnica";
            this.Text = "Pecnica";
            this.Load += new System.EventHandler(this.FrmPerilica_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Button btn150C;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnIstekloVrijeme;
        private System.Windows.Forms.Button btn180C;
        private System.Windows.Forms.Button btn200C;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOhladiPecnicu;
    }
}

