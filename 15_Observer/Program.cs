using _15_Observer;

ConcreteSubject concreteSubject = new ConcreteSubject();

concreteSubject.Attach(new ConcreteObserver(concreteSubject, "x"));
concreteSubject.Attach(new ConcreteObserver(concreteSubject, "y"));
concreteSubject.Attach(new ConcreteObserver(concreteSubject, "z"));

concreteSubject.SubjectState = "ABC";
concreteSubject.Notify();


Console.ReadLine();