using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class InregistrareForm : Form
    {
        int contor = 0;
        public InregistrareForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Reader r = new Reader();

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnpTxt.Text == "")
                errorProvider1.SetError(cnpTxt, "Introduceti CNP!");
            else if (numeTxt.Text == "")
                errorProvider1.SetError(numeTxt, "Introdueti numele!");
            else if (dateTxt.Value == null)
                errorProvider1.SetError(dateTxt, "Introduceti data!");
            else if (emailTxt.Text == "")
                errorProvider1.SetError(emailTxt, "Introduceti un email!");
            else if (numartelTxt.Text == "")
                errorProvider1.SetError(numartelTxt, "Introduceti numarul de telefon!");
            else if (sexCb.Text == "")
                errorProvider1.SetError(sexCb, "Alegeti sex-ul!");

            else
            {
                errorProvider1.Clear();

                try
                {
                    string cnp = cnpTxt.Text;
                    string nume = numeTxt.Text;
                    DateTime date = Convert.ToDateTime(dateTxt.Value).Date;
                    string email = emailTxt.Text;
                    string phoneNumb = numartelTxt.Text;
                    char sex = Convert.ToChar(sexCb.Text);
                    bool carti = false;
                    
                   
                    if (radioButton1.Checked)
                    {
                        carti = true;
                    }
                    else if (radioButton2.Checked)
                        carti = false;
                    r.Email = email;
                    r.Name = nume;
                    r.Bday = date;
                    r.Id = cnp;
                    r.PhoneNumber = phoneNumb;
                    r.Sex = sex;
                    r.HasBook = carti;

                    MessageBox.Show(r.ToString()+Environment.NewLine+"In total are "+Convert.ToString(contor)+" carti");
                    r.writeTextFile();
                    r.writeBinary();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cnpTxt.Clear();
                    numeTxt.Clear();
                    dateTxt.CalendarFont = null;
                    emailTxt.Clear();
                    numartelTxt.Clear();
                    sexCb.Text = "";
                    numeCartetxt.Clear();
                    idCartetxt.Clear();
                    nrPaginitxt.Clear();
                    CarteInreg.Visible = false;
                    NumeCarte.Visible = false;
                    IdCarte.Visible = false;
                    PaginiCarte.Visible = false;
                    numeCartetxt.Visible = false;
                    idCartetxt.Visible = false;
                    nrPaginitxt.Visible = false;
                    button2.Visible = false;
                    label8.Visible = false;
                    nrCarte.Visible = false;
                    

                }
             }
               
        }

        

        //private void button1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    //if (!checkCNP(cnpTxt.Text))
        //    //{
        //    //    errorProvider1.SetError(cnpTxt, "Introduceti un CNP valid.");

        //    //}

        //    //else if (numeTxt.Text == "")
        //    //    errorProvider1.SetError(numeTxt, "Introduceti o nume!");
        //    //else if (dateTxt.Text == "")
        //    //    errorProvider1.SetError(dateTxt, "Introduceti o data valida:");
        //    //else if (!verificareEmail(emailTxt.Text))
        //    //{ 
        //    //        errorProvider1.SetError(emailTxt, "Introduceti un email valid!");
        //    // }

        //    //else if (!verificareNumar(numartelTxt.Text))
        //    //{
        //    //    errorProvider1.SetError(numartelTxt, "Introduceti un numar de telefon valid!");
        //    //}
        //}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CarteInreg.Visible = true;
            NumeCarte.Visible = true;
            IdCarte.Visible = true;
            PaginiCarte.Visible = true;
            numeCartetxt.Visible = true;
            idCartetxt .Visible = true; 
            nrPaginitxt.Visible = true;
            label8.Visible = true;
            nrCarte.Visible = true;
            button2.Visible = true;
               
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CarteInreg.Visible = false;
            NumeCarte.Visible = false;
            IdCarte.Visible = false;
            PaginiCarte.Visible = false;
            numeCartetxt.Visible = false;
            idCartetxt.Visible = false;
            nrPaginitxt.Visible = false;
            label8.Visible = false;
            nrCarte.Visible = false;
            button2.Visible = false;

        }
        private void numeCartetxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void idCartetxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nrPaginitxt_TextChanged(object sender, EventArgs e)
        {
            
        }

       public bool checkCNP(string cnp)
        {
            if (cnp.Length == 13 && cnp != "")
                return false;
            else return true;
        }
        private void cnpTxt_TextChanged(object sender, EventArgs e)
        {



        }
            
        private void numeTxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTxt_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numartelTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void cnpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar>='0' && e.KeyChar<='9'||e.KeyChar==(char)8)
                e.Handled = false;
            else e.Handled= true;
        }

        private void cnpTxt_Validating(object sender, CancelEventArgs e)
        {
            if (checkCNP(cnpTxt.Text)==true)
            {
                MessageBox.Show("CNP are 13 cifre!");
                cnpTxt.Clear();
            }
        }

        public void numeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >='a' && e.KeyChar<='z'|| e.KeyChar == (char)8||e.KeyChar==(char)32)
                e.Handled = false;
            else e.Handled = true;
        }

        private void emailTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        
       public bool validareData(DateTime data)
        {
            if (data > DateTime.Now)
            {
                return true;
            }
            int ani = (DateTime.Now.Year - data.Year);
            if (ani < 15)
            {
                return true;
            }
            else return false;
        }
        public void dateTxt_Validating(object sender, CancelEventArgs e)
        {
            if (validareData(this.dateTxt.Value) == true)
            {
                MessageBox.Show("Introduceti o data valida!\nVarsta mai mare decat 14 ani!");
                dateTxt.CalendarFont = Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            contor = Convert.ToInt32(nrCarte.Text);
          
           
                b.Name = numeCartetxt.Text;
                b.Id = Convert.ToInt32(idCartetxt.Text);
                b.NrPages = Convert.ToInt32(nrPaginitxt.Text);
                r += b;
                numeCartetxt.Clear();
                idCartetxt.Clear();
                nrPaginitxt.Clear();
            
           
        }
        public bool verificareEmail(string email)
        {
            if (email.Contains("@") && email.Contains(".com") && email != "")
                return false;
            else return true;
        }
        public void emailTxt_Validating(object sender, CancelEventArgs e)
        {
            if (verificareEmail(emailTxt.Text)==true)
            {
                MessageBox.Show("Emailul nu este valid! (Introduceti @ si '.com'.!)");
            }
        }

        public  bool Number(string text)
        {
            return text.Any(char.IsDigit);
        }
      
        public void numartelTxt_Validating(object sender, CancelEventArgs e)
        {
            if (Number(numartelTxt.Text) == false)
            {
               MessageBox.Show("Introduceti doar numere, nu cifre!");
            }
               
            if(numartelTxt.Text.Length!=10)
                MessageBox.Show("Un numar are doar 10 cifre! Introduceti un numar corect.");
        }
    }
}

