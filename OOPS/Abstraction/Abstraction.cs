using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    public abstract class Area
    {
        public abstract void CalculateArea();
        public void CalculatingArea()
        {
            Console.WriteLine("Calculating Area....");
        }
    }
    public class Circle : Area
    {
        private double radius;
        public Circle(double radius) 
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            double result = Math.PI*radius*radius;
            Console.WriteLine($"Circle Area: {result}");
        }
    }
    public class Square : Area
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public override void CalculateArea()
        {
            double result = side * side;
            Console.WriteLine($"Square Area: {result}");
        }
    }
}
