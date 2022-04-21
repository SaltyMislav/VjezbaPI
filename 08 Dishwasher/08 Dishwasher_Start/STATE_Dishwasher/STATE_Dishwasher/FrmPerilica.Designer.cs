
namespace STATE_Dishwasher
{
    partial class FrmPerilica
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
            this.btn60min = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPauzirajNastavi = new System.Windows.Forms.Button();
            this.btn90min = new System.Windows.Forms.Button();
            this.btn120min = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPranjeZavrsilo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Courier New", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Maroon;
            this.txtStatus.Location = new System.Drawing.Point(191, 18);
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
            // btn60min
            // 
            this.btn60min.BackColor = System.Drawing.SystemColors.Control;
            this.btn60min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn60min.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn60min.Location = new System.Drawing.Point(140, 29);
            this.btn60min.Name = "btn60min";
            this.btn60min.Size = new System.Drawing.Size(75, 47);
            this.btn60min.TabIndex = 2;
            this.btn60min.Text = "Program\r\n60 min";
            this.btn60min.UseVisualStyleBackColor = false;
            this.btn60min.Click += new System.EventHandler(this.btn60min_Click);
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
            // btnPauzirajNastavi
            // 
            this.btnPauzirajNastavi.BackColor = System.Drawing.SystemColors.Control;
            this.btnPauzirajNastavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauzirajNastavi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPauzirajNastavi.Location = new System.Drawing.Point(503, 29);
            this.btnPauzirajNastavi.Name = "btnPauzirajNastavi";
            this.btnPauzirajNastavi.Size = new System.Drawing.Size(75, 47);
            this.btnPauzirajNastavi.TabIndex = 4;
            this.btnPauzirajNastavi.Text = "Pauziraj\r\n/Nastavi";
            this.btnPauzirajNastavi.UseVisualStyleBackColor = false;
            this.btnPauzirajNastavi.Click += new System.EventHandler(this.btnPauzirajNastavi_Click);
            // 
            // btn90min
            // 
            this.btn90min.BackColor = System.Drawing.SystemColors.Control;
            this.btn90min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn90min.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn90min.Location = new System.Drawing.Point(221, 29);
            this.btn90min.Name = "btn90min";
            this.btn90min.Size = new System.Drawing.Size(75, 47);
            this.btn90min.TabIndex = 5;
            this.btn90min.Text = "Program\r\n90 min";
            this.btn90min.UseVisualStyleBackColor = false;
            this.btn90min.Click += new System.EventHandler(this.btn90min_Click);
            // 
            // btn120min
            // 
            this.btn120min.BackColor = System.Drawing.SystemColors.Control;
            this.btn120min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn120min.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn120min.Location = new System.Drawing.Point(302, 29);
            this.btn120min.Name = "btn120min";
            this.btn120min.Size = new System.Drawing.Size(75, 47);
            this.btn120min.TabIndex = 6;
            this.btn120min.Text = "Program\r\n120 min";
            this.btn120min.UseVisualStyleBackColor = false;
            this.btn120min.Click += new System.EventHandler(this.btn120min_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPranjeZavrsilo);
            this.groupBox1.Controls.Add(this.btnPauzirajNastavi);
            this.groupBox1.Controls.Add(this.btn120min);
            this.groupBox1.Controls.Add(this.btnOnOff);
            this.groupBox1.Controls.Add(this.btn90min);
            this.groupBox1.Controls.Add(this.btn60min);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije:";
            // 
            // btnPranjeZavrsilo
            // 
            this.btnPranjeZavrsilo.BackColor = System.Drawing.SystemColors.Control;
            this.btnPranjeZavrsilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPranjeZavrsilo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPranjeZavrsilo.Location = new System.Drawing.Point(584, 29);
            this.btnPranjeZavrsilo.Name = "btnPranjeZavrsilo";
            this.btnPranjeZavrsilo.Size = new System.Drawing.Size(75, 47);
            this.btnPranjeZavrsilo.TabIndex = 7;
            this.btnPranjeZavrsilo.Text = "Pranje\r\nzavršilo";
            this.btnPranjeZavrsilo.UseVisualStyleBackColor = false;
            this.btnPranjeZavrsilo.Click += new System.EventHandler(this.btnPranjeZavrsilo_Click);
            // 
            // FrmPerilica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 183);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStatus);
            this.Name = "FrmPerilica";
            this.Text = "Perilica";
            this.Load += new System.EventHandler(this.FrmPerilica_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Button btn60min;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPauzirajNastavi;
        private System.Windows.Forms.Button btn90min;
        private System.Windows.Forms.Button btn120min;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPranjeZavrsilo;
    }
}

