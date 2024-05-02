using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proiect_PAW
{
    public class Student:Reader
    {
        private string university;
        private  string idStudent;

        public string University { get => university; set => university = value; }
        public string IdStudent { get => idStudent; set => idStudent = value; }

        public Student(string name, string id, DateTime bday, string email, string phoneNumber, char sex, string uni,
                          string idStud):base( name, id, bday, email, phoneNumber, sex)
        {
            this.university = uni;
            this.idStudent = idStud;
        }

        public Student() { }

        public override string ToString()
        {
            string rezultat = "Universitatea:" + university + Environment.NewLine + "Id student:" + idStudent + base.ToString();
            return rezultat;
        }

        public void writeTextFile()
        {
            StreamWriter write = new StreamWriter("Studenti.txt", true);
            write.WriteLine(university);
            write.WriteLine(idStudent);
            write.WriteLine(Name);
            write.WriteLine(Id);
            write.WriteLine(Bday);
            write.WriteLine(Email);
            write.WriteLine(PhoneNumber);
            write.WriteLine(Sex);
            write.WriteLine(HasBook ? "true" : "false");
            if (Books.Count > 0)
            {
                foreach (Book b in Books)
                    write.WriteLine(b.ToString());
            }
            write.Close();

        }
    }
}
