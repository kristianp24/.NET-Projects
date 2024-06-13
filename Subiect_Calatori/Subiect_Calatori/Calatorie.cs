using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Calatori
{
    public class Calatorie
    {
        private int codCard;
        private float valaore;
        private int nrAutobuz;

        public Calatorie(int codCard, float valaore, int nrAutobuz)
        {
            CodCard = codCard;
            Valaore = valaore;
            NrAutobuz = nrAutobuz;
            
        }   

        public int CodCard { get => codCard; set => codCard = value; }
        public float Valaore { get => valaore; set => valaore = value; }
        public int NrAutobuz { get => nrAutobuz; set => nrAutobuz = value; }

        public override string ToString()
        {
            return "Cod Card:" + codCard + " Valoare:" + valaore + " Nr autobuz:" + nrAutobuz;
        }
    }
}
