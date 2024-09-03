using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Mediator
{
    public interface IMediator
    {
        void Pass(string message, Person person);
    }
    public abstract class Person
    {
        protected IMediator mediator;
        public Person(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
    public class ExecutePassing : IMediator
    {
        private FirstPerson firstPerson;
        private SecondPerson secondPerson;
        public void SetFirstPerson(FirstPerson firstPerson)
        {
            this.firstPerson = firstPerson;
        }
        public void SetSecondPerson(SecondPerson secondPerson)
        {
            this.secondPerson = secondPerson;
        }
        public void Pass(string message, Person person)
        {
            if (person == firstPerson)
                secondPerson.Receive(message);
            else
                firstPerson.Receive(message);
        }
    }
    public class FirstPerson : Person
    {
        public FirstPerson(IMediator mediator) : base(mediator)
        {
            
        }
        public void Pass(string message)
        {
            mediator.Pass(message, this);
        }
        public void Receive(string message)
        {
            Console.WriteLine("First Person : " +  message);
        }
    }
    public class SecondPerson : Person
    {
        public SecondPerson(IMediator mediator) : base(mediator)
        {

        }
        public void Pass(string message)
        {
            mediator.Pass(message, this);
        }
        public void Receive(string message)
        {
            Console.WriteLine("Second Person : " + message);
        }
    }
}
