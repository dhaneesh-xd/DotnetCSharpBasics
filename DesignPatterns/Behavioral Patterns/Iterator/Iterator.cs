using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Iterator
{
    public interface IAddNumber<D>
    {
        bool checkNumber();
        D Add();
    }
    public class AddNumber<D>
    {
        public List<D> numbers = new List<D>();
        public void AddNum(D num)
        {
            numbers.Add(num);
        }
        public IAddNumber<D> CreateAddFunction()
        {
            IAddNumber<D> addNumber = new Addition(this);
            return addNumber;
        }
        private class Addition : IAddNumber<D>
        {
            private AddNumber<D> addNumber;
            private int num = 0;
            public Addition(AddNumber<D> addNumber)
            {
                this.addNumber = addNumber;
            }
            public D Add() 
            {
                D numD = addNumber.numbers[num++];
                return numD;
            }
            
            public bool checkNumber()
            {
                if (num < addNumber.numbers.Count)
                    return true;
                else 
                    return false;
            }
        }
    }
}
