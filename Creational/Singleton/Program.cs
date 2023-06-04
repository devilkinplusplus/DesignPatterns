using Singleton;

SingletonTest obj = SingletonTest.GetInstance();
SingletonTest obj2 = SingletonTest.GetInstance();

if (obj.GetHashCode() == obj2.GetHashCode())
    Console.WriteLine("Same");

