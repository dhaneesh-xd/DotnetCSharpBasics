using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Factory_Method
{

    public interface IAnimalsNonFM
    {
        void Sound();
    }
    public class CatNonFM : IAnimalsNonFM
    {
        public void Sound()
        {
            Console.WriteLine("Meow meow");
        }
    }
    public class DogNonFM : IAnimalsNonFM
    {
        public void Sound()
        {
            Console.WriteLine("Lol lol");
        }
    }
}
