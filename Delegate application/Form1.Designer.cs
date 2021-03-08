namespace Delegate_application
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
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.btnAD = new System.Windows.Forms.Button();
            this.btnSUB = new System.Windows.Forms.Button();
            this.btnDIV = new System.Windows.Forms.Button();
            this.tbnMUL = new System.Windows.Forms.Button();
            this.btnCLR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(41, 34);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(184, 20);
            this.txtbox1.TabIndex = 0;
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(41, 101);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(184, 20);
            this.txtbox2.TabIndex = 1;
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(41, 164);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(184, 20);
            this.txtbox3.TabIndex = 2;
            // 
            // btnAD
            // 
            this.btnAD.Location = new System.Drawing.Point(41, 208);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(84, 23);
            this.btnAD.TabIndex = 3;
            this.btnAD.Text = "Addict";
            this.btnAD.UseVisualStyleBackColor = true;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // btnSUB
            // 
            this.btnSUB.Location = new System.Drawing.Point(144, 208);
            this.btnSUB.Name = "btnSUB";
            this.btnSUB.Size = new System.Drawing.Size(81, 23);
            this.btnSUB.TabIndex = 4;
            this.btnSUB.Text = "Subtract";
            this.btnSUB.UseVisualStyleBackColor = true;
            this.btnSUB.Click += new System.EventHandler(this.btnSUB_Click);
            // 
            // btnDIV
            // 
            this.btnDIV.Location = new System.Drawing.Point(144, 255);
            this.btnDIV.Name = "btnDIV";
            this.btnDIV.Size = new System.Drawing.Size(81, 23);
            this.btnDIV.TabIndex = 6;
            this.btnDIV.Text = "Diverse";
            this.btnDIV.UseVisualStyleBackColor = true;
            this.btnDIV.Click += new System.EventHandler(this.btnDIV_Click);
            // 
            // tbnMUL
            // 
            this.tbnMUL.Location = new System.Drawing.Point(41, 255);
            this.tbnMUL.Name = "tbnMUL";
            this.tbnMUL.Size = new System.Drawing.Size(84, 23);
            this.tbnMUL.TabIndex = 5;
            this.tbnMUL.Text = "Multiply";
            this.tbnMUL.UseVisualStyleBackColor = true;
            this.tbnMUL.Click += new System.EventHandler(this.tbnMUL_Click);
            // 
            // btnCLR
            // 
            this.btnCLR.Location = new System.Drawing.Point(41, 293);
            this.btnCLR.Name = "btnCLR";
            this.btnCLR.Size = new System.Drawing.Size(184, 23);
            this.btnCLR.TabIndex = 7;
            this.btnCLR.Text = "Clear";
            this.btnCLR.UseVisualStyleBackColor = true;
            this.btnCLR.Click += new System.EventHandler(this.btnCLR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 345);
            this.Controls.Add(this.btnCLR);
            this.Controls.Add(this.btnDIV);
            this.Controls.Add(this.tbnMUL);
            this.Controls.Add(this.btnSUB);
            this.Controls.Add(this.btnAD);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Name = "Form1";
            this.Text = "Calculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.TextBox txtbox3;
        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.Button btnSUB;
        private System.Windows.Forms.Button btnDIV;
        private System.Windows.Forms.Button tbnMUL;
        private System.Windows.Forms.Button btnCLR;
    }
}

