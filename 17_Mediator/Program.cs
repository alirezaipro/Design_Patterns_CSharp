using _17_Mediator;

ConcreteMediator concreteMediator= new ConcreteMediator();

ConcreteCollegue1 c1 = new ConcreteCollegue1(concreteMediator);
ConcreteCollegue2 c2 = new ConcreteCollegue2(concreteMediator);

concreteMediator.Collegue1= c1;
concreteMediator.Collegue2= c2;

c1.Send("message 1");
c2.Send("Message 2");

Console.ReadLine();