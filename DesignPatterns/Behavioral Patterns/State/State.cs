using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.State
{
   public interface IState
    {
        void StateName();
    }
    public class StateOne : IState
    {
        public void StateName()
        {
            Console.WriteLine("It is StateOne");
        }
    }
    public class StateTwo: IState
    {
        public void StateName()
        {
            Console.WriteLine("It is StateTwo");
        }
    }
    public class ListStateName
    {
        private IState state;
        public void SetState(IState state)
        {
            this.state = state;
        }
        public void HandleRequest()
        {
            state.StateName();
        }
    }
}
