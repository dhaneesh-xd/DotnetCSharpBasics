using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Factory_Method
{

        public interface IAnimals
        {
            void Sound();
        }
        public class Cat : IAnimals
        {
            public void Sound()
            {
                Console.WriteLine("Meow meow");
            }
        }
        public class Dog : IAnimals
        {
            public void Sound()
            {
                Console.WriteLine("Lol lol");
            }
        }
        public abstract class IdentifySound
        {
            public abstract IAnimals GetAnimals(); //initiating factory method -- IAnimals is return type here
        }
        public class Biscuits : IdentifySound 
        { 
            public override IAnimals GetAnimals() //factory method implementation
            {
                return new Dog(); //Returns a concrete implementation of IAnimals.. reason we inherit the IAnimals in Dog
            }
        }
        public class Fishes : IdentifySound
        {
            public override IAnimals GetAnimals() //factory method implementation
        {
                return new Cat();
            }
        }
    }

