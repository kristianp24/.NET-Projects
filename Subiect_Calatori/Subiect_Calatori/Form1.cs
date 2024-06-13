using Subiect_Calatori;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Subiect_Calatori
{
    public partial class Form1 : Form
    {
        private List<Calatorie> listaCalatori;
        private List<CardTransport> listaCardTransport; 
        public Form1()
        {
            InitializeComponent();
            listaCalatori = new List<Calatorie>();  
            listaCardTransport = new List<CardTransport>(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader("carduri.txt");
                while(reader.EndOfStream == false)
                {
                    String linie = reader.ReadLine();
                    if (linie != null)
                    {
                        int cod = Convert.ToInt32(linie.Split(',')[0]);
                        string nume = linie.Split(',')[1];
                        float sold = (float)Convert.ToDouble(linie.Split(',')[2]);
                        listaCardTransport.Add(new CardTransport(cod, nume, sold));
                    }
                }
                reader.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Datele de carduri incarcate!");
            }

            try
            {
                StreamReader reader = new StreamReader("calatorii.txt");
                while (reader.EndOfStream == false)
                {
                    String linie = reader.ReadLine();
                    if (linie != null)
                    {
                        int cod = Convert.ToInt32(linie.Split(',')[0]);
                        float cost = (float)Convert.ToDouble(linie.Split(',')[1]);
                        int nrAutobuz = Convert.ToInt32(linie.Split(',')[2]);
                        listaCalatori.Add(new Calatorie(cod, cost, nrAutobuz));
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Datele de calatorii incarcate!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode("Carduri");
            treeView1.Nodes.Add(root);
            foreach(CardTransport t in listaCardTransport)
            {
                TreeNode parinte = new TreeNode("Cardul:"+t.ToString());
               
                root.Nodes.Add(parinte);
                foreach (Calatorie c in listaCalatori)
                {
                    if(c.CodCard == t.CodCard)
                    {
                        TreeNode copil  = new TreeNode("Calatorie:" + c.ToString());
                        parinte.Nodes.Add(copil);
                    }
                    
                }
                
            }
            treeView1.ExpandAll();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            TreeNode nodSelctat = treeView1.SelectedNode;
            
            int cod = Convert.ToInt32((nodSelctat.Text.Split(':')[2]).Split(' ')[0]);
            float sum = 0.0f;
            foreach(Calatorie c in listaCalatori)
            {
                if(c.CodCard == cod)
                {
                    sum += c.Valaore;
                    listBox1.Items.Add(c.NrAutobuz);
                }
            }
            textBox1.Text += sum.ToString();
         }

        private void button3_Click(object sender, EventArgs e)
        {
            float sum = 0.0f;
            foreach(CardTransport c in listaCardTransport)
            {
                sum += c;
            }
            textBox2.Text += sum.ToString();
         }

        private void button4_Click(object sender, EventArgs e)
        {
            
            MemoryStream mem = new MemoryStream();
            XmlTextWriter xmlText = new XmlTextWriter(mem,Encoding.UTF8);
            xmlText.Formatting = Formatting.Indented;   

            xmlText.WriteStartDocument();
            xmlText.WriteStartElement("Carduri");

            foreach(CardTransport c in listaCardTransport)
            {
                xmlText.WriteStartElement("Card");

                xmlText.WriteStartElement("Cod");
                xmlText.WriteValue(c.CodCard.ToString());
                xmlText.WriteEndElement();

                xmlText.WriteStartElement("Nume");
                xmlText.WriteValue(c.NumeUtilizator);
                xmlText.WriteEndElement();

                xmlText.WriteStartElement("Sold");
                xmlText.WriteValue(c.Sold.ToString());
                xmlText.WriteEndElement();

                xmlText.WriteEndElement();
            }

            xmlText.WriteEndElement();
            xmlText.WriteEndDocument();
            xmlText.Close();

            string str = Encoding.UTF8.GetString(mem.ToArray());
            mem.Close();

            StreamWriter writer = new StreamWriter("carduri.xml");
            writer.WriteLine(str);
            writer.Close();

            MessageBox.Show("Fisierul carduri.xml creat!!");
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream();
            XmlTextWriter xmlWriter = new XmlTextWriter(mem, Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Calatorii");
            foreach(Calatorie c in listaCalatori)
            {
                xmlWriter.WriteStartElement("Calatorie");

                xmlWriter.WriteStartElement("Cod_Card");
                xmlWriter.WriteValue(c.CodCard.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Tarif");
                xmlWriter.WriteValue(c.Valaore.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Autobuz");
                xmlWriter.WriteValue(c.NrAutobuz.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();

            string info = Encoding.UTF8.GetString(mem.ToArray());
            mem.Close();

            StreamWriter writer = new StreamWriter("calatorii.xml");
            writer.WriteLine(info);
            writer.Close();

            MessageBox.Show("Fisierul calatorii.xml creat!!");
        }
    }
}

