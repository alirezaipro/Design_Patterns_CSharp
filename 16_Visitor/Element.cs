using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Visitor
{
    internal abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }

    internal class ConcreteElementA : Element
    {
        public string FullName { get; set; }

        public ConcreteElementA(string fullName)
        {
            FullName = fullName;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
    }

    internal class ConcreteElementB : Element
    {
        public int Score { get; set; }

        public ConcreteElementB(int score)
        {
            Score = score;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
    }
}
