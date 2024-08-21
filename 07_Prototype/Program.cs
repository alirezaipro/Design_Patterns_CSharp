using _07_Prototype;

//Shallow Copy
ConcreatPrototype1 concreatPrototype1 = new ConcreatPrototype1();
ConcreatPrototype1 concreatPrototype1_2 = (ConcreatPrototype1)concreatPrototype1.Clone();

Console.WriteLine("Shallow Copy:");
Console.WriteLine(concreatPrototype1==concreatPrototype1_2);

//Deep Copy
ConcreatPrototype2 concreatPrototype2 = new ConcreatPrototype2();
ConcreatPrototype2 concreatPrototype2_2 = (ConcreatPrototype2)concreatPrototype2.Clone();

Console.WriteLine("---------------");
Console.WriteLine("Deep Copy:");
Console.WriteLine(concreatPrototype2 == concreatPrototype2_2);
Console.WriteLine(concreatPrototype2.Data == concreatPrototype2_2.Data);