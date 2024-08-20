using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Decorator_Pattern
{
    public interface ICake
    {
        void Bake();
    }
    public class HeatingProcess : ICake
    {
        public void Bake()
        {
            Console.WriteLine("Heating process started");
        }
    }
    //base decorator
    public abstract class Cake : ICake
    {
        private readonly ICake cake;
        public Cake(ICake _cake)
        {
            cake = _cake;
        }
        public virtual void Bake()
        {
            cake.Bake();
        }
    }
    public class Flour : Cake
    {
        public Flour(ICake cake) : base(cake)
        {
            
        }
        public override void Bake()
        {
            base.Bake();
            Console.WriteLine("Added flour");
        }
    }
    public class Egg : Cake
    {
        public Egg(ICake cake) : base(cake)
        {

        }
        public override void Bake()
        {
            base.Bake();
            Console.WriteLine("Added Egg");
        }
    }

}
