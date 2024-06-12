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

namespace Subiect_Medici
{
    public partial class AfisareBd : Form
    {
       // private List<Pacient> pacienti;
        String connPath;
        String comand = "SELECT * FROM Pacienti";
        public AfisareBd()
        {
            InitializeComponent();
           // this.pacienti = pacienti;
            connPath = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Pacienti.accdb;";
            // Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Pacienti.accdb
            salvareBd(connPath);
        }

        public void salvareBd(string connPath)
        {
            OleDbConnection connection = new OleDbConnection(connPath);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandText = comand;
                command.Connection = connection;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["CodP"].ToString());
                    item.SubItems.Add(reader["CodM"].ToString());
                    item.SubItems.Add(reader["Nume"].ToString());
                    item.SubItems.Add(reader["Tarif"].ToString());
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
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
