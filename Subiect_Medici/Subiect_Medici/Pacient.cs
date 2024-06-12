using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Medici
{
    public class Pacient:IComparable
    {
        private readonly int codP;
        private readonly int codM;
        private string nume;
        private float tarif;

        public Pacient(int codP, string nume, float tarif,int codM)
        {
            this.codP = codP;
            this.nume = nume;
            this.tarif = tarif;
            this.codM = codM;
        }

        public int CodP => codP;

        public string Nume { get => nume; set => nume = value; }
        public float Tarif { get => tarif; set => tarif = value; }

        public int CodM => codM;

        public int CompareTo(object obj)
        {
            Pacient p = (Pacient)obj;
            if (obj == null) return -2;
            else if (this.tarif < p.tarif)
                return 1;
            else if (this.tarif > p.tarif)
                return -1;
            else return 0;
        }

        public override string ToString()
        {
            return "Pacient:" + nume + " Tarif:" + tarif + " Cod medic:" + codM;
        }
    }
}
