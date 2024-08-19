using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory_Pattern
{
    public interface ITapWater
    {
        void Water();
    }
    public interface IMotorWater
    {
        void Water();
    }
    public class HomeTapWater : ITapWater
    {
        public void Water()
        {
            Console.WriteLine("Tap water from Home");
        }
    }
    public class IndustryTapWater : ITapWater
    {
        public void Water()
        {
            Console.WriteLine("Tap water from Industry");
        }
    }
    public class HomeMotorWater : IMotorWater
    {
        public void Water()
        {
            Console.WriteLine("Motor water from Home");
        }
    }
    public class IndustryMotorWater : IMotorWater
    {
        public void Water()
        {
            Console.WriteLine("Motor water from Industry");
        }
    }
    public interface AllWaterSource
    { 
        ITapWater tapWater();
        IMotorWater motorWater();
    }
    public class Home : AllWaterSource
    {
        public ITapWater tapWater()
        {
            return new HomeTapWater();
        }
        public IMotorWater motorWater()
        {
            return new HomeMotorWater();
        }
    }
    public class Industry : AllWaterSource
    {
        public ITapWater tapWater()
        {
            return new IndustryTapWater();
        }
        public IMotorWater motorWater()
        {
            return new IndustryMotorWater();
        }
    }
    public class WaterConnection
    {
        private readonly ITapWater tapWater;
        private readonly IMotorWater motorWater;
        public WaterConnection(AllWaterSource allWaterSource)
        {
            tapWater = allWaterSource.tapWater();
            motorWater = allWaterSource.motorWater();
        }
        public void WaterSource()
        {
            tapWater.Water();
            motorWater.Water();
        }
    }




}
