namespace Counting_word_fruequency
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListPrint = new System.Windows.Forms.ListBox();
            this.listPrintOfNumbers = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(376, 270);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.lbl1);
            this.tabPage1.Controls.Add(this.btnC);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Counting word";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(135, 143);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(123, 106);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(107, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Wyniki wyszukiwania";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(135, 43);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(85, 37);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "Count";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listPrintOfNumbers);
            this.tabPage2.Controls.Add(this.ListPrint);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Most frequency words";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListPrint
            // 
            this.ListPrint.FormattingEnabled = true;
            this.ListPrint.Location = new System.Drawing.Point(6, 6);
            this.ListPrint.Name = "ListPrint";
            this.ListPrint.Size = new System.Drawing.Size(186, 225);
            this.ListPrint.TabIndex = 0;
            this.ListPrint.SizeChanged += new System.EventHandler(this.ListPrint_SizeChanged);
            // 
            // listPrintOfNumbers
            // 
            this.listPrintOfNumbers.FormattingEnabled = true;
            this.listPrintOfNumbers.Location = new System.Drawing.Point(198, 6);
            this.listPrintOfNumbers.Name = "listPrintOfNumbers";
            this.listPrintOfNumbers.Size = new System.Drawing.Size(46, 225);
            this.listPrintOfNumbers.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(374, 270);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Counting";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox ListPrint;
        private System.Windows.Forms.ListBox listPrintOfNumbers;
    }
}