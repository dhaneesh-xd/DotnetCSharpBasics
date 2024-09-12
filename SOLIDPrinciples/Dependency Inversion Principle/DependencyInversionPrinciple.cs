using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Dependency_Inversion_Principle
{
    public interface IGreetingMessage
    {
        void GreetingMessage(string message);
    }
    public interface IWelcomeMessage
    {
        void WelcomeMessage(string message);
    }
    public class AndroidStarting : IWelcomeMessage
    {
        public void WelcomeMessage(string message)
        {
            Console.WriteLine($"Welcome Message : {message}");
        }
    }
    public class AndroidStarted : IGreetingMessage
    {
        private readonly IWelcomeMessage welcomeMessage;
        public AndroidStarted(IWelcomeMessage welcomeMessage, string greet)
        {
            this.welcomeMessage = welcomeMessage;
            welcomeMessage.WelcomeMessage(greet);
        }
        public void GreetingMessage(string welcome)
        {
            Console.WriteLine($"Greeting Message : {welcome}");
        }
    }
    public class StartUpSetup
    {
        private readonly IGreetingMessage greetingMessage;
        public StartUpSetup(IGreetingMessage greetingMessage)
        {
            this.greetingMessage = greetingMessage;
        }
        public void StartupMessage(string message)
        {
            greetingMessage.GreetingMessage(message);
        }
    }
}
