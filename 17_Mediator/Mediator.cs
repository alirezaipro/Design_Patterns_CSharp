using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Mediator
{
    internal abstract class Mediator
    {
        public abstract void Send(string message,Collegue collegue);
    }

    internal class ConcreteMediator : Mediator
    {
        ConcreteCollegue1 collegue1;
        ConcreteCollegue2 collegue2;

        public ConcreteCollegue1 Collegue1
        {
            set { collegue1 = value; }
        }

        public ConcreteCollegue2 Collegue2
        {
            set { collegue2 = value; }
        }


        public override void Send(string message, Collegue collegue)
        {
            if (collegue == collegue1)
            {
                collegue2.Notify(message);
            }
            else
            {
                collegue1.Notify(message);
            }
        }
    }
}
