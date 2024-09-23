using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProductService GetInstance(int i);
    }

    public class ConcreteCreator : Creator
    {
        public override IProductService GetInstance(int i)
        {
            if (i == 0)
            {
                return new ConcreteProductServiceDefault();
            }
            else if (i > 0)
            {
                return new ConcreteProductService1();
            }
            else
            {
                return new ConcreteProductService2();
            }
        }
    }
}
