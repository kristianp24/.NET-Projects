namespace Proiect_PAW
{
    partial class ImprumutForm
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
            this.lab1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonDa = new System.Windows.Forms.RadioButton();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.idStudtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.facultateTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nrCarti = new System.Windows.Forms.TextBox();
            this.CarteInreg = new System.Windows.Forms.Label();
            this.NumeCarte = new System.Windows.Forms.Label();
            this.numeCartetxt = new System.Windows.Forms.TextBox();
            this.IdCarte = new System.Windows.Forms.Label();
            this.idCartetxt = new System.Windows.Forms.TextBox();
            this.PaginiCarte = new System.Windows.Forms.Label();
            this.nrPaginitxt = new System.Windows.Forms.TextBox();
            this.adaugaCartea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cnpTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(273, 34);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(206, 29);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "Imprumut Carte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume Complet:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sunteti student?";
            // 
            // radioButtonDa
            // 
            this.radioButtonDa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDa.AutoSize = true;
            this.radioButtonDa.Location = new System.Drawing.Point(174, 145);
            this.radioButtonDa.Name = "radioButtonDa";
            this.radioButtonDa.Size = new System.Drawing.Size(39, 17);
            this.radioButtonDa.TabIndex = 20;
            this.radioButtonDa.TabStop = true;
            this.radioButtonDa.Text = "Da";
            this.radioButtonDa.UseVisualStyleBackColor = true;
            this.radioButtonDa.CheckedChanged += new System.EventHandler(this.radioButtonDa_CheckedChanged);
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(174, 168);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNu.TabIndex = 21;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nu";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            this.radioButtonNu.CheckedChanged += new System.EventHandler(this.radioButtonNu_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Introduceti Id de student:";
            this.label3.Visible = false;
            // 
            // idStudtxt
            // 
            this.idStudtxt.Location = new System.Drawing.Point(448, 142);
            this.idStudtxt.Name = "idStudtxt";
            this.idStudtxt.Size = new System.Drawing.Size(100, 20);
            this.idStudtxt.TabIndex = 23;
            this.idStudtxt.Visible = false;
            this.idStudtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nrCarti_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Facultatea:";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // facultateTxt
            // 
            this.facultateTxt.Location = new System.Drawing.Point(361, 176);
            this.facultateTxt.Name = "facultateTxt";
            this.facultateTxt.Size = new System.Drawing.Size(100, 20);
            this.facultateTxt.TabIndex = 25;
            this.facultateTxt.Visible = false;
            this.facultateTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cate carti doriti:";
            // 
            // nrCarti
            // 
            this.nrCarti.Location = new System.Drawing.Point(169, 225);
            this.nrCarti.Name = "nrCarti";
            this.nrCarti.Size = new System.Drawing.Size(100, 20);
            this.nrCarti.TabIndex = 27;
            this.nrCarti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nrCarti_KeyPress);
            // 
            // CarteInreg
            // 
            this.CarteInreg.AutoSize = true;
            this.CarteInreg.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarteInreg.Location = new System.Drawing.Point(426, 224);
            this.CarteInreg.Name = "CarteInreg";
            this.CarteInreg.Size = new System.Drawing.Size(151, 19);
            this.CarteInreg.TabIndex = 29;
            this.CarteInreg.Text = "Inregistrare Carte";
            // 
            // NumeCarte
            // 
            this.NumeCarte.AutoSize = true;
            this.NumeCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeCarte.Location = new System.Drawing.Point(350, 257);
            this.NumeCarte.Name = "NumeCarte";
            this.NumeCarte.Size = new System.Drawing.Size(92, 18);
            this.NumeCarte.TabIndex = 30;
            this.NumeCarte.Text = "Nume Carte:";
            // 
            // numeCartetxt
            // 
            this.numeCartetxt.Location = new System.Drawing.Point(448, 257);
            this.numeCartetxt.Name = "numeCartetxt";
            this.numeCartetxt.Size = new System.Drawing.Size(100, 20);
            this.numeCartetxt.TabIndex = 31;
            this.numeCartetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // IdCarte
            // 
            this.IdCarte.AutoSize = true;
            this.IdCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCarte.Location = new System.Drawing.Point(396, 296);
            this.IdCarte.Name = "IdCarte";
            this.IdCarte.Size = new System.Drawing.Size(46, 18);
            this.IdCarte.TabIndex = 32;
            this.IdCarte.Text = "ISBN:";
            // 
            // idCartetxt
            // 
            this.idCartetxt.Location = new System.Drawing.Point(448, 294);
            this.idCartetxt.Name = "idCartetxt";
            this.idCartetxt.Size = new System.Drawing.Size(100, 20);
            this.idCartetxt.TabIndex = 33;
            this.idCartetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nrCarti_KeyPress);
            // 
            // PaginiCarte
            // 
            this.PaginiCarte.AutoSize = true;
            this.PaginiCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaginiCarte.Location = new System.Drawing.Point(323, 337);
            this.PaginiCarte.Name = "PaginiCarte";
            this.PaginiCarte.Size = new System.Drawing.Size(119, 18);
            this.PaginiCarte.TabIndex = 34;
            this.PaginiCarte.Text = "Numar de pagini:";
            // 
            // nrPaginitxt
            // 
            this.nrPaginitxt.Location = new System.Drawing.Point(448, 337);
            this.nrPaginitxt.Name = "nrPaginitxt";
            this.nrPaginitxt.Size = new System.Drawing.Size(100, 20);
            this.nrPaginitxt.TabIndex = 35;
            this.nrPaginitxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nrCarti_KeyPress);
            // 
            // adaugaCartea
            // 
            this.adaugaCartea.Location = new System.Drawing.Point(448, 374);
            this.adaugaCartea.Name = "adaugaCartea";
            this.adaugaCartea.Size = new System.Drawing.Size(100, 23);
            this.adaugaCartea.TabIndex = 36;
            this.adaugaCartea.Text = "Adauga Cartea";
            this.adaugaCartea.UseVisualStyleBackColor = true;
            this.adaugaCartea.Click += new System.EventHandler(this.adaugaCartea_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 37;
            this.button1.Text = "Gata!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "CNP:";
            // 
            // cnpTxt
            // 
            this.cnpTxt.Location = new System.Drawing.Point(103, 281);
            this.cnpTxt.Name = "cnpTxt";
            this.cnpTxt.Size = new System.Drawing.Size(100, 20);
            this.cnpTxt.TabIndex = 39;
            this.cnpTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nrCarti_KeyPress);
            this.cnpTxt.Validating += new System.ComponentModel.CancelEventHandler(this.cnpTxt_Validating);
            // 
            // ImprumutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.cnpTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adaugaCartea);
            this.Controls.Add(this.nrPaginitxt);
            this.Controls.Add(this.PaginiCarte);
            this.Controls.Add(this.idCartetxt);
            this.Controls.Add(this.IdCarte);
            this.Controls.Add(this.numeCartetxt);
            this.Controls.Add(this.NumeCarte);
            this.Controls.Add(this.CarteInreg);
            this.Controls.Add(this.nrCarti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.facultateTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idStudtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonNu);
            this.Controls.Add(this.radioButtonDa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab1);
            this.Name = "ImprumutForm";
            this.Text = "ImprumutForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonDa;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idStudtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox facultateTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nrCarti;
        private System.Windows.Forms.Label CarteInreg;
        private System.Windows.Forms.Label NumeCarte;
        private System.Windows.Forms.TextBox numeCartetxt;
        private System.Windows.Forms.Label IdCarte;
        private System.Windows.Forms.TextBox idCartetxt;
        private System.Windows.Forms.Label PaginiCarte;
        private System.Windows.Forms.TextBox nrPaginitxt;
        private System.Windows.Forms.Button adaugaCartea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox cnpTxt;
        private System.Windows.Forms.Label label6;
    }
}