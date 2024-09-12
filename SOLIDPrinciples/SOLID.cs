using SOLIDPrinciples.Liskov_Substitution_Principle__LSP_;
using SOLIDPrinciples.Single_Responsibility_Principle__SRP_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static SOLIDPrinciples.Open_Closed_Principle__OCP_.OpenClosedPrinciple;

namespace SOLIDPrinciples
{
    internal class SOLID
    {
        private static SOLID? instance;
        private SOLID()
        {
            Display();
        }
        public static SOLID GetInstance()
        {
            if (instance==null)
            {
                instance = new SOLID();
            }
            return instance;
        }
        public void Display()
        {
            Console.WriteLine("SOLID Principles. Happy Coding");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Single Responsibility Response");
            InitiateSRP();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Open Closed Principle");
            InitiateOCP();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Liskov Substitute Principle");
            InitiateLSP();
        }
        public void InitiateSRP() //each class do solely purpose alone
        {
            var document = new DocumentContent { Content = "My Document" };
            IDocumentFormatter documentFormatter = new DocumentFormatter(); //format class for formatting alone
            IDocumnentPrinter documnentPrinter = new DocumentPrinter(); //print class for printing alone
            var formatDocumented = documentFormatter.Format(document.Content);
            documnentPrinter.Print(formatDocumented);
        }
        public void InitiateOCP() 
        {
            var success = new Report(new SuccessStatus());
            Console.WriteLine("Status: " +success.Status());
            var failed = new Report(new FailedStatus());
            Console.WriteLine("Status: "+failed.Status());
        }
        public void InitiateLSP()
        {
            LivingBeingTypes beingTypes = new LivingBeingTypes();
            LivingBeing herbi = new Herbivores(); //both class Herbivores and Carnivores does not affect the 
            LivingBeing carni = new Carnivores(); // LivingBeing abstract class this how LSP passes.
            beingTypes.Types(herbi); 
            beingTypes.Types(carni);
        }
    }
}
