using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Memento
{
    public class InitialState
    {
        public string State { get;  }
        public InitialState(string state)
        {
            State = state;
        }
    }
    public class MiddleState
    {
        public string State { get; set; }
        public InitialState SaveState()
        {
            InitialState initialState = new InitialState(State);
            return initialState;
        }
        public void GetInitialState(InitialState initialState)
        {
            State = initialState.State;
        }
    }
    public class FinalState
    {
        private InitialState InitialState;
        public void SaveState(InitialState initialState)
        {
            this.InitialState = initialState;
        }
        public InitialState GetState()
        {
            return this.InitialState;
        }
    }
}
