using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Command
{
    public abstract class Command
    {
        protected Receiver receiver;

        protected Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }

    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            // Loging

            receiver.Action();
        }
    }

}
