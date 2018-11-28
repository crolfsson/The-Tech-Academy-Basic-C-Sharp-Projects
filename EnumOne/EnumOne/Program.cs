using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOne
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enum Drill:  Days of the Week");
            Console.WriteLine("\n");

            Week Week = new Week();

            Console.WriteLine("Please enter the current day of the week.");
            Day actualDay = Day.Tuesday;

            try
            {
                actualDay = (Day)Enum.Parse(typeof(Day), Console.ReadLine());
                Console.WriteLine("{0} is an awesome day of the week!", actualDay);
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
                return;
            }
        }
    }
}
