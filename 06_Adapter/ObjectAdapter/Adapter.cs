namespace _06_Adapter.ObjectAdapter
{
    public class Adapter : Target
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public override void Operation()
        {
            _adaptee.AdapteeOperation();
        }
    }
}
