using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Strategy
{
    public abstract class Strategy
    {
        public abstract void Algoritm();
    }

    public class ConcreteStrategyA : Strategy
    {
        public override void Algoritm()
        {
            Console.WriteLine("ConcreteStrategyA.Algoritm()");
        }
    }

    public class ConcreteStrategyB : Strategy
    {
        public override void Algoritm()
        {
            Console.WriteLine("ConcreteStrategyB.Algoritm()");
        }
    }

    public class ConcreteStrategyC : Strategy
    {
        public override void Algoritm()
        {
            Console.WriteLine("ConcreteStrategyC.Algoritm()");
        }
    }
}
