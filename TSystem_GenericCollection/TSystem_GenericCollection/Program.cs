using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TSystem_GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lt = new List<int>();//generic list

            List<Product> pro = new List<Product>()
            { 
            
                new Product(101,"mobile",4500),
                new Product(102,"lappi",4500),
                new Product(103,"handbag",450)
            };
            foreach (object p in pro)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();

        }
    }
}
