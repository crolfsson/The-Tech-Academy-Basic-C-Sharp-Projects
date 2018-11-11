using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod3
{
    public class Calculator
    {
        public double Number { get; set; }

        public double Add(double number)
        {
            return number + 1;
        }

        public double Square(double number)
        {
            return number * number;
        }

        public double Zero(double number)
        {
            return number * 0;
        }

        internal double Add(int v, object num)
        {
            throw new NotImplementedException();
        }
        
    }
}
