using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //MULTIPLICATION
            double num1 = 6000000000;

            double product = num1 * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine();

            
            //ADDITION
            int num2 = 10;

            int total = num2 + 25;
            Console.WriteLine(total);
            Console.ReadLine();

            Console.WriteLine();


            //DIVISION NO REMAINDER
            float num3 = 50.5f;

            double quotient = num3 / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            Console.WriteLine();


            //COMPARISON
            int num4 = 42;

            bool checkNum4 = num4 > 50;
            Console.WriteLine(checkNum4);
            Console.ReadLine();

            Console.WriteLine();


            //MODULUS OPERATOR
            int num5 = 71;

            int remainder = num5 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
