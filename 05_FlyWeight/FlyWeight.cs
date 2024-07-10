using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FlyWeight
{
    public abstract class FlyWeight
    {
        public abstract void Operation(string extrinsicState);
    }

    public class ConcreteFlyWeight : FlyWeight
    {
        private readonly string _intrinsicState;

        public ConcreteFlyWeight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        public override void Operation(string extrinsicState)
        {
            Console.WriteLine($"ConcreteFlyWeight=> Oprtion => extrinsicState:{extrinsicState} => intrinsicState:{_intrinsicState}");
        }
    }
}
