using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaOne
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public Employee(string FirstName, string LastName, int ID)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ID = ID;
        }

        public override string ToString()
        {
            return String.Format("First Name: {0}" + "\nLast Name: {1}" + "\nID{2}", FirstName, LastName, ID);
        }
    }
}
