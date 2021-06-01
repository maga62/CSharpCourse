using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //dortIslem.Topla2();
            //Console.WriteLine(dortIslem.Topla(4, 6));
            var tip = typeof(DortIslem);
            
            DortIslem dortislem = (DortIslem) Activator.CreateInstance(tip,6,7);
            dortislem.Topla(4, 7);
            dortislem.Topla2();
            Console.ReadLine();

        }
    }
   public class DortIslem
    {
        private int _say1;
        private int _say2;
        public DortIslem(int say1,int say2)
        {
            _say1 = say1;
            _say2 = say2;

        }
        public int Topla (int say1,int say2)
        {
            return say1 + say2;
        }
       
        public int Carp(int say1, int say2)
        {
            return say1 *say2;
        }

        public int Topla2()
        {
            return _say1 +_say2;
        }
        public int carp2()
        {
            return _say1 * _say2;
        }


    }
}
