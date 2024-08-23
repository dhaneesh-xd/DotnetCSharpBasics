using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Flyweight_Pattern
{
    public interface ICharacter
    {
        char Gender { get; }
        void Display(int powerlevel);
    }
    public class Leo : ICharacter
    {
        public char Gender => 'M';
        public void Display (int power)
        {
            Console.WriteLine($"Gender: {Gender} || Power level: {power}");
        }
    }
    public class Lizie : ICharacter
    {
        public char Gender => 'F';
        public void Display(int power)
        {
            Console.WriteLine($"Gender: {Gender} || Power level: {power}");
        }
    }
    public class ErrorCharacter : ICharacter
    {
        public char Gender { get; set; }
        public void Display(int power)
        {
            Console.WriteLine($"Gender: Not allowed || Power level: Error Processing -- Enter again");
        }
    }

    public class CharacterDisplay()
    {
        private readonly Dictionary<char, ICharacter> characters = new Dictionary<char, ICharacter> ();
        public ICharacter GetCharacter(char key)
        {
            if (!characters.ContainsKey (key))
            {
                switch(key)
                {
                    case 'M':
                        characters[key] = new Leo();
                        break;
                    case 'F':
                        characters[key] = new Lizie();
                        break;
                    default:
                        characters[key] = new ErrorCharacter();
                        break;
                        
                }
            }
            return characters[key];
        }
    }


}
