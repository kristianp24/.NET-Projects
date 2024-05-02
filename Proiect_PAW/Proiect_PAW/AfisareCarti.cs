using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class AfisareCarti : Form
    {
        Graphics gr;
        Dictionary<string, int> infoUtila;
        Color culoare = Color.Blue;
        Color culoareContur = Color.Turquoise;
        Font font = new Font(FontFamily.GenericSansSerif, 9);
        

        public AfisareCarti(Dictionary<string, int> info)
        {
            InitializeComponent();
            gr=panel1.CreateGraphics();
            panel1.Invalidate();
            infoUtila = info;
        }

        public void AfisareTxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        //public void scrieText()
        //{
        //    FileStream f = new FileStream("Carti.bin", FileMode.Open, FileAccess.Read);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    List<Book> imprumutat = new List<Book>();
        //    try
        //    {
                
        //        while (f.Position < f.Length)
        //        {
        //            Book book = (Book)bf.Deserialize(f);
        //            //AfisareTxt.AppendText(book.ToString());
        //            imprumutat.Add(book);
        //        }

        //        //foreach (Book b in imprumutat)
        //        //{
        //        //    AfisareTxt.AppendText(b.ToString());
        //        //}
        //    }
        //    catch (EndOfStreamException)
        //    {
                
        //    }
        //    finally
        //    {
        //        f.Close();

        //    }
        //}
        public void deleteText()
        {
          // AfisareTxt.Text = string.Empty;  
        }

        public void viewGraph(Dictionary<string,int> info)
        {
            
            
        }

        private void AfisareTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else e.Handled= true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            const int marg = 12;

            //Conturul
            Rectangle rect = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + 2*marg,
                                           panel1.ClientRectangle.Width - 2*marg, panel1.ClientRectangle.Height - 3 * marg);
            Pen pen = new Pen(culoareContur,2);
            gr.DrawRectangle(pen, rect);

            //Parametre pt grafurile
            int nrElemente = this.infoUtila.Count;
            double trashesi = rect.Width / nrElemente /2;
            double distanca =( rect.Width - (nrElemente * trashesi)) / (nrElemente + 1);
            int i = 1,distance = nrElemente+1,j=0;
            double maxValue = infoUtila.Values.Max();
            //Rectangle[] grafuri = new Rectangle[nrElemente];  
            foreach(var p in infoUtila)
            {

                Rectangle r= new Rectangle((int)(rect.Location.X+ i*distanca+j*trashesi),
                                           (int)(rect.Location.Y + rect.Height -(p.Value/maxValue)*rect.Height),
                                           (int)trashesi, (int)((p.Value / maxValue) * rect.Height));

                gr.DrawString(p.Key+"-"+p.Value, font, new SolidBrush(Color.Black),
                              new Point((int)(r.Location.X),
                                         (int)r.Location.Y-font.Height));
           
                i++;j++;
                gr.FillRectangle(new SolidBrush(culoare), r);
            
            }

            

                
              
        }

        private void schimbaCuloareConturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colors = new ColorDialog();
            if(colors.ShowDialog() == DialogResult.OK )
            {
                culoareContur = colors.Color;
            }
           panel1.Invalidate();
        }

        private void schimbaCuloareaGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colors =new ColorDialog();
            if(colors.ShowDialog()== DialogResult.OK ) { 
                culoare = colors.Color; 
            }
            panel1.Invalidate();
        }

        private void schimbaFontulDeScrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fonts = new FontDialog();
            if(fonts.ShowDialog()== DialogResult.OK)
            {
                font = fonts.Font;
            }
            panel1.Invalidate();
        }

        private void print_Document(object sender,PrintPageEventArgs e)
        {
            gr = e.Graphics;
            const int marg = 12;

            //Conturul
            Rectangle rect = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + 2 * marg,
                                           panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 3 * marg);
            Pen pen = new Pen(culoareContur, 2);
            gr.DrawRectangle(pen, rect);

            //Parametre pt grafurile
            int nrElemente = this.infoUtila.Count;
            double trashesi = rect.Width / nrElemente / 2;
            double distanca = (rect.Width - (nrElemente * trashesi)) / (nrElemente + 1);
            int i = 1, distance = nrElemente + 1, j = 0;
            double maxValue = infoUtila.Values.Max();
            //Rectangle[] grafuri = new Rectangle[nrElemente];  
            foreach (var p in infoUtila)
            {

                Rectangle r = new Rectangle((int)(rect.Location.X + i * distanca + j * trashesi),
                                           (int)(rect.Location.Y + rect.Height - (p.Value / maxValue) * rect.Height),
                                           (int)trashesi, (int)((p.Value / maxValue) * rect.Height));

                gr.DrawString(p.Key + "-" + p.Value, font, new SolidBrush(Color.Black),
                              new Point((int)(r.Location.X),
                                         (int)r.Location.Y - font.Height));

                i++; j++;
                gr.FillRectangle(new SolidBrush(culoare), r);

            }

        }

        private void printDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(print_Document);
            PrintPreviewDialog fereastra = new PrintPreviewDialog();
            fereastra.Document = doc;
            fereastra.ShowDialog();


        }
    }
}
//rect.Location.X + rect.Width - i * distanca - i * trashesi+distanca
//(int)(rect.Location.X + rect.Width + i * distanca + i * trashesi)
//Rectangle r = new Rectangle((int)(rect.Location.X + rect.Width + i * distanca + i * trashesi),
//                                           (int)(rect.Location.Y + rect.Height - (infoUtila[i].get));