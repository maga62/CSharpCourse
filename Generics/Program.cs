using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Unilities unilities = new Unilities();
            List<string> result = unilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        

    }
    class Unilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }

    }
    class Product: IEntity
    {

    }
    interface IProductDal:IRepository<Product>
    {
        //List<Product> GetAll();
        //Product Get(int id);
        //void Add(Product product);
        //void Delete(Product product);
        //void Update(Product product);
    }
    class Customer: IEntity
    {

    }
    interface ICustomerDal:IRepository<Customer>
    {
        //List<Customer> GetAll();
        //Customer Get(int id);
        //void Add(Customer product);
        //void Delete(Customer product);
        //void Update(Customer product);
    }
    interface IStudentDal:IRepository<Student>
    {

    }
    class Student:IEntity
    {

    }
    interface IEntity
    {

    }

    interface IRepository<T> where T:class,IEntity , new() //where T:class , new() kısıtlaması -----? sadece değer tipi kısıtlaması koymak istesek (--where T:struct--) yazarız
    {
        List<T> GetAll();
        T Get(int id);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CutomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
