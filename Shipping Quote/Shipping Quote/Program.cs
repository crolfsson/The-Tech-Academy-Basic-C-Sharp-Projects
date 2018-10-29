using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");

            Console.WriteLine("\n");
         
            //PACKAGE WEIGHT
            Console.WriteLine("Enter package weight: ");
            string packageWeight = Console.ReadLine();
            double packWeight = Convert.ToDouble(packageWeight);

            //WEIGHT ERROR
            if (packWeight > 50)
            {
                Console.WriteLine("Pakcage is too heavy to be shipped via Package Express.  Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            //PACKAGE DIMENSIONS
            Console.WriteLine("Enter package width: ");
            string packageWidth = Console.ReadLine();
            double packWidth = Convert.ToDouble(packageWidth);

            Console.WriteLine("Enter package height: ");
            string packageHeight = Console.ReadLine();
            double packHeight = Convert.ToDouble(packageHeight);

            Console.WriteLine("Enter package length: ");
            string packageLength = Console.ReadLine();
            double packLength = Convert.ToDouble(packageLength);

            //DIMENSION ERROR
            double packDimSum = packWidth + packHeight + packLength;
            if (packDimSum > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            //QUOTE CALCULATION
            else
            {
                double quoteCalc = packDimSum * packWeight / 100;
                Console.WriteLine("You estimated total for shipping this package is: ");
                Console.WriteLine("${0:0.00}", quoteCalc);
                Console.WriteLine("Thank you.  Have a good day!");
                Console.ReadLine();
            }



        }
    }
}
