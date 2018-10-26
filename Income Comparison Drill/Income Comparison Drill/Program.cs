using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            System.Threading.Thread.Sleep(1000);

            Console.Write("\n");

            //PERSON 1
            Console.WriteLine("Person 1");

            Console.Write("Hourly Rate: $");
            string hourlyRate1 = Console.ReadLine();
            double hourRate1 = Convert.ToDouble(hourlyRate1);

            Console.Write("Hours worked per week: ");
            string hoursWorked1 = Console.ReadLine();
            double hoursWeek1 = Convert.ToDouble(hoursWorked1);

            Console.Write("\n");

            //PERSON 2
            Console.WriteLine("Person 2");

            Console.Write("Hourly Rate: $");
            string hourlyRate2 = Console.ReadLine();
            double hourRate2 = Convert.ToDouble(hourlyRate2);

            Console.Write("Hours worked per week: ");
            string hoursWorked2 = Console.ReadLine();
            double hoursWeek2 = Convert.ToDouble(hoursWorked2);

            Console.Write("\n");

            Console.Write("============================ ANNUAL SALARY SUMMARY ============================");

            Console.Write("\n");

            //PERSON 1 CALCULATION
            double product1 = hourRate1 * hoursWeek1 * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine("${0:0.00}", product1);
            Console.ReadLine();

            //PERSON 2 CALCULATION
            double product2 = hourRate2 * hoursWeek2 *52;
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine("${0:0.00}", product2);
            Console.ReadLine();

            Console.Write("\n");

            //SALARY COMPARISON 
            bool trueOrFalse = product1 > product2;
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine("{0}", trueOrFalse.ToString());
            Console.ReadLine();


        }
    }
}

