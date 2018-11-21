using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethod
{
    class Alpha
    {
        public int Optional(int num1, int num2 = 5)
        {
            int resultOne = num1 + num2 + 10;
            return resultOne;
        }

    }
}
