using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proiect_PAW
{
     public class Reader:IioFile
    {
        private string name;
        private  string ID;
        DateTime bday;
        private string email;
        private string phoneNumber;
        private char sex;
        private bool hasBook;
        private List<Book> books =new List<Book>();
        
        public Reader()
        {
            name = "Anonim";
            ID = "";
            bday = DateTime.Now;
            email = "None";
            phoneNumber = "None";
            sex = '\0';
        }

       public Reader(string id)
        {
            this.ID = id;
        }

        public Reader(string name,string id,DateTime bday,string email,string phoneNumber,char sex)
        {
            if(name!=null)
            this.name = name;

            this.ID = id;
            
            this.bday = bday;
            if(email!=null)
            this.email = email;
            if(phoneNumber!=null)
                this.phoneNumber = phoneNumber;
            this.sex = sex;
            
        }


        public Reader(string name, string id, DateTime bday, string email, string phoneNumber, char sex, bool hasBook, List<Book> books)
        {
            if (name != null)
                this.name = name;

            this.ID = id;

            this.bday = bday;
            if (email != null)
                this.email = email;
            if (phoneNumber != null)
                this.phoneNumber = phoneNumber;
            this.sex = sex;

            this.hasBook = hasBook;
            if (books.Count > 0)
            {
                foreach (Book b in books)
                    this.books.Add(b);
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }

        }
        public DateTime Bday
        {
            get { return bday; }
            set { bday = value; }
        }

        public string Id
        {
            get { return this.ID; }
            set { ID = value; }
        }

        public char Sex { get => sex; set => sex = value; }
        public bool HasBook { get => hasBook; set => hasBook = value; }
        public List<Book> Books { get => books; set => books = value; }

        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index <= books.Count)
                {
                    return books[index];
                }
                else return null;
            }
            set
            {
                if (index > books.Count && index>0&&value!=null)
                    books.Add(value);
                
            }
        }

        public static Reader operator+ (Reader r,Book toAdd)
        {
            r.books.Add(toAdd);
            return r;
        }

        public void AddBook(Book toAdd)
        {
            this.books.Add(toAdd);
        }
        public static Reader operator-(Reader r,Book toRemove)
        {
            foreach(Book b in r.books)
            {
                if (b.Equals(toRemove))
                    r.books.Remove(toRemove);

            }
           
            return r;
        }



        public void writeTextFile()
        {
            StreamWriter write = new StreamWriter("Cititorii.txt",true);
            write.WriteLine(name);
            write.WriteLine(Id);
            write.WriteLine(bday);
            write.WriteLine(email);
            write.WriteLine(phoneNumber);
            write.WriteLine(sex);
            write.WriteLine(hasBook ? "true" : "false");
            if (books.Count > 0)
            {
                foreach (Book b in books)
                {
                   write.WriteLine(b);

                }
                    
            }
            write.Close();

        }

        public void  readTextFile()
        {
            MessageBox.Show("Nu se citeste informatiile personale!");
        }



        public override string ToString()
        {
            string rezultat = "Id:" + Convert.ToString(ID) + Environment.NewLine + "Nume:" + name + " Ziua de nastere: " + Convert.ToString(bday) + Environment.NewLine + "Email:" + email +
                              Environment.NewLine + "Numar telefon:" + phoneNumber + Environment.NewLine + "Sex:" + Convert.ToString(sex) + Environment.NewLine;
            if (hasBook == true)
            {
                rezultat += "Da,are carte";
                rezultat += Environment.NewLine;
                if (books != null)
                {
                    for (int i = 0; i < books.Count; i++)
                    {
                        rezultat += books[i].ToString();
                    }
                }
            }
            else rezultat += "Nu are carte";

            return rezultat;
        }

        public void writeBinary()
        {
            FileStream f=new FileStream("Carti.bin",FileMode.Append,FileAccess.Write);
            BinaryFormatter bw = new BinaryFormatter();
            
            for(int i = 0; i < Books.Count; i++)
            {
                bw.Serialize(f, this.Books[i]);
            }
           
            f.Close();
        }
    }
}
