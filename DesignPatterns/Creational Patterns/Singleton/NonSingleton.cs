using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class NonSingleton
    {
        private static int i = 0;
        public NonSingleton() //it will count how many times new constructed called
        { 
            i++; Console.WriteLine($"NormalClass constructor called count {i}");
        } 
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
