using _01_Decorator;

#region 1

Console.WriteLine("ConcreteComponent:");

ConcreteComponent concrete = new ConcreteComponent();
concrete.Operation();

#endregion

Console.WriteLine("--------------------------------");

#region 2

Console.WriteLine("ConcreteDecorator:");

ConcreteComponent concrete2 = new ConcreteComponent();

ConcreteDecorator concreteDecorator = new ConcreteDecorator(concrete2);
concreteDecorator.Operation();


#endregion

Console.WriteLine("--------------------------------");

#region 3

Console.WriteLine("ConcreteDecorator_2:");

ConcreteComponent concrete3 = new ConcreteComponent();

ConcreteDecorator_2 concreteDecorator2 = new ConcreteDecorator_2(concrete3);
concreteDecorator2.Operation();

#endregion

Console.ReadLine();