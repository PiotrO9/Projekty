namespace Sudoku
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.poziomTrudnościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.łatwyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trudnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.Controls.Add(this.lbl9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(349, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(153, 153);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl9.Location = new System.Drawing.Point(103, 100);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(47, 52);
            this.lbl9.TabIndex = 11;
            this.lbl9.Text = "9";
            this.lbl9.Click += new System.EventHandler(this.lbl9_Click);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl8.Location = new System.Drawing.Point(53, 100);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(44, 52);
            this.lbl8.TabIndex = 10;
            this.lbl8.Text = "8";
            this.lbl8.Click += new System.EventHandler(this.lbl8_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl7.Location = new System.Drawing.Point(3, 100);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(44, 52);
            this.lbl7.TabIndex = 9;
            this.lbl7.Text = "7";
            this.lbl7.Click += new System.EventHandler(this.lbl7_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl6.Location = new System.Drawing.Point(103, 50);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(47, 50);
            this.lbl6.TabIndex = 8;
            this.lbl6.Text = "6";
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl5.Location = new System.Drawing.Point(53, 50);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(44, 50);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "5";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl4.Location = new System.Drawing.Point(3, 50);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(44, 50);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "4";
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl3.Location = new System.Drawing.Point(103, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(47, 50);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "3";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2.Location = new System.Drawing.Point(53, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 50);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "2";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(3, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 50);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "1";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.poziomTrudnościToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.nowaGraToolStripMenuItem.Text = "Nowa gra";
            this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.nowaGraToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(391, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "0 : 0";
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblClear.Location = new System.Drawing.Point(368, 213);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(118, 33);
            this.lblClear.TabIndex = 7;
            this.lblClear.Text = "Wymaż";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 272);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(15, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 3);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(15, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 3);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(215, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 275);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(113, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 275);
            this.panel4.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // poziomTrudnościToolStripMenuItem
            // 
            this.poziomTrudnościToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.łatwyToolStripMenuItem,
            this.średniToolStripMenuItem,
            this.trudnyToolStripMenuItem});
            this.poziomTrudnościToolStripMenuItem.Name = "poziomTrudnościToolStripMenuItem";
            this.poziomTrudnościToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.poziomTrudnościToolStripMenuItem.Text = "Poziom trudności";
            // 
            // łatwyToolStripMenuItem
            // 
            this.łatwyToolStripMenuItem.Name = "łatwyToolStripMenuItem";
            this.łatwyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.łatwyToolStripMenuItem.Text = "Łatwy";
            this.łatwyToolStripMenuItem.Click += new System.EventHandler(this.łatwyToolStripMenuItem_Click);
            // 
            // średniToolStripMenuItem
            // 
            this.średniToolStripMenuItem.Name = "średniToolStripMenuItem";
            this.średniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.średniToolStripMenuItem.Text = "Średni";
            this.średniToolStripMenuItem.Click += new System.EventHandler(this.średniToolStripMenuItem_Click);
            // 
            // trudnyToolStripMenuItem
            // 
            this.trudnyToolStripMenuItem.Name = "trudnyToolStripMenuItem";
            this.trudnyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trudnyToolStripMenuItem.Text = "Trudny";
            this.trudnyToolStripMenuItem.Click += new System.EventHandler(this.trudnyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 318);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(115, 30);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem poziomTrudnościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem łatwyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trudnyToolStripMenuItem;
    }
}

