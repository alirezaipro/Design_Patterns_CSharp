using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_FactoryMethod
{
    public interface IProductService
    {
        void Execute();
    }

    public class ConcreteProductService1 : IProductService
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteProductService1 => Execute()");
        }
    }

    public class ConcreteProductService2 : IProductService
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteProductService2 => Execute()");
        }
    }

    public class ConcreteProductServiceDefault : IProductService
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteProductServiceDefault => Execute()");
        }
    }
}
