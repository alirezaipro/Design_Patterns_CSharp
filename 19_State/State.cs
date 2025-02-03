using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_State
{
    internal abstract class State
    {
        public abstract void Handle(Context context);
    }

    internal class ConcreteStataA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStataB();
        }
    }

    internal class ConcreteStataB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStataA();
        }
    }
}
