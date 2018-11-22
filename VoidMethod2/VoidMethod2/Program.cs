using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Void Method Two");
            Console.WriteLine("\n");

            Console.WriteLine("Please enter two integers for multiple math operations. Results will be rounded.");
            Console.WriteLine("\n");

            Console.Write("Enter an integer: ");
            string input1 = Console.ReadLine();
            Int32.TryParse(input1, out int num1);

            Console.Write("Enter another integer: ");
            string input2 = Console.ReadLine();
            Int32.TryParse(input2, out int num2);

            Console.WriteLine("\n");
            Beta b = new Beta();

            //DIVIDE METHOD RESULTS
            b.Divide(num1);
            b.Divide(num1, num2);
            Console.ReadLine();

            //OUTPUT RESULTS
            int result1, result2;
            b.OutPut(num1, num2, out result1, out result2);
            Console.WriteLine("Output Result 1: " + num1 + " plus " + num2 + " equals {0}.", result1);
            Console.WriteLine("Output Result 2: " + num1 + " multiplied by " + num2 + " equals {0}.", result2);
            Console.ReadLine();

            //STATIC CLASS RESULTS
            int result3 = Gamma.SquareTwo(num2);
            Console.WriteLine("Static Class Result: " + num2 + " squared equals {0}.", result3);
            Console.ReadLine();

            Console.WriteLine("Thank you!  Have a great day!");
            Console.ReadLine();
        }
    }
}
