using DesignPatterns.Singleton;

Console.WriteLine("Design Pattern. Happy Coding");
Console.WriteLine("----------------------------");
InitiateSingleton();
Console.WriteLine("----------------------------");
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