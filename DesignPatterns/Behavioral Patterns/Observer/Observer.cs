using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Observer
{
    public interface IObserver
    {
        void OnCompleted(string message);
    }
    public class ClassOne
    {
        public List<IObserver> Observers = new List<IObserver>();
        public void Monitoring(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void DeMonitoring(IObserver observer)
        {
            Observers.Remove(observer);
        }
        public void Notify(string message)
        {
            foreach (var observer in Observers)
            {
                observer.OnCompleted(message);
            }
        }
    }
    public class Observer : IObserver
    {
        public string name;
        public Observer(string name)
        {
            this.name = name;
        }
        public void OnCompleted(string message)
        {
            Console.WriteLine($"{name} : {message}");
        }
    }
}
