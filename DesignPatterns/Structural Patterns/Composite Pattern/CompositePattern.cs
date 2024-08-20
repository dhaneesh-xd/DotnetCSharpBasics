using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Composite_Pattern
{
    public abstract class IGreetingMessage
    {
        public abstract void Message();
    }
    public class Morning : IGreetingMessage
    {
        public override void Message()
        {
            Console.WriteLine("Good morning, have a nice day");
        }
    }
    public class Afternoon : IGreetingMessage
    {
        public override void Message()
        {
            Console.WriteLine("Good afternoon");
        }
    }
    public class Evening : IGreetingMessage
    {
        public override void Message()
        {
            Console.WriteLine("Good evening");
        }
    }
    public class Night : IGreetingMessage
    {
        public override void Message()
        {
            Console.WriteLine("Good night, sleep well");
        }
    }

    public class Operations : IGreetingMessage
    {
        private readonly List<IGreetingMessage> greetings = new List<IGreetingMessage>();
        public void Add(IGreetingMessage greetingMessage)
        {
            greetings.Add(greetingMessage);
        }
        public void Remove(IGreetingMessage greetingMessage)
        {
            greetings.Remove(greetingMessage);
        }
        public override void Message()
        {
            foreach (var greetingMessage in greetings)
            {
                greetingMessage.Message();
            }
        }
    }

}
