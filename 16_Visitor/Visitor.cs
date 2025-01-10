using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Visitor
{
    internal abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA item);

        public abstract void VisitConcreteElementB(ConcreteElementB item);
    }

    internal class ConcreteVistior1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA item)
        {
            Console.WriteLine($"ConcreteVistior1 => Name:{item.GetType().Name} FullName:{item.FullName}");
        }

        public override void VisitConcreteElementB(ConcreteElementB item)
        {
            Console.WriteLine($"ConcreteVistior1 => Name:{item.GetType().Name} Score:{item.Score}");
        }
    }



    internal class ConcreteVistior2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA item)
        {
            Console.WriteLine($"ConcreteVistior2 => Name:{item.GetType().Name} FullName:{item.FullName}");
        }

        public override void VisitConcreteElementB(ConcreteElementB item)
        {
            Console.WriteLine($"ConcreteVistior2 => Name:{item.GetType().Name} Score:{item.Score}");
        }
    }
}
