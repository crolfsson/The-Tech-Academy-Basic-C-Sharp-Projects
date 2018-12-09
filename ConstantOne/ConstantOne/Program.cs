using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string school = "Newport Elementary School";

            Console.WriteLine("Constant One Drill");
            Console.WriteLine("\n");

            Console.WriteLine("Welcome new students to {0}!", school);
            Console.Write("Please enter you first name:  ");
            string studentFirstName = Console.ReadLine();
            Console.Write("Please enter you last name:  ");
            string studentLastName = Console.ReadLine();

            var newStudent = new Student(studentFirstName, studentLastName);
            Console.WriteLine();
            Console.WriteLine("\n");
            Console.WriteLine("{0} wishes you a great school year!", school);
            Console.ReadLine();
            




        }
    }
}
