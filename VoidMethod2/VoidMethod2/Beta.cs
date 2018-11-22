using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod2
{
    public class Beta
    {
        public void Divide(int num1)
        {
            int result;
            result = num1 / 2;
            Console.WriteLine("Divide Method 1: " + num1 + " divided by 2 equals " + result + ".");

        }

        public void Divide(int num1, int num2)
        {
            int result;
            result = (num1 + num2) / 2;
            Console.WriteLine("Divide Method 2: " + num1 + " plus " + num2 + " divided by 2 equals " + result + ".");

        }

        public void OutPut(int num1, int num2, out int result1, out int result2)
        {
            result1 = num1 + num2;
            result2 = num1 * num2;
            
        }


        internal void OutPut(int num1, int num2, out object result1, out object result2)
        {
            throw new NotImplementedException();
        }
    }
}
