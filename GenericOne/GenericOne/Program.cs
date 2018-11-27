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
            Employee<string> Title = new Employee<string>();
            List<string> stringList = new List<string>();
            stringList.Add("Business Analyst");
            stringList.Add("Software Developer");
            stringList.Add("Technical Lead");
            Title.Things = stringList;

            Employee<int> Salary = new Employee<int>();
            List<int> intList = new List<int>();
            intList.Add(55000);
            intList.Add(75000);
            intList.Add(90000);
            Salary.Things = intList;

            stringList.ForEach(Console.WriteLine);
            intList.ForEach(Console.WriteLine);

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
