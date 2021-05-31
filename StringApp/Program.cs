using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //cityname();
            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.LastName = "Soylu";
            customer.FirstName = "Suleyman";

            Customer customer1 = new Customer
            {
                Id=1,FirstName="Maaga",LastName="Muhuuu",City="Zaqatala"


            };



            Console.ReadLine();
        }

        private static void cityname()
        {
            string city = "ankara";
            foreach (var item in city)
            {
                Console.WriteLine(item);

            }
        }
    }
}
