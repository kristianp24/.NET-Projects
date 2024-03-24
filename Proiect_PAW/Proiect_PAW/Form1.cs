using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void reiinoreAbonamentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            MenuIntrare.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vizualizareCartiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inregistrareSimplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InregistrareForm inregistrare=new InregistrareForm();
            inregistrare.Show();

        }

        private void abonamentAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InregistrareStudent student=new InregistrareStudent();  
            student.Show();
        }

        private void imprumutCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprumutForm imprumut = new ImprumutForm();
            imprumut.Show();
        }

        private void vizualizareCartiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream f= new FileStream("Carti.bin",FileMode.Open,FileAccess.Read);
            BinaryFormatter bf= new BinaryFormatter();
            List<Book> imprumtat = (List<Book>)bf.Deserialize(f);
            foreach(Book b in imprumtat)
            {
                MessageBox.Show(b.ToString());
            }
            f.Close();

        }
    }
}
