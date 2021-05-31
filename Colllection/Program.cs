using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colllection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList(); // tip güvenliği olmayan 
            //LİST();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);// anahtar kelimesini getir book
            }

            Console.ReadLine();

        }

        private static void LİST()
        {
            List<string> cities = new List<string>();// tip korumalı yani sadece striing bir sey gire biliriz bu durumda 
            cities.Add("ankara");
            cities.Add("istanbul");
            cities.Add("Bursa");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { FirstName = "Muho", Id = 1 });
            customers.Add(new Customer { FirstName = "zozo", Id = 2 });

            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "jojo"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4,FirstName="bro"},
                new Customer{Id=5,FirstName="buotro"}


            });
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }

        private static void ArrayList()
        {
            //string[] cities = new string[2] { "ankara", "istanbul" };// 2 eleman vardı
            //cities = new string[3]; // 3 eleman oldu 
            ////suan 2 elemanlı bir string bu eleamn sayısı arttıgında collection diye bir seye el atarız

            // ArrayList bu işin çözümü olmakta referans tip veri kaybı aynı zamanda performans kaybına yol açmakta
            ArrayList cities = new ArrayList();
            cities.Add("Adana");
            cities.Add("istanbul");
            cities.Add(1);
            // tip farkı yok gördüğümüz üzere yani int string farkı koşmuyor sebep Object tipinde yani her tipi aloır anlamında 


            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            cities.Add("adana");
            Console.WriteLine(cities[2]);//ADANAYI da ekler 
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

    }
}
