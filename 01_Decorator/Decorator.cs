
namespace _01_Decorator
{
    public abstract class Decorator : Component
    {
        private readonly Component _component;

        protected Decorator(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            _component.Operation();
        }
    }

    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorator.Operation()");
        }
    }

    public class ConcreteDecorator_2 : Decorator
    {
        public ConcreteDecorator_2(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorator_2.Operation()");
        }
    }
}
