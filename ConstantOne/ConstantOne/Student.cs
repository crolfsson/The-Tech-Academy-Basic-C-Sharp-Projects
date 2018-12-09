using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantOne
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student()
        {
            Console.Write("Welcome, ");
        }

        public Student(string firstName): this()
        {
            Console.Write(firstName);
        }

        public Student(string firstName, string lastName) : this ("new student") 
        {
            Console.Write(" " + firstName + " " + lastName +"!");
        }

        //public Student(string name) : this(name, 99999)//New students get a pseudo ID of 99999 to distinguish them as new
        //{
        //    //No parameter is needed.
        //}
    }
}
