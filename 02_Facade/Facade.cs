using _02_Facade.Package1;
using _02_Facade.Package2;
using _02_Facade.Package3;

namespace _02_Facade;

public class Facade
{
    public void DoSomethig()
    {
        Class1 class1=new Class1();
        Class2 class2=new Class2();
        Class3 class3=new Class3();

        class1.Run();
        class3.Run();
        
        class2.Run();
    }
}