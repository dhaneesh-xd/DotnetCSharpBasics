using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Builder_Pattern
{
    public class Tea
    {
        public string Water { get; set; }
        public string Sugar { get; set; }
        public string TeaPowder { get; set; }
        public void PrepareTea()
        {
            Console.WriteLine($"Add {Water} of water and {Sugar} of sugar with {TeaPowder}");
        }
    }
    public interface ITeaPrepare
    {
        void AddWater();
        void AddSugar();
        void AddTeaPowder();
        Tea GetTea();
    }
    public class GreenTea : ITeaPrepare
    {
        private Tea tea;
        public GreenTea()
        {
            tea = new Tea();
        }
        public void AddSugar()
        {
            tea.Sugar = "5g";
        }

        public void AddTeaPowder()
        {
            tea.TeaPowder = "4g of Green tea";
        }

        public void AddWater()
        {
            tea.Water = "100ml";
        }

        public Tea GetTea()
        {
            return tea;
        }
    }
    public class TeaDistributer
    {
        public void TeaDelivery(ITeaPrepare teaPrepare)
        {
            teaPrepare.AddWater();
            teaPrepare.AddSugar();
            teaPrepare.AddTeaPowder();
        }
    }

}
