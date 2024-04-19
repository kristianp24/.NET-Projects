using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proiect_PAW
{
    public partial class InregistrareStudent : Form
    {
        InregistrareForm form = new InregistrareForm();
        Student r = new Student();
        int contor;
        public InregistrareStudent()
        {
            InitializeComponent();

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void univeristyTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            form.numeTxt_KeyPress(this, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            form.cnpTxt_KeyPress(this, e);
        }

        private void numeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            form.numeTxt_KeyPress(this, e);
        }




        private void dataNasteriValue_Validating(object sender, CancelEventArgs e)
        {
            if (form.validareData(this.dataNasteriValue.Value) == true)
            {
                MessageBox.Show("Introduceti o data valida!\nVarsta mai mare decat 14 ani!");
                dataNasteriValue.CalendarFont = Font;
            }
        }

        private void emailTxt_Validating(object sender, CancelEventArgs e)
        {
            if (form.verificareEmail(emailTxt.Text) == true)
            {
                MessageBox.Show("Emailul nu este valid! (Introduceti @ si '.com'.!)");
            }
        }

        private void numarTelTxt_Validating(object sender, CancelEventArgs e)
        {
            if (form.Number(numarTelTxt.Text) == false)
            {
                MessageBox.Show("Introduceti doar numere, nu cifre!");
            }

            if (numarTelTxt.Text.Length != 10)
                MessageBox.Show("Un numar are doar 10 cifre! Introduceti un numar corect.");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {

            if (form.checkCNP(textBox3.Text) == true)
            {
                MessageBox.Show("CNP are 13 cifre!");
                textBox3.Clear();
            }
        }

        private void radioButtonDa_CheckedChanged(object sender, EventArgs e)
        {
            nrCarti.Visible = true;
            CarteInreg.Visible = true;
            NumeCarte.Visible = true;
            IdCarte.Visible = true;
            PaginiCarte.Visible = true;
            nrCarteTxt.Visible = true;
            numeCarteTxt.Visible = true;
            idCartetxt.Visible = true;
            nrCarteTxt.Visible = true;
            NrpaginiTxt.Visible = true;
            adaugaCartea.Visible = true;
        }

        private void radioButtonNu_CheckedChanged(object sender, EventArgs e)
        {
            nrCarti.Visible = false;
            CarteInreg.Visible = false;
            NumeCarte.Visible = false;
            IdCarte.Visible = false;
            PaginiCarte.Visible = false;
            nrCarteTxt.Visible = false;
            numeCarteTxt.Visible = false;
            idCartetxt.Visible = false;
            nrCarteTxt.Visible = false;
            NrpaginiTxt.Visible = false;
            adaugaCartea.Visible = false;
        }

        private void adaugaCartea_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.Name = numeCarteTxt.Text;
            b.Id = Convert.ToInt32(idCartetxt.Text);
            b.NrPages = Convert.ToInt32(NrpaginiTxt.Text);
            Reader r1 = (Reader)r;
            r1 = r;
            r1 += b;
          
            numeCarteTxt.Clear();
            idCartetxt.Clear();
            NrpaginiTxt.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                errorProvider1.SetError(textBox3, "Introduceti CNP!");
            else if (numeTxt.Text == "")
                errorProvider1.SetError(numeTxt, "Introdueti numele!");
            else if (dataNasteriValue.Value == null)
                errorProvider1.SetError(dataNasteriValue, "Introduceti data!");
            else if (emailTxt.Text == "")
                errorProvider1.SetError(emailTxt, "Introduceti un email!");
            else if (numarTelTxt.Text == "")
                errorProvider1.SetError(numarTelTxt, "Introduceti numarul de telefon!");
            else if (sexCb.Text == "")
                errorProvider1.SetError(sexCb, "Alegeti sex-ul!");

            else
            {
                errorProvider1.Clear();

                try
                {
                    string cnp = textBox3.Text;
                    string nume = numeTxt.Text;
                    DateTime date = Convert.ToDateTime(dataNasteriValue.Value).Date;
                    string email = emailTxt.Text;
                    string phoneNumb = numarTelTxt.Text;
                    char sex = Convert.ToChar(sexCb.Text);
                    bool carti = false;
                    string idStud = textBox2.Text;
                    string uni = univeristyTxt.Text;


                    if (radioButtonDa.Checked)
                    {
                        carti = true;
                    }
                    else if (radioButtonNu.Checked)
                        carti = false;
                    r.Email = email;
                    r.Name = nume;
                    r.Bday = date;
                    r.Id = cnp;
                    r.PhoneNumber = phoneNumb;
                    r.Sex = sex;
                    r.HasBook = carti;
                    r.IdStudent = idStud;
                    r.University = uni;
                    contor = Convert.ToInt32(nrCarteTxt.Text);
                    MessageBox.Show(r.ToString() + Environment.NewLine + "In total are " + Convert.ToString(contor) + " carti");
                    r.writeTextFile();
                    r.writeBinary();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    univeristyTxt.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    numeTxt.Clear();
                    dataNasteriValue.CalendarFont = null;
                    emailTxt.Clear();
                    numarTelTxt.Clear();
                    sexCb.Text = "";
                    numeCarteTxt.Clear();
                    idCartetxt.Clear();
                    NrpaginiTxt.Clear();
                    CarteInreg.Visible = false;
                    NumeCarte.Visible = false;
                    IdCarte.Visible = false;
                    PaginiCarte.Visible = false;
                    numeCarteTxt.Visible = false;
                    idCartetxt.Visible = false;
                    NrpaginiTxt.Visible = false;
                    adaugaCartea.Visible = false;
                    label8.Visible = false;
                    nrCarti.Visible = false;
                    nrCarteTxt.Visible = false;
                    radioButtonDa.Checked = false;
                    radioButtonNu.Checked = false;

                }
            }
        }
    }
}
