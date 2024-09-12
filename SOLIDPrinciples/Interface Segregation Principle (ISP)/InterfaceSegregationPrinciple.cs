using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Interface_Segregation_Principle
{
    public interface INorth
    {
        void NorthPeople();
    }
    public interface ISouth
    {
        void SouthPeople();
    }
    public class Chapathi : INorth
    {
        public void NorthPeople()
        {
            Console.WriteLine("North People :  Eats Chapathi with Green moong dal");
        }
    }
    public class Idli : ISouth
    {
        public void SouthPeople() 
        {
            Console.WriteLine("South People : Eats Idli with Sambar");
        }
    }
    public class Peoples
    {
        public void NorthDish(INorth north)
        {
            north.NorthPeople();
        }
        public void SouthDish(ISouth south)
        {
            south.SouthPeople();
        }
    }
}
