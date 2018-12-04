using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaOne
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        //public EmpInfo(string _firstName, string _lastName, int _iD)
        //{
        //    this.FirstName = _firstName;
        //    this.LastName = _lastName;
        //    this.ID = _iD;
        //}

        public override string ToString()
        {
            return String.Format("First Name: {0}" + "\nLast Name: {1}" + "\nID{2}", FirstName, LastName, ID);
        }
    }
}
