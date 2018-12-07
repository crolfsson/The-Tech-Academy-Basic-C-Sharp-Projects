using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatTimeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateTime One Drill");

            DateTime time = DateTime.Now;
            Console.WriteLine("The date and time right now is:  " + time);
            Console.WriteLine("\n");

            Console.WriteLine("Please enter a number of hours that will be added to the current time:  ");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int addNumber);

            DateTime futureTime = DateTime.Now;
            futureTime = futureTime.AddHours(addNumber);
            Console.WriteLine("The new date and time is:  " + futureTime);
            Console.ReadLine();
        }
    }
}
