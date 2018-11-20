using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeMethodMath
{
    public class Calc
    {

        public int basic(int num1)
        {
            int resultOne = num1 - 3;
            return resultOne;
        }

        public int basic(double number)
        {
            double result = number * 4.2;
            int resultTwo = Convert.ToInt32(result);
            return resultTwo;
        }

        public int basic(string a)
        {
            int numA = Convert.ToInt32(a);
            int resultThree = numA + 1;
            return resultThree;
        }
    }
}
