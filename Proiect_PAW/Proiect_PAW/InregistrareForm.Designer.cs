namespace Proiect_PAW
{
    partial class InregistrareForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cnpTxt = new System.Windows.Forms.TextBox();
            this.numeTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.DateTimePicker();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.numartelTxt = new System.Windows.Forms.TextBox();
            this.sexCb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.CarteInreg = new System.Windows.Forms.Label();
            this.NumeCarte = new System.Windows.Forms.Label();
            this.IdCarte = new System.Windows.Forms.Label();
            this.PaginiCarte = new System.Windows.Forms.Label();
            this.numeCartetxt = new System.Windows.Forms.TextBox();
            this.nrPaginitxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nrCarte = new System.Windows.Forms.TextBox();
            this.idCartetxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(247, 23);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(217, 29);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Inregistrare Cont";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CNP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume Complet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ziua de nastere:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numar telefon:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Aveti carti imprumutate de la noi?\r\n";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cnpTxt
            // 
            this.cnpTxt.Location = new System.Drawing.Point(128, 76);
            this.cnpTxt.Name = "cnpTxt";
            this.cnpTxt.Size = new System.Drawing.Size(100, 20);
            this.cnpTxt.TabIndex = 8;
            this.cnpTxt.TextChanged += new System.EventHandler(this.cnpTxt_TextChanged);
            this.cnpTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnpTxt_KeyPress);
            this.cnpTxt.Validating += new System.ComponentModel.CancelEventHandler(this.cnpTxt_Validating);
            // 
            // numeTxt
            // 
            this.numeTxt.Location = new System.Drawing.Point(176, 113);
            this.numeTxt.Name = "numeTxt";
            this.numeTxt.Size = new System.Drawing.Size(100, 20);
            this.numeTxt.TabIndex = 9;
            this.numeTxt.TextChanged += new System.EventHandler(this.numeTxt_TextChanged);
            this.numeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeTxt_KeyPress);
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(176, 155);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(200, 20);
            this.dateTxt.TabIndex = 10;
            this.dateTxt.ValueChanged += new System.EventHandler(this.dateTxt_ValueChanged);
            this.dateTxt.Validating += new System.ComponentModel.CancelEventHandler(this.dateTxt_Validating);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(176, 193);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(155, 20);
            this.emailTxt.TabIndex = 11;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            this.emailTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTxt_KeyPress);
            this.emailTxt.Validating += new System.ComponentModel.CancelEventHandler(this.emailTxt_Validating);
            // 
            // numartelTxt
            // 
            this.numartelTxt.Location = new System.Drawing.Point(176, 234);
            this.numartelTxt.Name = "numartelTxt";
            this.numartelTxt.Size = new System.Drawing.Size(141, 20);
            this.numartelTxt.TabIndex = 12;
            this.numartelTxt.TextChanged += new System.EventHandler(this.numartelTxt_TextChanged);
            this.numartelTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnpTxt_KeyPress);
            this.numartelTxt.Validating += new System.ComponentModel.CancelEventHandler(this.numartelTxt_Validating);
            // 
            // sexCb
            // 
            this.sexCb.FormattingEnabled = true;
            this.sexCb.Items.AddRange(new object[] {
            "F",
            "M"});
            this.sexCb.Location = new System.Drawing.Point(176, 277);
            this.sexCb.Name = "sexCb";
            this.sexCb.Size = new System.Drawing.Size(100, 21);
            this.sexCb.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Creare Cont";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(252, 320);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Da";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(252, 344);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nu";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CarteInreg
            // 
            this.CarteInreg.AutoSize = true;
            this.CarteInreg.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarteInreg.Location = new System.Drawing.Point(497, 161);
            this.CarteInreg.Name = "CarteInreg";
            this.CarteInreg.Size = new System.Drawing.Size(151, 19);
            this.CarteInreg.TabIndex = 17;
            this.CarteInreg.Text = "Inregistrare Carte";
            this.CarteInreg.Visible = false;
            // 
            // NumeCarte
            // 
            this.NumeCarte.AutoSize = true;
            this.NumeCarte.Location = new System.Drawing.Point(476, 199);
            this.NumeCarte.Name = "NumeCarte";
            this.NumeCarte.Size = new System.Drawing.Size(66, 13);
            this.NumeCarte.TabIndex = 18;
            this.NumeCarte.Text = "Nume Carte:";
            this.NumeCarte.Visible = false;
            // 
            // IdCarte
            // 
            this.IdCarte.AutoSize = true;
            this.IdCarte.Location = new System.Drawing.Point(496, 237);
            this.IdCarte.Name = "IdCarte";
            this.IdCarte.Size = new System.Drawing.Size(35, 13);
            this.IdCarte.TabIndex = 19;
            this.IdCarte.Text = "ISBN:";
            this.IdCarte.Visible = false;
            // 
            // PaginiCarte
            // 
            this.PaginiCarte.AutoSize = true;
            this.PaginiCarte.Location = new System.Drawing.Point(455, 276);
            this.PaginiCarte.Name = "PaginiCarte";
            this.PaginiCarte.Size = new System.Drawing.Size(87, 13);
            this.PaginiCarte.TabIndex = 20;
            this.PaginiCarte.Text = "Numar de pagini:";
            this.PaginiCarte.Visible = false;
            // 
            // numeCartetxt
            // 
            this.numeCartetxt.Location = new System.Drawing.Point(548, 196);
            this.numeCartetxt.Name = "numeCartetxt";
            this.numeCartetxt.Size = new System.Drawing.Size(100, 20);
            this.numeCartetxt.TabIndex = 21;
            this.numeCartetxt.Visible = false;
            this.numeCartetxt.TextChanged += new System.EventHandler(this.numeCartetxt_TextChanged);
            // 
            // nrPaginitxt
            // 
            this.nrPaginitxt.Location = new System.Drawing.Point(548, 273);
            this.nrPaginitxt.Name = "nrPaginitxt";
            this.nrPaginitxt.Size = new System.Drawing.Size(100, 20);
            this.nrPaginitxt.TabIndex = 23;
            this.nrPaginitxt.Visible = false;
            this.nrPaginitxt.TextChanged += new System.EventHandler(this.nrPaginitxt_TextChanged);
            this.nrPaginitxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnpTxt_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Adauga Cartea";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Numarul de carte:";
            this.label8.Visible = false;
            // 
            // nrCarte
            // 
            this.nrCarte.Location = new System.Drawing.Point(553, 120);
            this.nrCarte.Name = "nrCarte";
            this.nrCarte.Size = new System.Drawing.Size(100, 20);
            this.nrCarte.TabIndex = 26;
            this.nrCarte.Visible = false;
            // 
            // idCartetxt
            // 
            this.idCartetxt.Location = new System.Drawing.Point(548, 234);
            this.idCartetxt.Name = "idCartetxt";
            this.idCartetxt.Size = new System.Drawing.Size(100, 20);
            this.idCartetxt.TabIndex = 22;
            this.idCartetxt.Visible = false;
            this.idCartetxt.TextChanged += new System.EventHandler(this.idCartetxt_TextChanged);
            this.idCartetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnpTxt_KeyPress);
            // 
            // InregistrareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.nrCarte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nrPaginitxt);
            this.Controls.Add(this.idCartetxt);
            this.Controls.Add(this.numeCartetxt);
            this.Controls.Add(this.PaginiCarte);
            this.Controls.Add(this.IdCarte);
            this.Controls.Add(this.NumeCarte);
            this.Controls.Add(this.CarteInreg);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sexCb);
            this.Controls.Add(this.numartelTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.numeTxt);
            this.Controls.Add(this.cnpTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab1);
            this.Name = "InregistrareForm";
            this.Text = "InregistrareForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox numeTxt;
        private System.Windows.Forms.TextBox cnpTxt;
        private System.Windows.Forms.ComboBox sexCb;
        private System.Windows.Forms.TextBox numartelTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.DateTimePicker dateTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label CarteInreg;
        private System.Windows.Forms.Label PaginiCarte;
        private System.Windows.Forms.Label IdCarte;
        private System.Windows.Forms.Label NumeCarte;
        private System.Windows.Forms.TextBox nrPaginitxt;
        private System.Windows.Forms.TextBox numeCartetxt;
        private System.Windows.Forms.TextBox nrCarte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox idCartetxt;
    }
}