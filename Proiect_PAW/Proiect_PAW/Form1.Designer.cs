namespace Proiect_PAW
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelIntro = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareCartiImprumutateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprumutareCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inregistrareContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contSimpluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelIntro
            // 
            this.LabelIntro.AutoSize = true;
            this.LabelIntro.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIntro.Location = new System.Drawing.Point(286, 134);
            this.LabelIntro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelIntro.Name = "LabelIntro";
            this.LabelIntro.Size = new System.Drawing.Size(164, 30);
            this.LabelIntro.TabIndex = 1;
            this.LabelIntro.Text = "Biblioteca";
            this.LabelIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(761, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareCartiImprumutateToolStripMenuItem,
            this.imprumutareCarteToolStripMenuItem,
            this.inregistrareContToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // vizualizareCartiImprumutateToolStripMenuItem
            // 
            this.vizualizareCartiImprumutateToolStripMenuItem.Name = "vizualizareCartiImprumutateToolStripMenuItem";
            this.vizualizareCartiImprumutateToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.vizualizareCartiImprumutateToolStripMenuItem.Text = "Vizualizare Carti Imprumutate";
            this.vizualizareCartiImprumutateToolStripMenuItem.Click += new System.EventHandler(this.vizualizareCartiToolStripMenuItem1_Click);
            // 
            // imprumutareCarteToolStripMenuItem
            // 
            this.imprumutareCarteToolStripMenuItem.Name = "imprumutareCarteToolStripMenuItem";
            this.imprumutareCarteToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.imprumutareCarteToolStripMenuItem.Text = "Imprumutare Carte";
            this.imprumutareCarteToolStripMenuItem.Click += new System.EventHandler(this.imprumutCarteToolStripMenuItem_Click);
            // 
            // inregistrareContToolStripMenuItem
            // 
            this.inregistrareContToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contSimpluToolStripMenuItem,
            this.contStudentToolStripMenuItem});
            this.inregistrareContToolStripMenuItem.Name = "inregistrareContToolStripMenuItem";
            this.inregistrareContToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.inregistrareContToolStripMenuItem.Text = "Inregistrare Cont ";
            // 
            // contSimpluToolStripMenuItem
            // 
            this.contSimpluToolStripMenuItem.Name = "contSimpluToolStripMenuItem";
            this.contSimpluToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.contSimpluToolStripMenuItem.Text = "Cont Simplu";
            this.contSimpluToolStripMenuItem.Click += new System.EventHandler(this.inregistrareSimplaToolStripMenuItem_Click);
            // 
            // contStudentToolStripMenuItem
            // 
            this.contStudentToolStripMenuItem.Name = "contStudentToolStripMenuItem";
            this.contStudentToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.contStudentToolStripMenuItem.Text = "Cont Student";
            this.contStudentToolStripMenuItem.Click += new System.EventHandler(this.contStudentToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 167);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(15, 425);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(53, 20);
            this.timerLabel.TabIndex = 4;
            this.timerLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelIntro);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelIntro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareCartiImprumutateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprumutareCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inregistrareContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contSimpluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contStudentToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
    }
}

