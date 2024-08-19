using DesignPatterns.Creational_Patterns.Adapter_Pattern;
using DesignPatterns.Creational_Patterns.Bridge_Pattern;
using DesignPatterns.Creational_Patterns.Builder_Pattern;
using DesignPatterns.Creational_Patterns.Factory_Method;
using DesignPatterns.Creational_Patterns.Prototype_Pattern;
using DesignPatterns.Singleton;

Console.WriteLine("Design Pattern. Happy Coding");
Console.WriteLine("Creational Patterns: ");
Console.WriteLine("------------------------------------------");
Console.WriteLine("Singleton");
InitiateSingleton();
Console.WriteLine("------------------------------------------");
Console.WriteLine("Factory Method");
InitiateFactoryMethod();
Console.WriteLine("------------------------------------------");
Console.WriteLine("Builder Pattern");
InitiateBuilderPattern();
Console.WriteLine("------------------------------------------");
Console.WriteLine("Prototype Pattern");
InitiatePrototypePattern();
Console.WriteLine("------------------------------------------");
Console.WriteLine("Adapter Pattern");
InitiateAdapterPattern();
Console.WriteLine("------------------------------------------");
Console.WriteLine("Bridge Pattern");
InitiateBridgePattern();
Console.WriteLine("------------------------------------------");
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
    foreach(var iceCreamQuantity in iceCreamQuantities)
    {
        iceCreamQuantity.Quantity();
    }
}