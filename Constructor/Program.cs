using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilits.Validate();
            Manager.DoSomting();
            Manager manager = new Manager();
            manager.DoSomting2();
             
        }

        static class Utilits //clası static yapmak 
        {
            
            public static void Validate()
            {
                Console.WriteLine("Validation is done");
            }
        }
        //özelliklerini statick yapmak ve class statik değil
        class Manager
        {
            public static void DoSomting()
            {
                Console.WriteLine(" done");
            }
            public void DoSomting2()
            {
                Console.WriteLine("is done");
            }

        }
    }
}
