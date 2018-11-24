using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface One Drill");
            Console.WriteLine("\n");

            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();


        }

        static void Quit(IQuittable employee)
        {
            employee.Quit();
        }
    }
}
