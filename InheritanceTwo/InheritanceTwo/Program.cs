using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Two Drill");
            Console.WriteLine("\n");

            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();
        }
    }
}
