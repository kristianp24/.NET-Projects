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
using System.Xml;
using System.Xml.Linq;

namespace Subiect_Medici
{
    public partial class Form1 : Form
    {
        private  List<Medic> listaMedici;
        private List<Pacient> listaPacient;
        String connPath;
        public Form1()
        {
            InitializeComponent();
            listaMedici = new List<Medic>(); 
            listaPacient = new List<Pacient>();
            connPath = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Pacienti.accdb";
        }

     

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9'||e.KeyChar ==(char)8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' )
            {
                e.Handled = true;
            }
            else e.Handled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Introduceti un cod!");
            else if (textBox2.Text == "")
                errorProvider1.SetError(textBox2, "Introduceti o nume!");
            else if (textBox3.Text == "")
                errorProvider1.SetError(textBox3, "Introduceti o specializare");
            else
            {
                errorProvider1.Clear();

                try
                {
                    int cod = Convert.ToInt32(textBox1.Text);
                    String nume = textBox2.Text;
                    String specialitate = textBox3.Text;
                    listaMedici.Add(new Medic(cod,nume, specialitate));

                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }
                finally
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    
                }

            }

           
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar =='.'||e.KeyChar==','||e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else e.Handled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                errorProvider1.SetError(textBox4, "Introduceti un cod de pacient!");
            else if (textBox5.Text == "")
                errorProvider1.SetError(textBox5, "Introduceti numele pacientului");
            else if (textBox6.Text == "")
                errorProvider1.SetError(textBox6, "Introduceti tariful!");
            else if (textBox7.Text == "")
                errorProvider1.SetError(textBox7, "Introduceti codul medicului");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int codP = Convert.ToInt32(textBox4.Text);
                    string nume = textBox5.Text;
                    float tarif = (float)Convert.ToDouble(textBox6.Text);
                    int codMedic = Convert.ToInt32(textBox7.Text);
                    listaPacient.Add(new Pacient(codP, nume, tarif, codMedic));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            foreach(Medic m in listaMedici)
            {
                TreeNode root = new TreeNode("Medic");
                root.Nodes.Add("Id:" + m.CodM);
                root.Nodes.Add("Nume:" + m.Nume);
                root.Nodes.Add("Specialitate:" + m.Specialitate);
                treeView1.Nodes.Add(root);
                foreach(Pacient p in listaPacient)
                {
                    if(p.CodM == m.CodM)
                    {
                        TreeNode child = new TreeNode("Pacient");
                        child.Nodes.Add("Id:" + p.CodP);
                        child.Nodes.Add("Nume:" + p.Nume);
                        child.Nodes.Add("Tarif:" + p.Tarif);
                        root.Nodes.Add(child);  
                    }
                }
            }
            treeView1.ExpandAll();
            salvareXMLMedici();
           salvareXMLPacienti();
        }

        public void salvareXMLPacienti()
        {
            MemoryStream memory = new MemoryStream();   
            XmlTextWriter xmlWriter = new XmlTextWriter(memory, Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented; 

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Pacienti");
            foreach(Pacient p in listaPacient)
            {
                xmlWriter.WriteStartElement("Pacient");
                xmlWriter.WriteStartElement("Id");
                xmlWriter.WriteValue(p.CodP);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Nume");
                xmlWriter.WriteValue(p.Nume);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Tarif");
                xmlWriter.WriteValue(p.Tarif);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            String str = Encoding.UTF8.GetString(memory.ToArray());
           
            memory.Close();

            StreamWriter writer = new StreamWriter("Pacienti.xml");
            writer.WriteLine(str);
            writer.Close();
            MessageBox.Show("Fisierul pacienti.xml creat!");
            
        }

        public void salvareXMLMedici()
        {
            MemoryStream memory = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memory, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("Medici");
            TreeNodeCollection nodes = treeView1.Nodes;
            for(int i=0;i<nodes.Count;i++)
            {
                TreeNode node = nodes[i];   
                writer.WriteStartElement("Medic");
                writer.WriteStartElement("Id");
                writer.WriteValue(node.Nodes[0].Text.Split(':')[1]);
                writer.WriteEndElement();
                writer.WriteStartElement("Nume");
                writer.WriteValue(node.Nodes[1].Text.Split(':')[1]);
                writer.WriteEndElement();
                writer.WriteStartElement("Specialitate");
                writer.WriteValue(node.Nodes[2].Text.Split(':')[1]);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            String str = Encoding.UTF8.GetString(memory.ToArray());
            memory.Close();

            StreamWriter fileWriter = new StreamWriter("Medici.xml");
            fileWriter.WriteLine(str);
            fileWriter.Close();
            MessageBox.Show("Fisierul Medici.xml generat!");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double sum = 0.0;
            TreeNode selected = treeView1.SelectedNode;
            foreach(TreeNode nod in selected.Nodes)
            {
                if (nod.Text.Equals("Pacient"))
                {
                    TreeNode subNode = nod;
                  //  string txt = subNode.Text;
                    foreach(TreeNode aux in subNode.Nodes)
                    {
                        string str = aux.Text;
                        if (str.Split(':')[0].Equals("Tarif"))
                            sum = sum + Convert.ToDouble(str.Split(':')[1]);  
                    }
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Medici formMedici = new Medici(listaMedici,listaPacient);
            formMedici.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connPath);
            OleDbCommand command = new OleDbCommand();

            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Pacienti Values (?,?,?,?)";
                foreach(Pacient p in listaPacient)
                {
                    command.Parameters.Add("CodP", OleDbType.Integer).Value = p.CodP;
                    command.Parameters.Add("CodM", OleDbType.Integer).Value = p.CodM;
                    command.Parameters.Add("Nume", OleDbType.VarChar, 30).Value = p.Nume;
                    command.Parameters.Add("Tarif", OleDbType.Numeric).Value = p.Tarif;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }


            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                MessageBox.Show("Datele salvate cu succes!");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AfisareBd form3 = new AfisareBd();
            form3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            double sum = 0.0;
            TreeNode selected = treeView1.SelectedNode;
            foreach (TreeNode nod in selected.Nodes)
            {
                if (nod.Text.Equals("Pacient"))
                {
                    TreeNode subNode = nod;
                    //  string txt = subNode.Text;
                    foreach (TreeNode aux in subNode.Nodes)
                    {
                        string str = aux.Text;
                        if (str.Split(':')[0].Equals("Tarif"))
                            sum = sum + Convert.ToDouble(str.Split(':')[1]);
                    }
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            double sum = 0.0;
            TreeNode selected = treeView1.SelectedNode;
            foreach (TreeNode nod in selected.Nodes)
            {
                if (nod.Text.Equals("Pacient"))
                {
                    TreeNode subNode = nod;
                    //  string txt = subNode.Text;
                    foreach (TreeNode aux in subNode.Nodes)
                    {
                        string str = aux.Text;
                        if (str.Split(':')[0].Equals("Tarif"))
                            sum = sum + Convert.ToDouble(str.Split(':')[1]);
                    }
                }
            }
        }
    }
}
