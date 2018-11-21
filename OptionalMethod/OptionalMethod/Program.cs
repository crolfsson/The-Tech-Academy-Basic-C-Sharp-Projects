using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Optional Method");
            Console.WriteLine("Two integers are needed for a math operation.");
            Console.WriteLine("The second integer is optional.  The optional value is 5.");
            Console.WriteLine("\n");

            Console.WriteLine("Enter one integer:");
            string input1 = Console.ReadLine();
            Int32.TryParse(input1, out int num1);

            Console.WriteLine("Enter another integer or leave as blank:");
            string input2 = Console.ReadLine();
            Int32.TryParse(input2, out int num2);

            Console.WriteLine("\n");
            Alpha alpha = new Alpha();

            //No optional value used.
            int resultOne = alpha.Optional(num1, num2);
            Console.WriteLine("The sum of integer one plus integer two plus 10 equals:" + resultOne);

            //Optional value used.
            int resultTwo = alpha.Optional(num1);
            Console.WriteLine("The sum of integer one plus optional integer two plus 10 equals:" + resultTwo);

            Console.ReadLine();
        }
    }
}
