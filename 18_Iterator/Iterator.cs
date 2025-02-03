namespace _18_Iterator
{
    internal abstract class Iterator
    {
        public abstract object First();

        public abstract object Next();

        public abstract bool IsDone();

        public abstract object CurrentItem();
    }

    internal class ConcreteIterator : Iterator
    {
        ConcreteAggregate aggregate;
        int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return current>=aggregate.Count;
        }

        public override object Next()
        {
            object result = null;
            if (current < aggregate.Count - 1)
            {
                result = aggregate[++current];
            }

            return result;
        }
    }
}
