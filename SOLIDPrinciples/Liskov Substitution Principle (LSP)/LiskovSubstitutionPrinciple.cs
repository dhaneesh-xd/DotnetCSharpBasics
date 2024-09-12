using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Liskov_Substitution_Principle__LSP_
{
    public abstract class LivingBeing
    {
        public abstract void Eats();
    }
    public class Herbivores : LivingBeing
    {
        public override void Eats()
        {
            Console.WriteLine("Herbivores : Eats grass");
        }
    }
    public class Carnivores : LivingBeing
    {
        public override void Eats()
        {
            Console.WriteLine("Carnivores : Eats other living being flesh");
        }
    }
    public class LivingBeingTypes
    {
        public void Types(LivingBeing livingBeing)
        {
            livingBeing.Eats();
        }
    }
}
