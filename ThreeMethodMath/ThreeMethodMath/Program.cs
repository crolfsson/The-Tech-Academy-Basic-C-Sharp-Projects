﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeMethodMath
{
    class Program
    {
        private static int resultTwo;

        static void Main(string[] args)
        {
            Calc calculator = new Calc();

            int result1 = calculator.basic(5, 6);
            Console.WriteLine("The sum of the integer value plus one equals: " + result1);
            Console.ReadLine();

            double result2 = calculator.basic(3.2);
            Console.WriteLine("The rounded result of the integer value multiplied by 4.2 equals: " + result2);
            Console.ReadLine();

            double result3 = calculator.basic(5);
            Console.WriteLine("The string equalls: " + result3);
            Console.ReadLine();

            Console.WriteLine("Thank you for your entry.  Have a nice day!");
            Console.ReadLine();
        }
    }
}
