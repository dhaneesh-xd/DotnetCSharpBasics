using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Inheritance
{
    public class FirstClass
    {
        public void FirstMethod()
        {
            Console.WriteLine("This Message from First Class");
        }
    }
    public class SecondClass : FirstClass
    {
        public void SecondMethod()
        {
            Console.WriteLine("This Message from Second Class");
        }
    }
}
