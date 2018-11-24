using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorOne
{
    public class Employee : Person, IQuittable
    {
        int employeeId;

        public Employee()
        {
            employeeId = 0;
        }
        public Employee(int x)
        {
            employeeId = x;
        }

        public static bool operator ==(Employee x, Employee y)
        {
            if (x.employeeId == y.employeeId)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee x, Employee y)
        {
            if (x.employeeId != y.employeeId)
                return true;
            else
                return false;
        }

        public int getValue()
        {
            return employeeId;
        }



        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
