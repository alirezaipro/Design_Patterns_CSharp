using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Strategy
{
    public class Context
    {
        private Strategy _strategy;

        public Context(Strategy strategy)
        {
            _strategy= strategy;
        }

        public void Operation()
        {
            Console.WriteLine("Operation is runing");
            _strategy.Algoritm();
        }

    }
}
