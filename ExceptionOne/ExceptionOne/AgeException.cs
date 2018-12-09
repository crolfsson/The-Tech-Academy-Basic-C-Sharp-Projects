using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionOne
{
    public class AgeException : Exception
    {
        public AgeException()//inheriting from the base excpetion
            : base() { }

        public AgeException(string message)//overloading from the first constructor
            : base(message) { }
    }
}
