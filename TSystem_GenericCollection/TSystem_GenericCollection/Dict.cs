using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_GenericCollection
{
    class Dict
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> dt = new Dictionary<int, double>();
            dt.Add(101, 45000);
            dt.Add(102, 99000);
            dt.Add(103, 8000);
            dt.Add(104, 45000);
            foreach(KeyValuePair<int,double> v in dt)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("AFTER REMOVING DICTIONARY ITEM");
            dt.Remove(101);
            foreach (KeyValuePair<int, double> v in dt)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();


        }
    }
}
