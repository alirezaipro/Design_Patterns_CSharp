using _08_Singleton;

Singleton singleton_01 = Singleton.GetInstance();
Singleton singleton_02 = Singleton.GetInstance();

Console.WriteLine(singleton_01 == singleton_02);