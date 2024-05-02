using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class AfisareDate : Form
    {
        string path;
        public AfisareDate()
        {
            InitializeComponent();
            path = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Imprumuturi.accdb;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "stud")
            {
                listView1.Visible = true;
               
                OleDbConnection connection = new OleDbConnection(path);
                try
                {
                    connection.Open();
                    OleDbCommand comm = new OleDbCommand();
                    comm.CommandText = "SELECT * FROM Imprumuturi";
                    comm.Connection = connection;
                    OleDbDataReader reader = comm.ExecuteReader();  
                    while (reader.Read()) {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Nume"].ToString());
                        item.SubItems.Add(reader["Student"].ToString());
                        item.SubItems.Add(reader["CNP"].ToString());
                        item.SubItems.Add(reader["Nume Carte"].ToString());
                        item.SubItems.Add(reader["ISBN"].ToString() );
                        item.SubItems.Add(reader["Numar Pagini"].ToString());
                        item.SubItems.Add(reader["Id Student"].ToString());
                        item.SubItems.Add(reader["Facultate"].ToString()) ; 

                        listView1.Items.Add(item);

                    }
                    reader.Close();
                }
                catch(Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                  //textBox1.Clear();
                }

            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(path);
            try
            {
                con.Open();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = con;
                foreach(ListViewItem item in listView1.Items)
                {
                    if (item.Selected)
                    {
                        int id = (int)Convert.ToInt64(item.SubItems[0].Text);
                        comm.CommandText = "DELETE FROM Imprumuturi WHERE Id=" + id;
                        comm.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
                listView1.Items.Clear();
                button1_Click(sender, e);

            }
        }
    }
}
