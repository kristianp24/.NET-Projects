using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Medici
{
    public class Medic
    {
        private readonly int codM;
        private string nume;
        private string specialitate;

        public Medic(int codM, string nume, string specialitate)
        {
            this.codM = codM;
            this.nume = nume;
            this.specialitate = specialitate;
        }

        public int CodM => codM;

        public string Nume { get => nume; set => nume = value; }
        public string Specialitate { get => specialitate; set => specialitate = value; }

        public override string ToString()
        {
            return "Cod mdic:" + codM + " Nume:" + nume + " Specialitate:" + specialitate;
        }
    }
}
