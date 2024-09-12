using SOLIDPrinciples.Dependency_Inversion_Principle;
using SOLIDPrinciples.Interface_Segregation_Principle;
using SOLIDPrinciples.Liskov_Substitution_Principle__LSP_;
using SOLIDPrinciples.Open_Closed_Principle__OCP_;
using SOLIDPrinciples.Single_Responsibility_Principle__SRP_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Interface Segregation Principle");
            InitiateISP();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Dependency Inversion Principle");
            InitiateDIP();
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
            var success = new Report(new SuccessStatus()); //we implemented class structure which used for extend methods 
            Console.WriteLine("Status: " +success.Status()); // closed for modification
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
        public void InitiateISP()
        {
            Peoples peoples = new Peoples();
            INorth north = new Chapathi(); //interface should not forceable implement methods which does not require
            ISouth south = new Idli();
            peoples.NorthDish(north);
            peoples.SouthDish(south);
        }
        public void InitiateDIP()
        {
            IWelcomeMessage welcomeMessage = new AndroidStarting();
            IGreetingMessage greetingMessage = new AndroidStarted(welcomeMessage, "Hello");
            StartUpSetup startUpSetup = new StartUpSetup(greetingMessage); //High-level modules should not depend on low-level modules.
            startUpSetup.StartupMessage("Welcome"); //high-level module is not tightly coupled to specific greeting mechanisms 
            //and can work with any service that implements the IGreetingMessage interface.
        }
    }
}
