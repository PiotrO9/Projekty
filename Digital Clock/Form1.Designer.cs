namespace Digital_Clock
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDayName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblHM = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblStoperTime = new System.Windows.Forms.Label();
            this.btnStartOrStop = new System.Windows.Forms.Button();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lstOfMesurement = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSecounds = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 289);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.lblDayName);
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.lblS);
            this.tabPage1.Controls.Add(this.lblHM);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clock";
            // 
            // lblDayName
            // 
            this.lblDayName.AutoSize = true;
            this.lblDayName.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayName.ForeColor = System.Drawing.Color.White;
            this.lblDayName.Location = new System.Drawing.Point(340, 160);
            this.lblDayName.Name = "lblDayName";
            this.lblDayName.Size = new System.Drawing.Size(168, 65);
            this.lblDayName.TabIndex = 7;
            this.lblDayName.Text = "Friday";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(50, 146);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(203, 65);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "JUNE 13";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.Color.White;
            this.lblS.Location = new System.Drawing.Point(334, 81);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(56, 45);
            this.lblS.TabIndex = 5;
            this.lblS.Text = "11";
            // 
            // lblHM
            // 
            this.lblHM.AutoSize = true;
            this.lblHM.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHM.ForeColor = System.Drawing.Color.White;
            this.lblHM.Location = new System.Drawing.Point(153, 27);
            this.lblHM.Name = "lblHM";
            this.lblHM.Size = new System.Drawing.Size(202, 86);
            this.lblHM.TabIndex = 4;
            this.lblHM.Text = "11.11";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btnRestart);
            this.tabPage2.Controls.Add(this.btnMeasure);
            this.tabPage2.Controls.Add(this.btnStartOrStop);
            this.tabPage2.Controls.Add(this.lstOfMesurement);
            this.tabPage2.Controls.Add(this.lblStoperTime);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stoper";
            // 
            // lblStoperTime
            // 
            this.lblStoperTime.AutoSize = true;
            this.lblStoperTime.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoperTime.ForeColor = System.Drawing.Color.White;
            this.lblStoperTime.Location = new System.Drawing.Point(35, 76);
            this.lblStoperTime.Name = "lblStoperTime";
            this.lblStoperTime.Size = new System.Drawing.Size(293, 86);
            this.lblStoperTime.TabIndex = 5;
            this.lblStoperTime.Text = "00:00:00";
            // 
            // btnStartOrStop
            // 
            this.btnStartOrStop.Location = new System.Drawing.Point(50, 180);
            this.btnStartOrStop.Name = "btnStartOrStop";
            this.btnStartOrStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartOrStop.TabIndex = 7;
            this.btnStartOrStop.Text = "Start";
            this.btnStartOrStop.UseVisualStyleBackColor = true;
            this.btnStartOrStop.Click += new System.EventHandler(this.btnStartOrStop_Click);
            // 
            // btnMeasure
            // 
            this.btnMeasure.Location = new System.Drawing.Point(140, 180);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(75, 23);
            this.btnMeasure.TabIndex = 8;
            this.btnMeasure.Text = "Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(232, 180);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lstOfMesurement
            // 
            this.lstOfMesurement.FormattingEnabled = true;
            this.lstOfMesurement.Location = new System.Drawing.Point(389, 17);
            this.lstOfMesurement.Name = "lstOfMesurement";
            this.lstOfMesurement.Size = new System.Drawing.Size(141, 225);
            this.lstOfMesurement.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.btnAccept);
            this.tabPage3.Controls.Add(this.txtS);
            this.tabPage3.Controls.Add(this.txtM);
            this.tabPage3.Controls.Add(this.lblSecounds);
            this.tabPage3.Controls.Add(this.lblMin);
            this.tabPage3.Controls.Add(this.lblTimer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(541, 263);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Timer";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(166, 154);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(199, 73);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(176, 36);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(38, 13);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Minuts";
            // 
            // lblSecounds
            // 
            this.lblSecounds.AutoSize = true;
            this.lblSecounds.ForeColor = System.Drawing.Color.White;
            this.lblSecounds.Location = new System.Drawing.Point(283, 36);
            this.lblSecounds.Name = "lblSecounds";
            this.lblSecounds.Size = new System.Drawing.Size(55, 13);
            this.lblSecounds.TabIndex = 2;
            this.lblSecounds.Text = "Secounds";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(150, 52);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 3;
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(265, 52);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 20);
            this.txtS.TabIndex = 4;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(213, 95);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(102, 45);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Start";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(543, 285);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Digital Clock";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDayName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblHM;
        private System.Windows.Forms.Button btnStartOrStop;
        private System.Windows.Forms.Label lblStoperTime;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox lstOfMesurement;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lblSecounds;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer3;
    }
}

