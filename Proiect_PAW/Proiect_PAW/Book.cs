using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Book
    {
        private string name;
        private int nrPages;
        private int id;
       // private bool available;

        public string Name { get => name; set => name = value; }
        public int NrPages { get => nrPages; set => nrPages = value; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

       // public bool Available { get => available; set => available = value; }

        public Book(string name, int nrPages, int id, bool available)
        {
            this.name = name;
            this.nrPages = nrPages;
            this.id = id;
            //this.available = available;
        }
        public Book(string name, int nrPages, int id)
        {
            this.name = name;
            this.nrPages = nrPages;
            this.id = id;
            
        }
        public Book()
        {

        }
        public Book(Book b)
        {
            this.name = b.name;
            this.nrPages = b.nrPages;
            this.id = b.id;
            //this.available=b.available;
        }

        public void makeitAvailable(bool available)
        {
           // this.available = available;
        }

        public void makeitUnavailable(bool unavailable)
        {
           // this.available=unavailable;
        }

        public override bool Equals(Object other)
        {
            Book aux=(Book)other;
            if (this.id ==aux.id)
                return true;
            else return false;
        }

        public override string ToString()
        {
            string rezultat = "Carte:" + Environment.NewLine + "Id:" + id + " Nume:" + name + Environment.NewLine + " Nr pagini:" + nrPages + Environment.NewLine;

            return rezultat;
        }
    }
}
