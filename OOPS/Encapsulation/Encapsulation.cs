using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Encapsulation
{
    public class Employee
    {
        private int id;
        private string email;
        public string EmpEmail
        {
            get { return email; }
            set { email = value; }
        }
        public int EmpID
        {
            get { return id; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Salary cannot be negative");
                }
                else
                {
                    id = value;
                }
            }
        }
        public Employee(int id, string email)
        {
            this.id = id;
            this.email = email;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Id : {EmpID} + Email : {EmpEmail}");
        }
    }
}
