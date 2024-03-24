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
            this.MenuIntrare = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vizualiareCartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprumuturiNoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intoarceImprumuturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrareBibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonamentLunarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonamentSaptmanalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiinoreAbonamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelIntro = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizualizareCartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareCartiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprumutCarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inregistrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inregistrareSimplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonamentAnualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIntrare.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuIntrare
            // 
            this.MenuIntrare.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuIntrare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualiareCartiToolStripMenuItem,
            this.imprumuturiNoiToolStripMenuItem,
            this.intoarceImprumuturiToolStripMenuItem,
            this.registrareBibliotecaToolStripMenuItem});
            this.MenuIntrare.Name = "MenuIntrare";
            this.MenuIntrare.ShowCheckMargin = true;
            this.MenuIntrare.Size = new System.Drawing.Size(211, 92);
            this.MenuIntrare.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // vizualiareCartiToolStripMenuItem
            // 
            this.vizualiareCartiToolStripMenuItem.Name = "vizualiareCartiToolStripMenuItem";
            this.vizualiareCartiToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.vizualiareCartiToolStripMenuItem.Text = "Vizualiare Carti";
            // 
            // imprumuturiNoiToolStripMenuItem
            // 
            this.imprumuturiNoiToolStripMenuItem.Name = "imprumuturiNoiToolStripMenuItem";
            this.imprumuturiNoiToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.imprumuturiNoiToolStripMenuItem.Text = "Imprumuturi Noi";
            // 
            // intoarceImprumuturiToolStripMenuItem
            // 
            this.intoarceImprumuturiToolStripMenuItem.Name = "intoarceImprumuturiToolStripMenuItem";
            this.intoarceImprumuturiToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.intoarceImprumuturiToolStripMenuItem.Text = "Intoarce Imprumuturi";
            // 
            // registrareBibliotecaToolStripMenuItem
            // 
            this.registrareBibliotecaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonamentLunarToolStripMenuItem,
            this.abonamentSaptmanalToolStripMenuItem,
            this.reiinoreAbonamentToolStripMenuItem});
            this.registrareBibliotecaToolStripMenuItem.Name = "registrareBibliotecaToolStripMenuItem";
            this.registrareBibliotecaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.registrareBibliotecaToolStripMenuItem.Text = "Registrare Biblioteca";
            // 
            // abonamentLunarToolStripMenuItem
            // 
            this.abonamentLunarToolStripMenuItem.Name = "abonamentLunarToolStripMenuItem";
            this.abonamentLunarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.abonamentLunarToolStripMenuItem.Text = "Abonament Lunar";
            // 
            // abonamentSaptmanalToolStripMenuItem
            // 
            this.abonamentSaptmanalToolStripMenuItem.Name = "abonamentSaptmanalToolStripMenuItem";
            this.abonamentSaptmanalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.abonamentSaptmanalToolStripMenuItem.Text = "Abonamen Anual";
            // 
            // reiinoreAbonamentToolStripMenuItem
            // 
            this.reiinoreAbonamentToolStripMenuItem.Name = "reiinoreAbonamentToolStripMenuItem";
            this.reiinoreAbonamentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.reiinoreAbonamentToolStripMenuItem.Text = "Inregistrare Simpla";
            this.reiinoreAbonamentToolStripMenuItem.Click += new System.EventHandler(this.reiinoreAbonamentToolStripMenuItem_Click);
            // 
            // LabelIntro
            // 
            this.LabelIntro.AutoSize = true;
            this.LabelIntro.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIntro.Location = new System.Drawing.Point(238, 195);
            this.LabelIntro.Name = "LabelIntro";
            this.LabelIntro.Size = new System.Drawing.Size(164, 30);
            this.LabelIntro.TabIndex = 1;
            this.LabelIntro.Text = "Biblioteca";
            this.LabelIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareCartiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizualizareCartiToolStripMenuItem
            // 
            this.vizualizareCartiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareCartiToolStripMenuItem1,
            this.imprumutCarteToolStripMenuItem,
            this.inregistrareToolStripMenuItem});
            this.vizualizareCartiToolStripMenuItem.Name = "vizualizareCartiToolStripMenuItem";
            this.vizualizareCartiToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.vizualizareCartiToolStripMenuItem.Text = "Menu";
            this.vizualizareCartiToolStripMenuItem.Click += new System.EventHandler(this.vizualizareCartiToolStripMenuItem_Click);
            // 
            // vizualizareCartiToolStripMenuItem1
            // 
            this.vizualizareCartiToolStripMenuItem1.Name = "vizualizareCartiToolStripMenuItem1";
            this.vizualizareCartiToolStripMenuItem1.Size = new System.Drawing.Size(230, 22);
            this.vizualizareCartiToolStripMenuItem1.Text = "Vizualizare Carti Imprumutate";
            this.vizualizareCartiToolStripMenuItem1.Click += new System.EventHandler(this.vizualizareCartiToolStripMenuItem1_Click);
            // 
            // imprumutCarteToolStripMenuItem
            // 
            this.imprumutCarteToolStripMenuItem.Name = "imprumutCarteToolStripMenuItem";
            this.imprumutCarteToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.imprumutCarteToolStripMenuItem.Text = "Imprumut Carte";
            this.imprumutCarteToolStripMenuItem.Click += new System.EventHandler(this.imprumutCarteToolStripMenuItem_Click);
            // 
            // inregistrareToolStripMenuItem
            // 
            this.inregistrareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inregistrareSimplaToolStripMenuItem,
            this.abonamentAnualToolStripMenuItem});
            this.inregistrareToolStripMenuItem.Name = "inregistrareToolStripMenuItem";
            this.inregistrareToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.inregistrareToolStripMenuItem.Text = "Cont Biblioteca";
            // 
            // inregistrareSimplaToolStripMenuItem
            // 
            this.inregistrareSimplaToolStripMenuItem.Name = "inregistrareSimplaToolStripMenuItem";
            this.inregistrareSimplaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.inregistrareSimplaToolStripMenuItem.Text = "Inregistrare Simpla";
            this.inregistrareSimplaToolStripMenuItem.Click += new System.EventHandler(this.inregistrareSimplaToolStripMenuItem_Click);
            // 
            // abonamentAnualToolStripMenuItem
            // 
            this.abonamentAnualToolStripMenuItem.Name = "abonamentAnualToolStripMenuItem";
            this.abonamentAnualToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.abonamentAnualToolStripMenuItem.Text = "Inregistrare Student";
            this.abonamentAnualToolStripMenuItem.Click += new System.EventHandler(this.abonamentAnualToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LabelIntro);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuIntrare.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem vizualiareCartiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprumuturiNoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intoarceImprumuturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrareBibliotecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonamentLunarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonamentSaptmanalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiinoreAbonamentToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MenuIntrare;
        private System.Windows.Forms.Label LabelIntro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareCartiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareCartiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprumutCarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inregistrareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inregistrareSimplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonamentAnualToolStripMenuItem;
    }
}

