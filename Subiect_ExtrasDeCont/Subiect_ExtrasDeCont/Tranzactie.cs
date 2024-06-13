using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_ExtrasDeCont
{
    public class Tranzactie
    {
        private readonly int idTranzactie;
        private string contIBAN;
        private string detaliiTranzactie;
        private float suma;
        private string dataTranzactie;

        public Tranzactie(int idTranzactie, string contIBAN, string detaliiTranzactie, float suma, string dataTranzactie)
        {
            this.idTranzactie = idTranzactie;
            this.contIBAN = contIBAN;
            this.detaliiTranzactie = detaliiTranzactie;
            this.suma = suma;
            this.dataTranzactie = dataTranzactie;
        }

        public int IdTranzactie => idTranzactie;

        public string ContIBAN { get => contIBAN; set => contIBAN = value; }
        public string DetaliiTranzactie { get => detaliiTranzactie; set => detaliiTranzactie = value; }
        public float Suma { get => suma; set => suma = value; }
        public string DataTranzactie { get => dataTranzactie; set => dataTranzactie = value; }

        public override string ToString()
        {
            return "Id:" + idTranzactie + " IBAN:" + contIBAN + " Detalii:" + detaliiTranzactie + " Suma:" + suma + " Data:" + dataTranzactie;

        }
    }
}
