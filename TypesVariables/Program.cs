using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            if (IsPrimNum(7))
            {
                Console.WriteLine("its a prime Number");
            }
            else
            {
                Console.WriteLine("is not prime Number");
            }
            Console.ReadLine();
        }
        private static bool IsPrimNum(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;

                }

            }
            return result;
        }
    }
}



