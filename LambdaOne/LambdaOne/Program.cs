using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaOne
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Lambda Drill");

            List<Employee> EmployeeList = new List<Employee>()
            {
                new Employee( "Joe", "Schmo", 1 ),
                new Employee( "Nikola", "Tesla", 2 ),
                new Employee( "Albert", "Einstein", 3 ),
                new Employee( "Isaac", "Newton", 4 ),
                new Employee( "Marie", "Curie", 5 ),
                new Employee( "Joe", "Gottago", 6 ),
                new Employee( "Galileo", "Galilei", 7 ),
                new Employee("Stephen", "Hawking", 8 ),
                new Employee("Charles", "Darwin", 9 ),
                new Employee("Thomas", "Edison", 10 ),
            };
            Console.WriteLine(EmployeeList.ToString());
            Console.ReadLine();
            
            
            //foreach (var employee in Employees)
            //{
            //    Console.WriteLine(employee);
            //}
            //Console.ReadLine();
        }

        
    }
}
