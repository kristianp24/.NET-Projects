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
            timer1.Start();
        }

      

    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void inregistrareSimplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InregistrareForm inregistrare=new InregistrareForm();
            inregistrare.Show();

        }

       

        private void imprumutCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprumutForm imprumut = new ImprumutForm();
            imprumut.Show();
        }


        List<String> carti = new List<string>();
        private void vizualizareCartiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

            //Citim datele din fisier
            FileStream f = new FileStream("imprumuturi.bin",FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(f);
            String name = null;
            try
            { 
                while((name = br.ReadString()) != null){
                      carti.Add(name);
               
                }

            }catch(EndOfStreamException ex)
            {

            }
           
            br.Close();

            //Ordonam datele dupa cate ori au aparute in Lista
            var ap = carti.GroupBy(x => x).
                Select(carte => new { nume = carte.Key, contor = carte.Count() });

            //Transformam informatia intr un map care contine numele si cate ori e imprumutata cartea
            Dictionary<String, int> infoUtila= new Dictionary<string, int>();
            infoUtila = ap.ToDictionary(a => a.nume,a=>a.contor);

            //Cream graful
            AfisareCarti afiseaza = new AfisareCarti(infoUtila);
           
            afiseaza.Show();
        }

        private void contStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InregistrareStudent student = new InregistrareStudent();
            student.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = DateTime.Now.ToString();
        }
    }
}
