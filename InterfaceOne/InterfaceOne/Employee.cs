using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOne
{
    public class Employee : Person, IQuittable 
    {
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
