using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_GenericCollection
{
    class GenericQueue
    {
        static void Main(string[] args)
        {
            Queue<String> GQ = new Queue<string>();
            GQ.Enqueue("NIKITA");
            GQ.Enqueue("SWAMI");
            GQ.Enqueue("SUSANGRAM");
            GQ.Enqueue("YASH");
            GQ.Enqueue("RIYA");
            GQ.Enqueue("ROSHU");
            foreach (string q in GQ)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("==================AFTER PERFORMING DQUEUE===============");
            GQ.Dequeue();
            foreach (string q in GQ)
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();

        }
    }
}
