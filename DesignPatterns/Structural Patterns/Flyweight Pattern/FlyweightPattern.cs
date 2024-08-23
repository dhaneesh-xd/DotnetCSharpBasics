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
                        throw new ArgumentException("Character not supported");
                }
            }
            return characters[key];
        }
    }


}
