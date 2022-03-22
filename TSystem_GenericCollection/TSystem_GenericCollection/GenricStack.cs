using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_GenericCollection
{
    class GenricStack
    {
        static void Main(string[] args)
        {
            Stack<int> GS = new Stack<int>();
            GS.Push(55);
            GS.Push(99);
            GS.Push(100);
            foreach ( int s in GS)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("AFTER PERFORMING POP OPERATION");
            GS.Pop();
            foreach (int s in GS)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();




        }
    }
}
