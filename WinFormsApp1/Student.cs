using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Student
    {
       
        private string name;
        private int id;
        private string prijmeni;
        private string trida;
        

        public Student(int iD, string name, string prijmeni, string trida)
        {
            this.id = iD;
            this.name = name;
            this.prijmeni = prijmeni;
            this.trida = trida;
        }

        public string Name
        {
            get { return name; }
            set {name = value; }
        }
        public string Prijmeni
        {
            get { return prijmeni; }
            set { prijmeni = value; }
        }
        public int ID
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
        public string Trida
        {
            get { return trida; }
            set
            {
                trida = value;
            }
        }

        
        public override string ToString()
        {
            return id + "," + name + "," + prijmeni + "," + trida;
        }
    }
}
