using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOne
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance One Drill");
            Console.WriteLine("\n");

            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();
        }
    }
}
