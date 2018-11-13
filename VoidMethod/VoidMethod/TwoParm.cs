using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class TwoParm
    {
        //public double oneNumber { get; set; }
        public double result { get; set; }

        public void Add(int oneNumber, int twoNumber)
        {
            double result;
            result = oneNumber + twoNumber;
            Console.WriteLine("The second integer is {0}.", twoNumber);
        }
    }
}
