namespace Liczenie_makroskładników
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPosiłekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.lblAdd3 = new System.Windows.Forms.Label();
            this.lblAdd4 = new System.Windows.Forms.Label();
            this.lblAdd5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblKcal = new System.Windows.Forms.Label();
            this.lblBscore = new System.Windows.Forms.Label();
            this.lblTscore = new System.Windows.Forms.Label();
            this.lblWscore = new System.Windows.Forms.Label();
            this.lblKcalscore = new System.Windows.Forms.Label();
            this.btnLW1del = new System.Windows.Forms.Button();
            this.btnLW2del = new System.Windows.Forms.Button();
            this.btnLW3del = new System.Windows.Forms.Button();
            this.btnLW4del = new System.Windows.Forms.Button();
            this.btnLW5del = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 83);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajPosiłekToolStripMenuItem,
            this.wyczyśćToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // dodajPosiłekToolStripMenuItem
            // 
            this.dodajPosiłekToolStripMenuItem.Name = "dodajPosiłekToolStripMenuItem";
            this.dodajPosiłekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajPosiłekToolStripMenuItem.Text = "Dodaj posiłek";
            this.dodajPosiłekToolStripMenuItem.Click += new System.EventHandler(this.dodajPosiłekToolStripMenuItem_Click);
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćToolStripMenuItem_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(10, 187);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(350, 83);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.Click += new System.EventHandler(this.listView2_Click);
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(10, 310);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(350, 83);
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.Click += new System.EventHandler(this.listView3_Click);
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(10, 433);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(350, 83);
            this.listView4.TabIndex = 4;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.Click += new System.EventHandler(this.listView4_Click);
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(10, 565);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(350, 83);
            this.listView5.TabIndex = 5;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.Click += new System.EventHandler(this.listView5_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(22, 30);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(89, 20);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Śniadanie";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2.Location = new System.Drawing.Point(12, 155);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(111, 20);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = " || Śniadanie";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl3.Location = new System.Drawing.Point(22, 287);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(52, 20);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "lunch";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl4.Location = new System.Drawing.Point(22, 410);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(56, 20);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Obiad";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl5.Location = new System.Drawing.Point(22, 531);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(67, 20);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Kolacja";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblB.Location = new System.Drawing.Point(23, 657);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(15, 13);
            this.lblB.TabIndex = 12;
            this.lblB.Text = "B";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblT.Location = new System.Drawing.Point(93, 657);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(15, 13);
            this.lblT.TabIndex = 13;
            this.lblT.Text = "T";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblW.Location = new System.Drawing.Point(162, 657);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(19, 13);
            this.lblW.TabIndex = 14;
            this.lblW.Text = "W";
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdd1.Location = new System.Drawing.Point(159, 26);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(22, 24);
            this.lblAdd1.TabIndex = 15;
            this.lblAdd1.Text = "+";
            this.lblAdd1.Click += new System.EventHandler(this.lblAdd1_Click);
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdd2.Location = new System.Drawing.Point(159, 152);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(22, 24);
            this.lblAdd2.TabIndex = 16;
            this.lblAdd2.Text = "+";
            this.lblAdd2.Click += new System.EventHandler(this.lblAdd2_Click);
            // 
            // lblAdd3
            // 
            this.lblAdd3.AutoSize = true;
            this.lblAdd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdd3.Location = new System.Drawing.Point(159, 283);
            this.lblAdd3.Name = "lblAdd3";
            this.lblAdd3.Size = new System.Drawing.Size(22, 24);
            this.lblAdd3.TabIndex = 17;
            this.lblAdd3.Text = "+";
            this.lblAdd3.Click += new System.EventHandler(this.lblAdd3_Click);
            // 
            // lblAdd4
            // 
            this.lblAdd4.AutoSize = true;
            this.lblAdd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdd4.Location = new System.Drawing.Point(159, 407);
            this.lblAdd4.Name = "lblAdd4";
            this.lblAdd4.Size = new System.Drawing.Size(22, 24);
            this.lblAdd4.TabIndex = 18;
            this.lblAdd4.Text = "+";
            this.lblAdd4.Click += new System.EventHandler(this.lblAdd4_Click);
            // 
            // lblAdd5
            // 
            this.lblAdd5.AutoSize = true;
            this.lblAdd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdd5.Location = new System.Drawing.Point(159, 527);
            this.lblAdd5.Name = "lblAdd5";
            this.lblAdd5.Size = new System.Drawing.Size(22, 24);
            this.lblAdd5.TabIndex = 19;
            this.lblAdd5.Text = "+";
            this.lblAdd5.Click += new System.EventHandler(this.lblAdd5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKcal.Location = new System.Drawing.Point(239, 657);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(32, 13);
            this.lblKcal.TabIndex = 20;
            this.lblKcal.Text = "Kcal";
            // 
            // lblBscore
            // 
            this.lblBscore.AutoSize = true;
            this.lblBscore.Location = new System.Drawing.Point(47, 657);
            this.lblBscore.Name = "lblBscore";
            this.lblBscore.Size = new System.Drawing.Size(13, 13);
            this.lblBscore.TabIndex = 21;
            this.lblBscore.Text = "0";
            // 
            // lblTscore
            // 
            this.lblTscore.AutoSize = true;
            this.lblTscore.Location = new System.Drawing.Point(114, 657);
            this.lblTscore.Name = "lblTscore";
            this.lblTscore.Size = new System.Drawing.Size(13, 13);
            this.lblTscore.TabIndex = 22;
            this.lblTscore.Text = "0";
            // 
            // lblWscore
            // 
            this.lblWscore.AutoSize = true;
            this.lblWscore.Location = new System.Drawing.Point(187, 657);
            this.lblWscore.Name = "lblWscore";
            this.lblWscore.Size = new System.Drawing.Size(13, 13);
            this.lblWscore.TabIndex = 23;
            this.lblWscore.Text = "0";
            // 
            // lblKcalscore
            // 
            this.lblKcalscore.AutoSize = true;
            this.lblKcalscore.Location = new System.Drawing.Point(277, 657);
            this.lblKcalscore.Name = "lblKcalscore";
            this.lblKcalscore.Size = new System.Drawing.Size(13, 13);
            this.lblKcalscore.TabIndex = 24;
            this.lblKcalscore.Text = "0";
            // 
            // btnLW1del
            // 
            this.btnLW1del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLW1del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLW1del.Location = new System.Drawing.Point(261, 27);
            this.btnLW1del.Name = "btnLW1del";
            this.btnLW1del.Size = new System.Drawing.Size(40, 23);
            this.btnLW1del.TabIndex = 25;
            this.btnLW1del.Text = "X";
            this.btnLW1del.UseVisualStyleBackColor = true;
            this.btnLW1del.Click += new System.EventHandler(this.btnLW1del_Click);
            // 
            // btnLW2del
            // 
            this.btnLW2del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLW2del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLW2del.Location = new System.Drawing.Point(261, 155);
            this.btnLW2del.Name = "btnLW2del";
            this.btnLW2del.Size = new System.Drawing.Size(40, 23);
            this.btnLW2del.TabIndex = 26;
            this.btnLW2del.Text = "X";
            this.btnLW2del.UseVisualStyleBackColor = true;
            this.btnLW2del.Click += new System.EventHandler(this.btnLW2del_Click);
            // 
            // btnLW3del
            // 
            this.btnLW3del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLW3del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLW3del.Location = new System.Drawing.Point(261, 276);
            this.btnLW3del.Name = "btnLW3del";
            this.btnLW3del.Size = new System.Drawing.Size(40, 23);
            this.btnLW3del.TabIndex = 27;
            this.btnLW3del.Text = "X";
            this.btnLW3del.UseVisualStyleBackColor = true;
            this.btnLW3del.Click += new System.EventHandler(this.btnLW3del_Click);
            // 
            // btnLW4del
            // 
            this.btnLW4del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLW4del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLW4del.Location = new System.Drawing.Point(261, 404);
            this.btnLW4del.Name = "btnLW4del";
            this.btnLW4del.Size = new System.Drawing.Size(40, 23);
            this.btnLW4del.TabIndex = 28;
            this.btnLW4del.Text = "X";
            this.btnLW4del.UseVisualStyleBackColor = true;
            this.btnLW4del.Click += new System.EventHandler(this.btnLW4del_Click);
            // 
            // btnLW5del
            // 
            this.btnLW5del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLW5del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLW5del.Location = new System.Drawing.Point(261, 530);
            this.btnLW5del.Name = "btnLW5del";
            this.btnLW5del.Size = new System.Drawing.Size(40, 23);
            this.btnLW5del.TabIndex = 29;
            this.btnLW5del.Text = "X";
            this.btnLW5del.UseVisualStyleBackColor = true;
            this.btnLW5del.Click += new System.EventHandler(this.btnLW5del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(370, 449);
            this.Controls.Add(this.btnLW5del);
            this.Controls.Add(this.btnLW4del);
            this.Controls.Add(this.btnLW3del);
            this.Controls.Add(this.btnLW2del);
            this.Controls.Add(this.btnLW1del);
            this.Controls.Add(this.lblKcalscore);
            this.Controls.Add(this.lblWscore);
            this.Controls.Add(this.lblTscore);
            this.Controls.Add(this.lblBscore);
            this.Controls.Add(this.lblKcal);
            this.Controls.Add(this.lblAdd5);
            this.Controls.Add(this.lblAdd4);
            this.Controls.Add(this.lblAdd3);
            this.Controls.Add(this.lblAdd2);
            this.Controls.Add(this.lblAdd1);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liczenie kalorii";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem dodajPosiłekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.Label lblAdd3;
        private System.Windows.Forms.Label lblAdd4;
        private System.Windows.Forms.Label lblAdd5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.Label lblBscore;
        private System.Windows.Forms.Label lblTscore;
        private System.Windows.Forms.Label lblWscore;
        private System.Windows.Forms.Label lblKcalscore;
        private System.Windows.Forms.Button btnLW1del;
        private System.Windows.Forms.Button btnLW2del;
        private System.Windows.Forms.Button btnLW3del;
        private System.Windows.Forms.Button btnLW4del;
        private System.Windows.Forms.Button btnLW5del;
    }
}

