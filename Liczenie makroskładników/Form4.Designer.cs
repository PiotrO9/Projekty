
namespace Liczenie_makroskładników
{
    partial class Form4
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.txtBoxT = new System.Windows.Forms.TextBox();
            this.txtBoxW = new System.Windows.Forms.TextBox();
            this.txtBoxKcal = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblKcal = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(122, 146);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Dodaj";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(30, 49);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(36, 20);
            this.txtBoxB.TabIndex = 1;
            this.txtBoxB.TextChanged += new System.EventHandler(this.txtBoxB_TextChanged);
            // 
            // txtBoxT
            // 
            this.txtBoxT.Location = new System.Drawing.Point(83, 49);
            this.txtBoxT.Name = "txtBoxT";
            this.txtBoxT.Size = new System.Drawing.Size(36, 20);
            this.txtBoxT.TabIndex = 2;
            // 
            // txtBoxW
            // 
            this.txtBoxW.Location = new System.Drawing.Point(185, 49);
            this.txtBoxW.Name = "txtBoxW";
            this.txtBoxW.Size = new System.Drawing.Size(36, 20);
            this.txtBoxW.TabIndex = 3;
            // 
            // txtBoxKcal
            // 
            this.txtBoxKcal.Location = new System.Drawing.Point(239, 49);
            this.txtBoxKcal.Name = "txtBoxKcal";
            this.txtBoxKcal.ReadOnly = true;
            this.txtBoxKcal.Size = new System.Drawing.Size(36, 20);
            this.txtBoxKcal.TabIndex = 4;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(27, 22);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(38, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "Białka";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(80, 22);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(51, 13);
            this.lblT.TabIndex = 6;
            this.lblT.Text = "Tłuszcze";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(166, 22);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(75, 13);
            this.lblW.TabIndex = 7;
            this.lblW.Text = "Węglowodany";
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.Location = new System.Drawing.Point(247, 22);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(28, 13);
            this.lblKcal.TabIndex = 8;
            this.lblKcal.Text = "Kcal";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(30, 112);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(90, 20);
            this.txtBoxName.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(54, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Nazwa";
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(192, 96);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(74, 13);
            this.lblBarCode.TabIndex = 12;
            this.lblBarCode.Text = "Kod kreskowy";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 181);
            this.Controls.Add(this.lblBarCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblKcal);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtBoxKcal);
            this.Controls.Add(this.txtBoxW);
            this.Controls.Add(this.txtBoxT);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.btnConfirm);
            this.Name = "Form4";
            this.Text = "Dodaj produkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.TextBox txtBoxT;
        private System.Windows.Forms.TextBox txtBoxW;
        private System.Windows.Forms.TextBox txtBoxKcal;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBarCode;
    }
}