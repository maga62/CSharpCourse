using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           // Customer customer = new Customer(); // tek bir tane class olunca bu yöntem ile çağrıla bilir 
            Person[] persons = new Person[2]
            {
            new Customer{FirstName="Muho" },
            new Student{FirstName="lolo" }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);  


            }

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        class Customer : Person
        {
            public string City { get; set; }

        }
        class Student : Person
        {
            public string Department { get; set; }

        }

    }
}
