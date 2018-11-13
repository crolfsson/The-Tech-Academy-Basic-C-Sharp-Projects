using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Void Method:  Return 2nd Integer");
            Console.ReadKey();

            TwoParm twoparm = new TwoParm();

            twoparm.Add(2,25);
            Console.ReadLine();
        }
        
    }
}
