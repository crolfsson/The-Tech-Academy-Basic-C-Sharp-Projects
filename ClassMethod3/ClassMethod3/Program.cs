using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod3
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Enter number for math operation: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(calculator.Add(number));
            Console.WriteLine(calculator.Square(number));
            Console.WriteLine(calculator.Zero(number));
            Console.ReadLine();

            Console.WriteLine("Thank you for your entry.  Have a nice day!");
            Console.ReadLine();
        }
    }
}
