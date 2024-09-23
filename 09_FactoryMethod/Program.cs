using _09_FactoryMethod;

IProductService productService1;
IProductService productService2;
IProductService productService3;

Creator creator = new ConcreteCreator();

productService1 = creator.GetInstance(10);
productService1.Execute();

Console.WriteLine("----------------------------");

productService2 = creator.GetInstance(0);
productService2.Execute();

Console.WriteLine("----------------------------");

productService3 = creator.GetInstance(-10);
productService3.Execute();