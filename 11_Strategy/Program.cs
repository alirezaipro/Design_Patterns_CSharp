using _11_Strategy;


Context context_a = new Context(new ConcreteStrategyA());
Context context_b = new Context(new ConcreteStrategyB());
Context context_c = new Context(new ConcreteStrategyC());

context_a.Operation();
Console.WriteLine("----------------");

context_b.Operation();
Console.WriteLine("----------------");

context_c.Operation();
Console.WriteLine("----------------");