namespace Proiect_PAW
{
    partial class AfisareCarti
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.schimbaCuloareConturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaCuloareaGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaFontulDeScrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printDocumentToolStripMenuItem,
            this.schimbaCuloareConturToolStripMenuItem,
            this.schimbaCuloareaGraficToolStripMenuItem,
            this.schimbaFontulDeScrisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printDocumentToolStripMenuItem
            // 
            this.printDocumentToolStripMenuItem.Name = "printDocumentToolStripMenuItem";
            this.printDocumentToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.printDocumentToolStripMenuItem.Text = "Print Document";
            this.printDocumentToolStripMenuItem.Click += new System.EventHandler(this.printDocumentToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // schimbaCuloareConturToolStripMenuItem
            // 
            this.schimbaCuloareConturToolStripMenuItem.Name = "schimbaCuloareConturToolStripMenuItem";
            this.schimbaCuloareConturToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.schimbaCuloareConturToolStripMenuItem.Text = "Schimba Culoare Contur";
            this.schimbaCuloareConturToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareConturToolStripMenuItem_Click);
            // 
            // schimbaCuloareaGraficToolStripMenuItem
            // 
            this.schimbaCuloareaGraficToolStripMenuItem.Name = "schimbaCuloareaGraficToolStripMenuItem";
            this.schimbaCuloareaGraficToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.schimbaCuloareaGraficToolStripMenuItem.Text = "Schimba Culoarea Grafic";
            this.schimbaCuloareaGraficToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareaGraficToolStripMenuItem_Click);
            // 
            // schimbaFontulDeScrisToolStripMenuItem
            // 
            this.schimbaFontulDeScrisToolStripMenuItem.Name = "schimbaFontulDeScrisToolStripMenuItem";
            this.schimbaFontulDeScrisToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.schimbaFontulDeScrisToolStripMenuItem.Text = "Schimba Fontul de Scris";
            this.schimbaFontulDeScrisToolStripMenuItem.Click += new System.EventHandler(this.schimbaFontulDeScrisToolStripMenuItem_Click);
            // 
            // AfisareCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AfisareCarti";
            this.Text = "AfisareCarti";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printDocumentToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareConturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareaGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaFontulDeScrisToolStripMenuItem;
    }
}