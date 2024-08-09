using DesignPatterns.Creational_Patterns.Builder_Pattern;
using DesignPatterns.Creational_Patterns.Factory_Method;
using DesignPatterns.Singleton;

Console.WriteLine("Design Pattern. Happy Coding");
Console.WriteLine("Creational Patterns: ");
Console.WriteLine("------------------------------------------");
Console.WriteLine("Singleton");
Console.WriteLine("------------------------------------------");
InitiateSingleton();
Console.WriteLine("------------------------------------------");
Console.WriteLine("Factory Nethod");
Console.WriteLine("------------------------------------------");
InitiateFactoryMethod();
Console.WriteLine("------------------------------------------");
Console.WriteLine("Builder Pattern");
Console.WriteLine("------------------------------------------");
InitiateBuilderPattern();
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