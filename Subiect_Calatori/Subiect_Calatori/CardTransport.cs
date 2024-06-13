using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Calatori
{
    public class CardTransport
    {
        private readonly int codCard;
        private string numeUtilizator;
        private float sold;

        public CardTransport(int cod, string numeUtilizator, float sold)
        {
            codCard = cod;
            this.numeUtilizator = numeUtilizator;
            this.sold = sold;
        }

        public int CodCard => codCard;

        public string NumeUtilizator { get => numeUtilizator; set => numeUtilizator = value; }
        public float Sold { get => sold; set => sold = value; }

        public override string ToString()
        {
            return "Cod:" + codCard + " Nume Utiliz:" + numeUtilizator + " Sold:" + sold;
        }
        public static float operator +(float num, CardTransport c)
        {
            return (float)(num + c.Sold);
        }

        public static explicit operator double(CardTransport c)
        {
            return 5.5;
        }

      
    }
}
