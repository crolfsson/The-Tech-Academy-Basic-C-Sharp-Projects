using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overload Operator One Drill");
            Console.WriteLine("\n");

            //COMMENTING OUT NAME CODE - NOT APPLICABLE FOR THIS DRILL
            //Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //employee.SayName();
            //Console.ReadLine();

            Employee employeeId1 = new Employee(12345);
            Employee employeeId2 = new Employee(1234);

            if (employeeId1 == employeeId2)
                Console.WriteLine("Both employees have the same Employee ID.");
            else
                Console.WriteLine("Each employee has a unique Employee ID.");
            Console.ReadLine();
        }

        static void Quit(IQuittable employee)
        {
            employee.Quit();
        }
    }
}
