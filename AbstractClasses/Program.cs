using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database database = new Database(); new yapamayız çünkü ABsruckt claslar Interface gibi new lwnwmiyor
            Database database = new SqlServer();
            database.Add();
            database.Delete();
            Database database1 = new Oracle();
            database1.Delete();
            database1.Add();
            Console.ReadLine();
            

        }

        abstract class Database {
            
            public void Add()
            {
                Console.WriteLine("Added");
            }
            public abstract void Delete();//tamamlanmamış  methodlar da yapa biliyoruz 
           

        }

        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("deleted by sql");
            }
        }
        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine("dleted by oracle  ");
            }
        }
    }
}
