using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Polymorphism
{
    public class Vehicle
    {
        public virtual void Name()
        {
            Console.WriteLine("Vehicle Names :");
        }
    }
    public class Bus : Vehicle
    {
        public override void Name()
        {
            Console.WriteLine("Bus");
        }
    }
    public class Car : Vehicle
    {
        public override void Name()
        {
            Console.WriteLine("Car");
        }
    }
}
