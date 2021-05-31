using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();//staratejimiz
            //customerManager.Logger = new FileLogger(); // müşteri metin dosyasına loglama yapmak istendiğinde 
            customerManager.Add();

            Console.ReadLine();


        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }// interface public properity ))  Ilogger türünde Logger 
        public void Add()

        {
            Logger.Log();

            Console.WriteLine(" customer eklendi");
        }

    }
    //class Logger:ILogger //class çıplak kalması tehlikelibir durum ola biler bir interface hep olması lazım
    //{
    //    public void Log()
    //    {
    //        Console.WriteLine("Loglandi");
    //    }

    //}

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("database loglandı");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File loglandı");
        }
    }


    interface ILogger
    {
        void Log();
    }

}
