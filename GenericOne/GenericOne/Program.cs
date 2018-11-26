using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic One Drill");
            Console.WriteLine("\n");

            //GENERIC EXAMPLE
            Employee<string> stringEmployee = new Employee<string>();
            stringEmployee.AddThings("Business Analyst");
            stringEmployee.AddThings("Software Developer");
            stringEmployee.AddThings("Technical Lead");

            Employee<int> intEmployee = new Employee<int>();
            intEmployee.AddThings(1);
            intEmployee.AddThings(2);
            intEmployee.AddThings(3);

            stringEmployee.ForEach(Console.WriteLine);
            intEmployee.ForEach(Console.WriteLine);

            Console.ReadLine();


            //COMMENTING OUT NAME CODE - NOT APPLICABLE FOR THIS DRILL
            //Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //employee.SayName();
            //Console.ReadLine();

            //COMMENTING OUT OVERLOAD OPERATOR CODE - NOT APPLICABLE FOR THIS DRILL
            //Employee employeeId1 = new Employee(12345);
            //Employee employeeId2 = new Employee(1234);

            //if (employeeId1 == employeeId2)
            //    Console.WriteLine("Both employees have the same Employee ID.");
            //else
            //    Console.WriteLine("Each employee has a unique Employee ID.");
            //Console.ReadLine();
        }

        static void Quit(IQuittable employee)
        {
            employee.Quit();
        }
    }
}
