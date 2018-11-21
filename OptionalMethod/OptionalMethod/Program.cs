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
            Console.WriteLine("Two integers are needed for a math operation where the second number is optional.");

            Console.WriteLine("Enter one integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another integer or leave as blank:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Alpha alpha = new Alpha();

            int resultOne = alpha.Optional(num1, num2);
            Console.WriteLine("The sum of integer one plus integer two plus 10 equals:" + resultOne);

            //Optional value used
            int resultTwo = alpha.Optional(num1);
            Console.WriteLine("The sum of integer one plus optional integer two plus 10 equals:" + resultTwo);

            Console.ReadLine();
        }
    }
}
