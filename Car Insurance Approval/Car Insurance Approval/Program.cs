using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval
{
    class Program
    {
        private static readonly object Then;

        static void Main(string[] args)
        {
            Console.WriteLine("Every State Car Insurance Approval");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("\n");

            //QUESTIONAIRRE
            Console.Write("What is your age?: ");
            string driverAge = Console.ReadLine();
            double ageDriver = Convert.ToDouble(driverAge);

            Console.Write("Have you ever had a DUI?: ");
            string noDui = Console.ReadLine();

            Console.Write("How many speeding tickets do you have?: ");
            string speedTicket = Console.ReadLine();
            double ticketAmt = Convert.ToDouble(speedTicket);

            //APPLICATION RULES
            bool isQualified = (ageDriver > 15 && noDui == "no" && ticketAmt < 3);

            Console.WriteLine("\n");

            //APPLICATION RESULT
            Console.WriteLine("Is the applicant qualified for Every State car insurance?");
            Console.WriteLine("{0}", isQualified.ToString());
            Console.ReadLine();
        }
    }
}
