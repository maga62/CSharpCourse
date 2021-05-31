using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Eklendi");
            }

            public virtual void Delete() {
                Console.WriteLine("Silindii");
            }
        }
        class SqlServer:Database
        {
            // sql kendine özgü database kodları yazılsada 
            // overraide edip database deki codlarıda enjelte ede bilir bu şekilde 
            // bu işe ezme işleme denilir 
             
            
            public override void Add()
            {
                base.Add();
            }

        }
    }
}
