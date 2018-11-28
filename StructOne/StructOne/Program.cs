using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct Drill");
            Console.WriteLine("\n");


            Number value = new Number();
            value.Amount = 7;
            Console.WriteLine("The assigned value is {0}.", value.Amount);
            Console.ReadLine();

        }
    }
}
