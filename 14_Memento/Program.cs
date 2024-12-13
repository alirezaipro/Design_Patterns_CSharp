using _14_Memento;

Originator originator= new Originator();
originator.State = "On";

Caretaker caretaker= new Caretaker();

caretaker.Memento= originator.CreateMemento();

originator.State = "Off";

originator.SetMemento(caretaker.Memento);

Console.WriteLine("Finish");