using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Command
{
    public interface ISwitch
    {
        void SwitchOn();
        void SwitchOff();
    }
    public class Switch
    {
        public void SwitchStateON()
        {
            Console.WriteLine("Switch ON");
        }
        public void SwitchStateOFF()
        {
            Console.WriteLine("Switch OFF");
        }
    }
    public class SwitchBoard : ISwitch
    {
        private readonly Switch sw;
        public SwitchBoard(Switch sw)
        {
            this.sw = sw;
        }
        public void SwitchOn()
        {
            sw.SwitchStateON();
        }
        public void SwitchOff()
        {
            sw.SwitchStateOFF();
        }
    }

}