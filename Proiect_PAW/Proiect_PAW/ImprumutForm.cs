using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_PAW
{
    public partial class ImprumutForm : Form
    {
        InregistrareForm form1 = new InregistrareForm();
        Imprumut imprumut = new Imprumut();
       
        int contor;
        public ImprumutForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            form1.numeTxt_KeyPress(this, e);
        }

        private void nrCarti_KeyPress(object sender, KeyPressEventArgs e)
        {
            form1.cnpTxt_KeyPress(this, e); 
        }

        private void radioButtonDa_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            facultateTxt.Visible = true;
            idStudtxt.Visible = true;
        }

        private void radioButtonNu_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            facultateTxt.Visible = false;
            idStudtxt.Visible = false;
        }

        Reader r1 = new Reader();
        private void adaugaCartea_Click(object sender, EventArgs e)
        {
            try
            {
                if (numeCartetxt.Text == "")
                errorProvider1.SetError(numeCartetxt, "Inroduceti numele de carte!");
               else if (idCartetxt.Text == "")
                errorProvider1.SetError(idCartetxt, "Introduceti id-ul de carte!");
               else if (nrPaginitxt.Text == "")
                errorProvider1.SetError(nrPaginitxt, "Introduceti numarul de pagini!");
                //Book b = new Book();
                //b.Name = numeCartetxt.Text;
                // b.Id = Convert.ToInt32(idCartetxt.Text);
                //b.NrPages = Convert.ToInt32(nrPaginitxt.Text);
                imprumut.Book = new Book();
                imprumut.Book.Name = numeCartetxt.Text;
                imprumut.Book.Id = Convert.ToInt32(idCartetxt.Text);
                imprumut.Book.NrPages = Convert.ToInt32(nrPaginitxt.Text);
               
                //r1.AddBook(b);
                //if (radioButtonDa.Checked == true)
                //{
                //    Reader r1 = (Reader)imprumut.Stud;

                //    r1.AddBook(imprumut.Book);
                //   // imprumut.Stud.writeBinary();
                //}
                //else
                    imprumut.Reader.AddBook(imprumut.Book);
                
                imprumut.writeBinary();
               

            }
            catch(Exception ex) { 
            
            }
            finally
            {
                numeCartetxt.Clear();
                idCartetxt.Clear();
                nrPaginitxt.Clear();
                
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Introduceti o nume!");
            else if (nrCarti.Text == "")
                errorProvider1.SetError(nrCarti, "Introduceti numarul de carti!");
            else if (idStudtxt.Text == ""&& idStudtxt.Visible==true)
                errorProvider1.SetError(idStudtxt, "Introduceti un Id de student!");
            else if (facultateTxt.Text == ""&& facultateTxt.Visible==true)
                errorProvider1.SetError(facultateTxt, "Introduceti facultatea!");
          
            else
            {
                try
                {
                    if(radioButtonDa.Checked == true)
                    {
                        string name = textBox1.Text;
                        string id = idStudtxt.Text;
                        string cnp = cnpTxt.Text;
                        string facultate= facultateTxt.Text;
                        

                        imprumut.Stud.Id = cnp;
                        imprumut.Stud.Name=name;
                        imprumut.Stud.IdStudent=id;
                        imprumut.Stud.University = facultate;
                        contor = Convert.ToInt32(nrCarti.Text);
                        string viewStud=imprumut.writeStudent()+Environment.NewLine;
                        for(int i = 0; i < imprumut.Reader.Books.Count; i++)
                        {
                            viewStud += imprumut.Reader.Books[i].ToString();
                        }
                        MessageBox.Show(viewStud);
                       
                        
                        
                    }
                    else if(radioButtonNu.Checked == true)
                    {
                        string name = textBox1.Text;
                        string cnp = cnpTxt.Text;

                        imprumut.Reader.Id = cnp;
                        imprumut.Reader.Name = name;
                        contor = Convert.ToInt32(nrCarti.Text);
                        string viewReader = imprumut.writeReader();
                        for (int i=0;i< imprumut.Reader.Books.Count; i++) {
                            viewReader += imprumut.Reader.Books[i].ToString();
                        }
                        MessageBox.Show(viewReader);
                    }
                    imprumut.writeTextFile();
                   
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    textBox1.Clear();
                    idStudtxt.Clear();
                    cnpTxt.Clear();
                    facultateTxt.Clear();
                    nrCarti.Clear();
                    radioButtonDa.Checked = false;
                    radioButtonNu.Checked = false;
                    idStudtxt.Visible = false;
                    facultateTxt.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                }

            }

        }

        private void cnpTxt_Validating(object sender, CancelEventArgs e)
        {
            if (form1.checkCNP(cnpTxt.Text) == true)
            {
                MessageBox.Show("CNP are 13 cifre!");
                cnpTxt.Clear();
            }
        }
    }
}
