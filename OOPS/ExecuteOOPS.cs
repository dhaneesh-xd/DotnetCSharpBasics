using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            vehicle.Name();
            car.Name();
            bus.Name();
        }
        public void InitiateAbstraction()
        {

        }
    }
}
