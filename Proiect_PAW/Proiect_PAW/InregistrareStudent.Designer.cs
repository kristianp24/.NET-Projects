namespace Proiect_PAW
{
    partial class InregistrareStudent
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
            this.univeristyTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numarTelTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sexCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonDa = new System.Windows.Forms.RadioButton();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.nrCarti = new System.Windows.Forms.Label();
            this.nrCarteTxt = new System.Windows.Forms.TextBox();
            this.CarteInreg = new System.Windows.Forms.Label();
            this.NumeCarte = new System.Windows.Forms.Label();
            this.numeCarteTxt = new System.Windows.Forms.TextBox();
            this.IdCarte = new System.Windows.Forms.Label();
            this.idCartetxt = new System.Windows.Forms.TextBox();
            this.PaginiCarte = new System.Windows.Forms.Label();
            this.NrpaginiTxt = new System.Windows.Forms.TextBox();
            this.adaugaCartea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataNasteriValue = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(244, 27);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(249, 29);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "Inregistrare Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Universitate:";
            // 
            // univeristyTxt
            // 
            this.univeristyTxt.Location = new System.Drawing.Point(124, 76);
            this.univeristyTxt.Name = "univeristyTxt";
            this.univeristyTxt.Size = new System.Drawing.Size(100, 20);
            this.univeristyTxt.TabIndex = 3;
            this.univeristyTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.univeristyTxt_KeyPress);
            this.univeristyTxt.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id student:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "CNP:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nume Complet:";
            // 
            // numeTxt
            // 
            this.numeTxt.Location = new System.Drawing.Point(147, 200);
            this.numeTxt.Name = "numeTxt";
            this.numeTxt.Size = new System.Drawing.Size(100, 20);
            this.numeTxt.TabIndex = 9;
            this.numeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeTxt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ziua de nastere:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(94, 278);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(100, 20);
            this.emailTxt.TabIndex = 13;
            this.emailTxt.Validating += new System.ComponentModel.CancelEventHandler(this.emailTxt_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numar telefon:";
            // 
            // numarTelTxt
            // 
            this.numarTelTxt.Location = new System.Drawing.Point(147, 318);
            this.numarTelTxt.Name = "numarTelTxt";
            this.numarTelTxt.Size = new System.Drawing.Size(100, 20);
            this.numarTelTxt.TabIndex = 15;
            this.numarTelTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.numarTelTxt.Validating += new System.ComponentModel.CancelEventHandler(this.numarTelTxt_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sex:";
            // 
            // sexCb
            // 
            this.sexCb.FormattingEnabled = true;
            this.sexCb.Items.AddRange(new object[] {
            "F",
            "M"});
            this.sexCb.Location = new System.Drawing.Point(94, 358);
            this.sexCb.Name = "sexCb";
            this.sexCb.Size = new System.Drawing.Size(100, 21);
            this.sexCb.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(352, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Aveti carti imprumutate de la noi?\r\n";
            // 
            // radioButtonDa
            // 
            this.radioButtonDa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDa.AutoSize = true;
            this.radioButtonDa.Location = new System.Drawing.Point(601, 80);
            this.radioButtonDa.Name = "radioButtonDa";
            this.radioButtonDa.Size = new System.Drawing.Size(39, 17);
            this.radioButtonDa.TabIndex = 19;
            this.radioButtonDa.TabStop = true;
            this.radioButtonDa.Text = "Da";
            this.radioButtonDa.UseVisualStyleBackColor = true;
            this.radioButtonDa.CheckedChanged += new System.EventHandler(this.radioButtonDa_CheckedChanged);
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(601, 103);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNu.TabIndex = 20;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nu";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            this.radioButtonNu.CheckedChanged += new System.EventHandler(this.radioButtonNu_CheckedChanged);
            // 
            // nrCarti
            // 
            this.nrCarti.AutoSize = true;
            this.nrCarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrCarti.Location = new System.Drawing.Point(435, 189);
            this.nrCarti.Name = "nrCarti";
            this.nrCarti.Size = new System.Drawing.Size(125, 18);
            this.nrCarti.TabIndex = 26;
            this.nrCarti.Text = "Numarul de carte:";
            this.nrCarti.Visible = false;
            // 
            // nrCarteTxt
            // 
            this.nrCarteTxt.Location = new System.Drawing.Point(566, 187);
            this.nrCarteTxt.Name = "nrCarteTxt";
            this.nrCarteTxt.Size = new System.Drawing.Size(100, 20);
            this.nrCarteTxt.TabIndex = 27;
            this.nrCarteTxt.Visible = false;
            this.nrCarteTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // CarteInreg
            // 
            this.CarteInreg.AutoSize = true;
            this.CarteInreg.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarteInreg.Location = new System.Drawing.Point(495, 219);
            this.CarteInreg.Name = "CarteInreg";
            this.CarteInreg.Size = new System.Drawing.Size(151, 19);
            this.CarteInreg.TabIndex = 28;
            this.CarteInreg.Text = "Inregistrare Carte";
            this.CarteInreg.Visible = false;
            // 
            // NumeCarte
            // 
            this.NumeCarte.AutoSize = true;
            this.NumeCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeCarte.Location = new System.Drawing.Point(435, 253);
            this.NumeCarte.Name = "NumeCarte";
            this.NumeCarte.Size = new System.Drawing.Size(92, 18);
            this.NumeCarte.TabIndex = 29;
            this.NumeCarte.Text = "Nume Carte:";
            this.NumeCarte.Visible = false;
            // 
            // numeCarteTxt
            // 
            this.numeCarteTxt.Location = new System.Drawing.Point(540, 254);
            this.numeCarteTxt.Name = "numeCarteTxt";
            this.numeCarteTxt.Size = new System.Drawing.Size(100, 20);
            this.numeCarteTxt.TabIndex = 30;
            this.numeCarteTxt.Visible = false;
            this.numeCarteTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.univeristyTxt_KeyPress);
            // 
            // IdCarte
            // 
            this.IdCarte.AutoSize = true;
            this.IdCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCarte.Location = new System.Drawing.Point(481, 294);
            this.IdCarte.Name = "IdCarte";
            this.IdCarte.Size = new System.Drawing.Size(46, 18);
            this.IdCarte.TabIndex = 31;
            this.IdCarte.Text = "ISBN:";
            this.IdCarte.Visible = false;
            // 
            // idCartetxt
            // 
            this.idCartetxt.Location = new System.Drawing.Point(540, 294);
            this.idCartetxt.Name = "idCartetxt";
            this.idCartetxt.Size = new System.Drawing.Size(100, 20);
            this.idCartetxt.TabIndex = 32;
            this.idCartetxt.Visible = false;
            this.idCartetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // PaginiCarte
            // 
            this.PaginiCarte.AutoSize = true;
            this.PaginiCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaginiCarte.Location = new System.Drawing.Point(408, 331);
            this.PaginiCarte.Name = "PaginiCarte";
            this.PaginiCarte.Size = new System.Drawing.Size(119, 18);
            this.PaginiCarte.TabIndex = 33;
            this.PaginiCarte.Text = "Numar de pagini:";
            this.PaginiCarte.Visible = false;
            // 
            // NrpaginiTxt
            // 
            this.NrpaginiTxt.Location = new System.Drawing.Point(540, 332);
            this.NrpaginiTxt.Name = "NrpaginiTxt";
            this.NrpaginiTxt.Size = new System.Drawing.Size(100, 20);
            this.NrpaginiTxt.TabIndex = 34;
            this.NrpaginiTxt.Visible = false;
            this.NrpaginiTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // adaugaCartea
            // 
            this.adaugaCartea.Location = new System.Drawing.Point(514, 371);
            this.adaugaCartea.Name = "adaugaCartea";
            this.adaugaCartea.Size = new System.Drawing.Size(100, 23);
            this.adaugaCartea.TabIndex = 35;
            this.adaugaCartea.Text = "Adauga Cartea";
            this.adaugaCartea.UseVisualStyleBackColor = true;
            this.adaugaCartea.Visible = false;
            this.adaugaCartea.Click += new System.EventHandler(this.adaugaCartea_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 36;
            this.button1.Text = "Creare Cont";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataNasteriValue
            // 
            this.dataNasteriValue.Location = new System.Drawing.Point(147, 244);
            this.dataNasteriValue.Name = "dataNasteriValue";
            this.dataNasteriValue.Size = new System.Drawing.Size(200, 20);
            this.dataNasteriValue.TabIndex = 37;
            this.dataNasteriValue.Validating += new System.ComponentModel.CancelEventHandler(this.dataNasteriValue_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InregistrareStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataNasteriValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adaugaCartea);
            this.Controls.Add(this.NrpaginiTxt);
            this.Controls.Add(this.PaginiCarte);
            this.Controls.Add(this.idCartetxt);
            this.Controls.Add(this.IdCarte);
            this.Controls.Add(this.numeCarteTxt);
            this.Controls.Add(this.NumeCarte);
            this.Controls.Add(this.CarteInreg);
            this.Controls.Add(this.nrCarteTxt);
            this.Controls.Add(this.nrCarti);
            this.Controls.Add(this.radioButtonNu);
            this.Controls.Add(this.radioButtonDa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sexCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numarTelTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.univeristyTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab1);
            this.Name = "InregistrareStudent";
            this.Text = "InregistrareStudent";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox univeristyTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numarTelTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox sexCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonDa;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.Label nrCarti;
        private System.Windows.Forms.TextBox nrCarteTxt;
        private System.Windows.Forms.Label CarteInreg;
        private System.Windows.Forms.Label NumeCarte;
        private System.Windows.Forms.TextBox numeCarteTxt;
        private System.Windows.Forms.Label IdCarte;
        private System.Windows.Forms.TextBox idCartetxt;
        private System.Windows.Forms.Label PaginiCarte;
        private System.Windows.Forms.TextBox NrpaginiTxt;
        private System.Windows.Forms.Button adaugaCartea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dataNasteriValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}