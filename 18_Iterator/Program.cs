using _18_Iterator;

ConcreteAggregate aggregate= new ConcreteAggregate();

aggregate[0] = "Item A";
aggregate[1] = "Item B";
aggregate[2] = "Item C";
aggregate[3] = "Item D";

Iterator iterator = aggregate.CreateIterator();

object item = iterator.First();

while (item != null)
{
    Console.WriteLine(item);
    item = iterator.Next();
}

Console.ReadLine();