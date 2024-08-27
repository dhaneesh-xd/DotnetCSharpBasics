using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Chain_of_Responsibility
{
    public abstract class Number
    {
        protected Number number;
        public void NextNumber(Number number)
        {
            this.number = number;
        }
        public abstract void CheckNumber(int num);
    }
    public class EvenNumber : Number
    {
        public override void CheckNumber(int num)
        {
            if (num % 2 == 0) Console.WriteLine($"Even = {num}");
            else number.CheckNumber(num);
        }
    }
    public class OddNumber : Number
    {
        public override void CheckNumber(int num)
        {
            if (num % 2 != 0) Console.WriteLine($"Odd = {num}");
            else number.CheckNumber(num);
        }
    }
}
