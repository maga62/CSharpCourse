
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hata Mesagge
            //SystemExeptions();
            
            List<string> studens = new List<string> { "Engin", "mıho", "duho" };
            if (!studens.Contains("Ahmet"))
            {
               throw new RecordNotFoundExeption("record not found");

            }
            else
            {
                Console.WriteLine("record found");
            }
            //metodun içine metod göderme c# ve bazı bir kaç dilde mevcul delege
            //
            //HandleExeption(() =>
            //{
            //    systemexeptions();
            
            //});

            //Console.ReadLine();


        }



        private static void systemexeptions()
        {
            try
            {
                //basarılı durum
                string[] students = new string[3]
                {
                    "engin","mıho","duho"
                };
                students[3] = "addoo";

            }

            catch (Exception exception)
            {
                //hatalı durumda burası 

                Console.WriteLine("hata");
            }
        }
    }
}
