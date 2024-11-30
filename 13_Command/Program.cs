using _13_Command;

Receiver receiver = new Receiver();
Command command = new ConcreteCommand(receiver);
Invoker invoker = new Invoker();


invoker.SetCommand(command);
invoker.ExecuteCommand();


Console.ReadLine();