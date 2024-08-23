using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Facade_Pattern
{
    public class CPU
    {
        public void On() => Console.WriteLine("CPU On");
        public void Off() => Console.WriteLine("CPU Off");
    }
    public class MonitorDisplay
    {
        public void On() => Console.WriteLine("Monitor On");
        public void Opened(string input) => Console.WriteLine($"{input} opened");
        public void Closed() => Console.WriteLine($"Closing..");
        public void Off() => Console.WriteLine("Monitor Off");
    }
    public class SoftwareOpening
    {
        private readonly CPU cpu;
        private readonly MonitorDisplay monitor;
        public SoftwareOpening(CPU cpu, MonitorDisplay monitor)
        {
            this.cpu = cpu;
            this.monitor = monitor;
        }
        public void OpenSofware(string input)
        {
            Console.WriteLine("Getting ready..");
            monitor.On();
            cpu.On();
            monitor.Opened(input);
        }
        public void CloseSoftware()
        {
            monitor.Closed();
            cpu.Off();
            Console.WriteLine("Getting shutdown..");
            monitor.Off();
        }
    }

}
