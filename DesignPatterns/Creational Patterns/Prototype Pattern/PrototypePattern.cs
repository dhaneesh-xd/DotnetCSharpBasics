using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Prototype_Pattern
{
    public interface IVehicles
    {
        IVehicles Clone();
        void Type();
    }
    public class Car : IVehicles
    { 
        public IVehicles Clone()
        {
            return new Car();
        }
        public void Type()
        {
            Console.WriteLine("Four wheeler");
        }
    }
    public class Bike : IVehicles
    {
        public IVehicles Clone()
        {
            return new Bike();
        }
        public void Type()
        {
            Console.WriteLine("Two wheeler");
        }
    }



}
