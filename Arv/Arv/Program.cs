using System;
using System.Runtime.InteropServices;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {
                new Student("Emil", "Student","7654321", 1, 2020, true),
                new Student("Lime","Student", "1234", 2, 2000, false),
                new Student("Jomme","Student", "1444444", 3, 2999, true),
                new Student("Denis","Student", "7621", 4, 2020, false),
                new Lärare("Mr. Teacher","Lärare", "BB8", 1, 1940, true),
                new Lärare("Mrs. Teacher","Lärare", "000", 2, 1977, false),
                new Ledning("Miss. Rich","Ägare", "444", 1),
                new Ledning("Mr. Principal","Rektor", "4378402385023805823059821987350823760", 2),
                new Städspersonal("Mr. Clean","Städspersonal", "312312123",1,true)
            };

            foreach (var i in people)
            {
                i.PrintInfo();
            }
        }
    }

    class Person
    {
        private string namn,yrke, telNR;
        private int id;

        public Person(string name,string yrke, string phone, int id)
        {
            this.namn = name;
            this.yrke = yrke;
            this.telNR = phone;
            this.id = id;
        }

        public string GetName()
        {
            return namn;
        }

        public string GetYrke()
        {
            return yrke;
        }
        public string GetPhone()
        {
            return telNR;
        }

        public int GetId()
        {
            return id;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Namn: " + GetName() + " | Yrke: "+GetYrke());
            Console.WriteLine("TelNR: " + GetPhone());
            Console.WriteLine("Id: " + GetId());
        }
    }

    class Student : Person
    {
        int inskrivningsår;
        bool betaldKåravgift;
        public Student(string name,string yrke,string phoneNum,int id,int year,bool paid): base(name,yrke, phoneNum, id)
        {
            inskrivningsår = year;
            betaldKåravgift = paid;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            if (betaldKåravgift)
            {
                Console.WriteLine("Kåravgiften är betald!\n");
            }
            else
                Console.WriteLine("Kåravgiften är inte betald!\n");
        }
    }

    class Lärare : Person
    {
        int inskrivningsår;
        bool arbetar;
        public Lärare(string name, string yrke, string phoneNum,int id, int year, bool workingState) : base(name,yrke, phoneNum, id)
        {
            inskrivningsår = year;
            arbetar = workingState;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            if (arbetar)
            {
                Console.WriteLine("Läraren arbetar!\n");
            }
            else
                Console.WriteLine("Läraren arbetar inte!\n");
        }
    }

    class Ledning : Person
    {
        public Ledning(string name,string yrke, string phoneNum, int id) : base(name,yrke, phoneNum, id)
        {

        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine();
        }
    }

    class Städspersonal : Person
    {
        bool Städat;
        public Städspersonal(string name, string yrke, string phoneNum, int id, bool harStädat): base(name, yrke,phoneNum, id)
        {
            Städat = harStädat;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            if (Städat)
                Console.WriteLine("Har städat! \n");
            else
                Console.WriteLine("Har inte städat! \n");
        }
    }
}
