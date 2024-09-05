using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.TemplateMethod
{
    public abstract class AbstractSteps
    {
       public void StepsTemplate()
        {
            Step1();
            Step2();
            Step3();
        }
        public abstract void Step1();
        public abstract void Step2();
        public virtual void Step3()
        {
            Console.WriteLine("Default step");
        }
    }
    public class Steps : AbstractSteps
    {
        public override void Step1()
        {
            Console.WriteLine("Step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("Step 2");
        }
    }
}
