using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeMethodMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Three INT Method Math");
            Console.ReadLine();

            Calc calculator = new Calc();

            int result1 = calculator.basic(5);
            Console.WriteLine("The sum of the integer value minus 3 equals: " + result1);
            Console.ReadLine();

            int result2 = calculator.basic(3.2);
            Console.WriteLine("The rounded result of the double value multiplied by 4.2 equals: " + result2);
            Console.ReadLine();

            int result3 = calculator.basic("25");
            Console.WriteLine("The string value plus 1 equals: " + result3);
            Console.ReadLine();

            Console.WriteLine("Thank you for your entry.  Have a nice day!");
            Console.ReadLine();
        }

    }
}
