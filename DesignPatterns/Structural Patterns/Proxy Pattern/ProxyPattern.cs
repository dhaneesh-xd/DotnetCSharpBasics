using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Proxy_Pattern
{
    public interface IPrint
    {
        void Printing();
    }
    public class FirstPrint : IPrint
    {
        private string _name;
        public FirstPrint(string name)
        {
           _name = name;
            Loading();
        }
        private void Loading()
        {
            Console.WriteLine($"Loading {_name}");
        }
        public void Printing() 
        {
            Console.WriteLine($"First Printing {_name}");
        }
    }
    public class SecondPrint : IPrint
    {
        private FirstPrint firstPrint;
        private string _name;
        public SecondPrint(string name)
        {
            _name = name;
        }
        public void Printing()
        {
            if (firstPrint == null)
            {
                firstPrint = new FirstPrint( _name );
            }
            firstPrint.Printing();
        }
    }

}
