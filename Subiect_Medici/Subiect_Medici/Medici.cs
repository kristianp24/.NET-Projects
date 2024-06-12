using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_Medici
{
    
    public partial class Medici : Form
    {
        private List<Medic> medics;
        private List<Pacient> pacients;
        public Medici(List<Medic> medics,List<Pacient> pacients)
        {
            InitializeComponent();
            this.medics = medics;   
            this.pacients = pacients;
            pacients.Sort((p1,p2)=> p1.CompareTo(p2));
            var pacientiDistinct = pacients.GroupBy(p => p.CodM).Select(group => group.First()).ToList(); 
            foreach(Pacient p in pacientiDistinct)
            {
                foreach(Medic medic in medics)
                {
                    if(p.CodM == medic.CodM)
                    {
                        textBox1.Text += medic.ToString()+" Tarif:"+p.Tarif;
                        textBox1.Text += Environment.NewLine;
                        break;
                    }
                   
                }
               
            }
        }

    }
}
