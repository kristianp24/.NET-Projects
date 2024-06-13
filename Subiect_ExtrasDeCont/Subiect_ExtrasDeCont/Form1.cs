using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_ExtrasDeCont
{
    public partial class Form1 : Form
    {
        private List<Tranzactie> tranzactii;
        private List<ExtrasDeCont> extrasDeConts;
        String connPath;
        public Form1()
        {
            InitializeComponent();
            tranzactii = new List<Tranzactie>();
            extrasDeConts = new List<ExtrasDeCont>();
            connPath = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=ExtrasDeCont.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader("Tranzactii.txt");
                while(reader.EndOfStream == false)
                {
                    String linie = reader.ReadLine();
                    int cod = Convert.ToInt32(linie.Split(',')[0]);
                    string iban = linie.Split(',')[1];
                    string denTranz = linie.Split(',')[2];
                    float suma = (float)Convert.ToDouble(linie.Split(',')[3]);
                    string data = linie.Split(',')[4];
                    tranzactii.Add(new Tranzactie(cod, iban, denTranz, suma, data));
                }
                reader.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                StreamReader reader = new StreamReader("Extras.txt");
               // int i = 1;
                while (reader.EndOfStream == false)
                {
                    String linie = reader.ReadLine();
                    string nume = linie.Split(',')[0];
                    string adresa = linie.Split(',')[1];
                    extrasDeConts.Add(new ExtrasDeCont(nume, adresa,tranzactii));

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);        
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ExtrasDeCont ex in extrasDeConts)
            {
                foreach(Tranzactie t in ex.Tranzactii)
                {
                    ListViewItem item = new ListViewItem(ex.NumeClient);
                    item.SubItems.Add(ex.Adresa);
                    item.SubItems.Add(t.IdTranzactie.ToString());
                    item.SubItems.Add(t.ContIBAN);
                    item.SubItems.Add(t.DetaliiTranzactie);
                    item.SubItems.Add(t.Suma.ToString());
                    item.SubItems.Add(t.DataTranzactie);
                    listView1.Items.Add(item);
                }
               

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String fisier = textBox1.Text;
            try
            {
                
                StreamWriter writer = new StreamWriter(fisier);
                foreach(ExtrasDeCont ex in extrasDeConts)
                {
                    writer.Write(ex.NumeClient+","+ex.Adresa+",");
                    foreach(Tranzactie t in ex.Tranzactii)
                    {
                        writer.Write(t.IdTranzactie+","+t.ContIBAN+","+t.DetaliiTranzactie+","+t.Suma.ToString()+","+t.DataTranzactie);    
                    }
                    writer.Write(Environment.NewLine);
                }
                writer.Close(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Fisierul " + fisier + " creat!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = null;
            String sqlInsert = "Insert into ExtrasDeCont(Nume,Adresa,IdTranzactie,IBAN,Detalii,Suma,Data) values (?,?,?,?,?,?,?)";
            try
            {
                connection = new OleDbConnection(connPath);
                //Deschidem conexiunea
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = sqlInsert;
                foreach(ExtrasDeCont ex in extrasDeConts)
                {
                    foreach(Tranzactie t in ex.Tranzactii)
                    {
                        command.Parameters.Add("Nume", OleDbType.VarChar, 20).Value = ex.NumeClient;
                        command.Parameters.Add("Adresa", OleDbType.VarChar, 20).Value = ex.Adresa;
                        command.Parameters.Add("IdTranzactie", OleDbType.Integer).Value = t.IdTranzactie;
                        command.Parameters.Add("IBAN", OleDbType.VarChar, 20).Value = t.ContIBAN;
                        command.Parameters.Add("Detalii", OleDbType.VarChar, 20).Value = t.DetaliiTranzactie;
                        command.Parameters.Add("Suma", OleDbType.Numeric).Value = t.Suma;
                        command.Parameters.Add("Data", OleDbType.VarChar, 20).Value = t.DataTranzactie;
                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                   
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                MessageBox.Show("Datele salvate in Baza de Date");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection connection = null;
            try
            {
                connection = new OleDbConnection(connPath);
                connection.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = connection;
                comm.CommandText = "Select * from ExtrasDeCont";
                OleDbDataReader reader = comm.ExecuteReader();
                while(reader.Read()) { 
                  ListViewItem item = new ListViewItem(reader["Nume"].ToString());
                    item.SubItems.Add(reader["Adresa"].ToString());
                    item.SubItems.Add(reader["IdTranzactie"].ToString());
                    item.SubItems.Add(reader["IBAN"].ToString());
                    item.SubItems.Add(reader["Detalii"].ToString());
                    item.SubItems.Add(reader["Suma"].ToString());
                    item.SubItems.Add(reader["Data"].ToString());   
                    listView1.Items.Add(item);
                }


            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        
    }
}
