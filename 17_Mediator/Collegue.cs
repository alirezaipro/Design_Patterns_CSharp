using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Mediator
{
    internal abstract class Collegue
    {
        protected Mediator mediator;

        protected Collegue(Mediator mediator)
        {
            this.mediator = mediator;
        }

    }

    internal class ConcreteCollegue1 : Collegue
    {
        public ConcreteCollegue1(Mediator mediator) : base(mediator)
        {

        }

        public void Notify(string message)
        {
            Console.WriteLine($"Collegue 1 get message : {message}");
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

    }

    internal class ConcreteCollegue2 : Collegue
    {
        public ConcreteCollegue2(Mediator mediator) : base(mediator)
        {

        }

        public void Notify(string message)
        {
            Console.WriteLine($"Collegue 2 get message : {message}");
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }
    }
}
