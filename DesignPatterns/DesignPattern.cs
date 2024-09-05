using DesignPatterns.Behavioral_Patterns.Chain_of_Responsibility;
using DesignPatterns.Behavioral_Patterns.Command;
using DesignPatterns.Behavioral_Patterns.Interpreter;
using DesignPatterns.Behavioral_Patterns.Iterator;
using DesignPatterns.Behavioral_Patterns.Mediator;
using DesignPatterns.Behavioral_Patterns.Memento;
using DesignPatterns.Behavioral_Patterns.Observer;
using DesignPatterns.Behavioral_Patterns.State;
using DesignPatterns.Behavioral_Patterns.TemplateMethod;
using DesignPatterns.Creational_Patterns.Abstract_Factory_Pattern;
using DesignPatterns.Creational_Patterns.Adapter_Pattern;
using DesignPatterns.Creational_Patterns.Bridge_Pattern;
using DesignPatterns.Creational_Patterns.Builder_Pattern;
using DesignPatterns.Creational_Patterns.Factory_Method;
using DesignPatterns.Creational_Patterns.Prototype_Pattern;
using DesignPatterns.Singleton;
using DesignPatterns.Structural_Patterns.Composite_Pattern;
using DesignPatterns.Structural_Patterns.Decorator_Pattern;
using DesignPatterns.Structural_Patterns.Facade_Pattern;
using DesignPatterns.Structural_Patterns.Flyweight_Pattern;
using DesignPatterns.Structural_Patterns.Proxy_Pattern;

public class DesignPatternsExecute
{
    private DesignPatternsExecute()
    {
        DisplayMethods();
    }
    private static DesignPatternsExecute? instance;
    public static DesignPatternsExecute GetInstance() 
    {
        if (instance == null)
            instance = new DesignPatternsExecute();
        return instance;
    }
    void DisplayMethods()
    {
        Console.WriteLine("Design Pattern. Happy Coding");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Creational Patterns: ");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Singleton");
        InitiateSingleton();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Factory Method");
        InitiateFactoryMethod();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Abstract Factory Pattern");
        InitiateAbstractFactoryPattern();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Builder Pattern");
        InitiateBuilderPattern();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Prototype Pattern");
        InitiatePrototypePattern();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Structural Patterns: ");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Adapter Pattern");
        InitiateAdapterPattern();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Bridge Pattern");
        InitiateBridgePattern();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Composite pattern");
        InitiateCompositePattern();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Decorator pattern");
        InitiateDecoratorPattern();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Facade pattern");
        InititateFacadePattern();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Flyweight pattern");
        InitiateFlyweightPattern();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Proxy pattern");
        InitiateProxyPattern();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Behavioral Patterns: ");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Chain of Responsibility");
        InitiateChainOfResponsibility();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Command");
        InitiateCommand();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Interpreter");
        InitiateInterpreter();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Iterator");
        InitiateIterator();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Mediator");
        InitiateMediator();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Memento");
        InitiateMemento();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Observer");
        InitiateObserver();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("State");
        InitiateState();
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Template Method");
        InitiateTemplateMethod();
        Console.WriteLine("------------------------------------------");
    }
    void InitiateSingleton()
    {
        Singleton singleton1 = Singleton.GetInstance();
        Singleton singleton2 = Singleton.GetInstance();
        singleton1.DisplayMessage("SingletonClass 1");
        singleton2.DisplayMessage("SingletonClass 2");
        NonSingleton nonSingleton1 = new NonSingleton();
        nonSingleton1.DisplayMessage("NormalClass 1");
        NonSingleton nonSingleton2 = new NonSingleton();
        nonSingleton2.DisplayMessage("NormalClass 2");
        Console.WriteLine($"Check both instance are same : {singleton1 == singleton2}"); //validate same constructor or not
        Console.WriteLine($"Check both instance are same : {nonSingleton1 == nonSingleton2}");
    }
    void InitiateFactoryMethod()
    {
        //object always create in derived class when we use.. (baseclass obj = new dervied class)
        //base class                    //derived class
        IdentifySound identifySound1 = new Biscuits(); //Creating object for Biscuits class where IdentifySound Abstract class initiated
        IAnimals animals1 = identifySound1.GetAnimals(); //the reason we can use IAnimals as baseclass is.. we created IAnimals as return type in Abstract class
        animals1.Sound();
        IdentifySound identifySound2 = new Fishes();
        IAnimals animals2 = identifySound2.GetAnimals();
        animals2.Sound();
        IAnimalsNonFM animalsNonFM1 = new DogNonFM();
        animalsNonFM1.Sound();
        IAnimalsNonFM animalsNonFM2 = new CatNonFM();
        animalsNonFM2.Sound();
        /*
        both will print in same manner only.. what the key difference is..
        Factory method is more encapsulated and loose coupling..
        so it can easy extend in future
        */
    }
    void InitiateAbstractFactoryPattern()
    {
        AllWaterSource allWaterSource = new Home(); //encapsulatoin of object creation 
        WaterConnection waterConnection = new WaterConnection(allWaterSource);
        waterConnection.WaterSource();

        allWaterSource = new Industry();
        waterConnection = new WaterConnection(allWaterSource);
        waterConnection.WaterSource();
    }
    void InitiateBuilderPattern()
    {
        TeaDistributer teaDistributer = new TeaDistributer(); // it will give encpsulation to the object
        ITeaPrepare teaPrepare = new GreenTea();
        teaDistributer.TeaDelivery(teaPrepare); //object to object interaction
        Tea tea = teaPrepare.GetTea();
        tea.PrepareTea();
    }
    void InitiatePrototypePattern()
    {
        IVehicles realObj1 = new Car();
        IVehicles cloneObj1 = realObj1.Clone();
        realObj1.Type(); //both will be same due to clone property
        cloneObj1.Type(); //same output

        IVehicles realObj2 = new Bike();
        IVehicles cloneObj2 = realObj2.Clone();
        realObj2.Type();
        cloneObj2.Type();
    }
    void InitiateAdapterPattern()
    {
        BluetoothEarphone bluetoothEarphone = new BluetoothEarphone();
        IMusic music = new WiredEarphone(bluetoothEarphone); // passing the class function into other class (delegating)
        music.Player();
    }
    void InitiateBridgePattern()
    {
        IceCreamQuantity[] iceCreamQuantities = new IceCreamQuantity[] //abstraction
            {
            new CupIcreCream ("Good", new ChocolateIceCream()),  //decoupling
            new CupIcreCream ("Good", new VanillaIceCream())
            };
        foreach (var iceCreamQuantity in iceCreamQuantities)
        {
            iceCreamQuantity.Quantity();
        }
    }
    void InitiateCompositePattern()
    {
        Morning morning = new Morning();
        Afternoon afternoon = new Afternoon();
        Evening evening = new Evening();
        Night night = new Night();
        Operations operations = new Operations(); //treat individual and group objects uniformly --tree like structure
        operations.Add(morning);
        operations.Add(afternoon);
        operations.Add(evening);
        operations.Message();
        operations.Remove(morning);
        operations.Remove(afternoon);
        operations.Remove(evening);
        operations.Add(night);
        operations.Message();
    }
    void InitiateDecoratorPattern()
    {
        ICake cake = new HeatingProcess();
        cake = new Flour(cake); //added responsibilities to object without affecting other objects
        cake = new Egg(cake);
        cake.Bake();
    }
    void InititateFacadePattern()
    {
        CPU cpu = new CPU();
        MonitorDisplay monitor = new MonitorDisplay();
        SoftwareOpening softwareOpening = new SoftwareOpening(cpu, monitor); //reduces the complexicity
        softwareOpening.OpenSofware("Media Player");
        softwareOpening.CloseSoftware();
    }
    void InitiateFlyweightPattern()
    {
        CharacterDisplay display = new CharacterDisplay();
        ICharacter character = display.GetCharacter('M');
        character.Display(1000);
        character = display.GetCharacter('F'); //accessing shared data to reduce memory
        character.Display(1000);
        character = display.GetCharacter('Z');
        character.Display(1000);
    }
    void InitiateProxyPattern()
    {
        IPrint secondPrint = new SecondPrint("1st print");
        IPrint secondPrint2 = new SecondPrint("2nd print");
        secondPrint.Printing();
        secondPrint.Printing(); //won't show loading message
        secondPrint2.Printing(); //provides a surrogate or placeholder for another object to control access to it
    }
    void InitiateChainOfResponsibility()
    {
        Number number1 = new EvenNumber();
        Number number2 = new OddNumber();
        number1.NextNumber(number2); //pass the request to another class
        number1.CheckNumber(5);
        number1.CheckNumber(50);
        number1.CheckNumber(15);
    }
    void InitiateCommand()
    {
        Switch sw = new Switch();
        ISwitch ISw = new SwitchBoard(sw);
        ISw.SwitchOn();
        ISw.SwitchOff();
    }
    void InitiateInterpreter()
    {
        IString str = new StringExpression("Hello");
        bool result1 = str.CheckString("Hello, Good morning!");
        bool result2 = str.CheckString("Good night!");
        Console.WriteLine($"{result1},{result2}");
    }
    void InitiateIterator()
    {
        var AddNumber = new AddNumber<int>();
        AddNumber.AddNum(1);
        AddNumber.AddNum(2);
        var iterator = AddNumber.CreateAddFunction();
        while (iterator.checkNumber())
            Console.WriteLine(iterator.Add());
    }
    void InitiateMediator()
    {
        var mediator = new ExecutePassing();
        var firstPerson = new FirstPerson(mediator);
        var secondPerson = new SecondPerson(mediator);
        mediator.SetFirstPerson(firstPerson);
        mediator.SetSecondPerson(secondPerson);
        firstPerson.Pass("Hello, Second Person");
    }
    void InitiateMemento()
    {
        MiddleState middleState = new MiddleState();
        FinalState finalState = new FinalState();
        middleState.State = "State 3";
        finalState.SaveState(middleState.SaveState());
        middleState.State = "State 2";
        middleState.GetInitialState(finalState.GetState());
        Console.WriteLine(middleState.State); //state 3
    }
    void InitiateObserver()
    {
        ClassOne classOne = new ClassOne();
        IObserver observer1 = new Observer("Observer 1");
        IObserver observer2 = new Observer("Observer 2");
        classOne.Monitoring(observer1);
        classOne.Monitoring(observer2);
        classOne.Notify("Updating...");
    }
    void InitiateState()
    {
        ListStateName listStateName = new ListStateName();
        listStateName.SetState(new StateOne());
        listStateName.HandleRequest();
        listStateName.SetState(new StateTwo());
        listStateName.HandleRequest();
    }
    void InitiateTemplateMethod()
    {
        AbstractSteps steps = new Steps();
        steps.StepsTemplate();
    }
}


