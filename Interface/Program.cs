using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Inter();
            Console.ReadLine();

        }

        private static void Inter()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Muho", Address = "İstanbul" });
            manager.Add(new Student { Id = 2, FirstName = "lolo", });
        }

        interface IPerson
        {
             int Id { get; set; }
             string FirstName { get; set; }

            //Inetface clasların ortak olan Id FirstName LastNAme gibi Özelliği tutar 
            //ancak her clasın kendine özgün Özelliği de ola bilir onuda class kendi içerisinde barındırır
        }
        class Customer : IPerson
        {
            public int Id { get ; set; }
            public string FirstName { get ; set; }
            public string Address { get; set ; }
        }
        class Student : IPerson
        {
            public int Id { get ; set ; }
            public string FirstName { get ; set ; }
            public int Departmant { get; set ; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }


    }
}
