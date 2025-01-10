using _16_Visitor;

ConcreteElementA ca_01 = new ConcreteElementA("Ali Rezaei");
ConcreteElementA ca_02 = new ConcreteElementA("Iman Madaeny");
ConcreteElementA ca_03 = new ConcreteElementA("Hamid Reza");
ConcreteElementA ca_04 = new ConcreteElementA("Sara Moradi");

ConcreteElementB cb_01 = new ConcreteElementB(20);
ConcreteElementB cb_02 = new ConcreteElementB(10);
ConcreteElementB cb_03 = new ConcreteElementB(15);
ConcreteElementB cb_04 = new ConcreteElementB(14);


ObjectStructor objectStructor=new ObjectStructor();

objectStructor.Add(ca_01);
objectStructor.Add(ca_02);
objectStructor.Add(ca_03);
objectStructor.Add(ca_04);

objectStructor.Add(cb_01);
objectStructor.Add(cb_02);
objectStructor.Add(cb_03);
objectStructor.Add(cb_04);

Visitor visitor = new ConcreteVistior2();

objectStructor.Accept(visitor);