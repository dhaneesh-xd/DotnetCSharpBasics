using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Bridge_Pattern
{
    public interface IIceCreamMaker
    { 
        void MakeIceCream(string taste);
    }
    public class ChocolateIceCream : IIceCreamMaker
    {
        public void MakeIceCream(string taste)
        {
            Console.WriteLine($"Chocolate icecream is very {taste}");
        }
    }
    public class VanillaIceCream : IIceCreamMaker
    {
        public void MakeIceCream(string taste)
        {
            Console.WriteLine($"Vanilla icecream is very {taste}");
        }
    }
    public abstract class IceCreamQuantity //implementing an abstraction
    {
        protected IIceCreamMaker IceCreamMaker;
        public IceCreamQuantity(IIceCreamMaker iceCreamMaker)
        {
            IceCreamMaker = iceCreamMaker;
        }
        public abstract void Quantity();
    }
    public class CupIcreCream : IceCreamQuantity //decoupling an abstraction
    {
        private string taste;
        public CupIcreCream(string taste, IIceCreamMaker iceCreamMaker) : base(iceCreamMaker)
        {
            this.taste = taste;
        }
        public override void Quantity()
        {
           IceCreamMaker.MakeIceCream(taste);
        }
    }



}
