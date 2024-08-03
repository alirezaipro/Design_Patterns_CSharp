namespace _06_Adapter.ClassAdapter
{
    public class Adapter : Adaptee, ITarget
    {
        public void Operation()
        {
            AdapteeOperation();
        }
    }
}
