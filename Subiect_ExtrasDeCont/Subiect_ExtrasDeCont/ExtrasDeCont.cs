using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_ExtrasDeCont
{
    public class ExtrasDeCont:ITranzactie,ICloneable
    {
        private string numeClient;
        private string adresa;
        private List<Tranzactie> tranzactii;

        public ExtrasDeCont(string numeClient, string adresa, List<Tranzactie> tranzactii)
        {
            this.numeClient = numeClient;
            this.adresa = adresa;
            this.tranzactii = tranzactii;
        }

        public string NumeClient { get => numeClient; set => numeClient = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public List<Tranzactie> Tranzactii { get => tranzactii; set => tranzactii = value; }

        public Tranzactie this[int index]
        {
            get { return tranzactii[index];  }
            set { tranzactii[index]  = value; } 
        }

        public static explicit operator double(ExtrasDeCont e)
        {
            float sum = 0.0f;
            foreach (Tranzactie t in e.tranzactii)
            {
                sum += t.Suma;
            }
            return sum/e.Tranzactii.Count;
        }

        public static implicit operator int(ExtrasDeCont e)
        {
            return e.tranzactii.Count;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void afisareTranzactei()
        {
            throw new NotImplementedException();
        }
    }
}
