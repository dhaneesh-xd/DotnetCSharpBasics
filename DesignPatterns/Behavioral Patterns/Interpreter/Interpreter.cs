using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Interpreter
{
    public interface IString
    {
        bool CheckString(string context);
    }
    public class StringExpression : IString
    {
        private string data;
        public StringExpression(string data)
        {
            this.data = data;
        }
        public bool CheckString(string context)
        {
            if (context.Contains(data))
                return true;
            else
                return false;
        }
    }
}
