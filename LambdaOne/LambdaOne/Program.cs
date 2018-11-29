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
                new Employee() { FirstName = "Joe", LastName = "Schmo", ID = 1 },
                new Employee() { FirstName = "Nikola", LastName = "Tesla", ID = 2 },
                new Employee() { FirstName = "Albert", LastName = "Einstein", ID = 3 },
                new Employee() { FirstName = "Isaac", LastName = "Newton", ID = 4 },
                new Employee() { FirstName = "Marie", LastName = "Curie", ID = 5 },
                new Employee() { FirstName = "Joe", LastName = "Gottago", ID = 6 },
                new Employee() { FirstName = "Galileo", LastName = "Galilei", ID = 7 },
                new Employee() { FirstName = "Stephen", LastName = "Hawking", ID = 8 },
                new Employee() { FirstName = "Charles", LastName = "Darwin", ID = 9 },
                new Employee() { FirstName = "Thomas", LastName = "Edison", ID = 10 },
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
