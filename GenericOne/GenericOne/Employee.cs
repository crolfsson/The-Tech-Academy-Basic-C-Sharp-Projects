using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOne
{
    public class Employee<T> : Person, IQuittable
    {
        //GENERIC EXAMPLE
        public List<T> Things { get; set; }

        public void AddThings(T item)
        {
            throw new NotImplementedException();
        }

        public void ForEach(Action writeLine)
        {
            throw new NotImplementedException();
        }


        //ID PROPERTY AND BOOLEAN LOGIC FOR EQUAL IDS - NOT APPLICABLE FOR THIS DRILL
        //int employeeId;
        //public Employee()
        //{
        //    employeeId = 0;
        //}
        //public Employee(int x)
        //{
        //    employeeId = x;
        //}
        //public static bool operator == (Employee x, Employee y)
        //{
        //    if (x.employeeId == y.employeeId)
        //        return true;
        //    else
        //        return false;
        //}
        //public static bool operator != (Employee x, Employee y)
        //{
        //    if (x.employeeId != y.employeeId)
        //        return true;
        //    else
        //        return false;
        //}
        //public int getValue()
        //{
        //    return employeeId;
        //}

        //PERSON CLASS
        public override void SayName()
        {
            base.SayName();
        }

        //IQUITTABLE INTERFACE
        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
