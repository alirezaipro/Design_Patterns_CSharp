using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ChainOfResponsibility
{
    internal abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    internal class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"ConcreteHandler1.HandleRequest() with value: {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    internal class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"ConcreteHandler2.HandleRequest() with value: {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    internal class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine($"ConcreteHandler3.HandleRequest() with value: {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
