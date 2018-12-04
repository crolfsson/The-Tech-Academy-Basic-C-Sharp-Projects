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

            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee() { FirstName = "Joe", LastName = "Schmo", ID = 1 });
            EmployeeList.Add(new Employee() { FirstName = "Nikola", LastName = "Tesla", ID = 2 });
            EmployeeList.Add(new Employee() { FirstName = "Albert", LastName = "Einstein", ID = 3 } );
            EmployeeList.Add(new Employee() { FirstName = "Isaac", LastName = "Newton", ID = 4 });
            EmployeeList.Add(new Employee() { FirstName = "Marie", LastName = "Curie", ID = 5 });
            EmployeeList.Add(new Employee() { FirstName = "Joe", LastName = "Gottago", ID = 6 });
            EmployeeList.Add(new Employee() { FirstName = "Galileo", LastName = "Galilei", ID = 7 });
            EmployeeList.Add(new Employee() { FirstName = "Stephen", LastName = "Hawking", ID = 8 });
            EmployeeList.Add(new Employee() { FirstName = "Charles", LastName = "Darwin", ID = 9 });
            EmployeeList.Add(new Employee() { FirstName = "Thomas", LastName = "Edison", ID = 10 });


            List<Employee> EmployeeList2 = EmployeeList.Where(x => x.ID > 5).ToList();
            foreach (Employee employee in EmployeeList2)
            {
                Console.WriteLine(EmployeeList2.ToString());
            }
            Console.ReadLine();
        }

        
    }
}
