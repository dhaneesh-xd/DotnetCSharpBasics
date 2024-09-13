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
    public class Boat 
    {
        public void Details(string color)
        {
            Console.WriteLine($"Color : {color}");
        }
        public void Details(int modelnumber)
        {
            Console.WriteLine($"Model Number : {modelnumber}");
        }
        public void Details(string color, int modelnumber)
        {
            Console.WriteLine($"Color : {color} Model Number : {modelnumber}");
        }
    }
}
