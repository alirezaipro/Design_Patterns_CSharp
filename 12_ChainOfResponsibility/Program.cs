using _12_ChainOfResponsibility;

int[] requests = [2, 5, 14, 22, 18, 3, 27, 20];

Handler handler_01 = new ConcreteHandler1();
Handler handler_02 = new ConcreteHandler2();
Handler handler_03 = new ConcreteHandler3();

handler_01.SetSuccessor(handler_02);
handler_02.SetSuccessor(handler_03);

foreach(int i in requests)
{
   handler_01.HandleRequest(i);
}

Console.ReadLine();