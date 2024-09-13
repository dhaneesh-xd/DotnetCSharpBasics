using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPS.Abstraction;
using OOPS.Encapsulation;
using OOPS.Inheritance;
using OOPS.Polymorphism;

namespace OOPS
{
    public class ExecuteOOPS
    {
        private static ExecuteOOPS oops;
        public static ExecuteOOPS GetInstance()
        {
            if (oops == null)
            {
                oops = new ExecuteOOPS();
            }
            return oops;
        }
        private ExecuteOOPS()
        {
            Display();
        }
        public void Display()
        {
            Console.WriteLine("OOPS Concept. Happy Coding");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Inheritance");
            InitiateInheritance();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Encapsulation");
            InitiateEncapsulation();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Polymorphism");
            InitiatePolymorphism();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Abstraction");
            InitiateAbstraction();
        }
        public void InitiateInheritance()
        {
            SecondClass secondClass = new SecondClass();
            secondClass.FirstMethod(); //in SecondClass object itself we calling FirstClass method
            secondClass.SecondMethod();
        }
        public void InitiateEncapsulation()
        {
            Employee employee = new Employee(123, "abc@gmail.com"); //operate on the data into a single unit
            employee.DisplayInfo();
            employee.EmpID = -1; //usually achieved by making fields private and providing public getter and setter methods
            employee.DisplayInfo(); //negative

        }
        public void InitiatePolymorphism()
        {
            Vehicle vehicle = new Vehicle(); 
            Vehicle car = new Car();
            Vehicle bus = new Bus(); 
            Boat boat = new Boat();
            vehicle.Name();
            car.Name(); //method overriding
            bus.Name();
            boat.Details(1991); //method overloading
            boat.Details("Grey");
            boat.Details("Grey", 1991);
        }
        public void InitiateAbstraction()
        {
            Area circle = new Circle(1.5);
            Area square = new Square(5); //creating object from base class which is abstract class
            circle.CalculatingArea(); //so the implementation are can't seen
            circle.CalculateArea();
            square.CalculatingArea();
            square.CalculateArea();

        }
    }
}
