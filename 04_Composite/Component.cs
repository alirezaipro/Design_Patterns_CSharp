namespace _04_Composite;

public abstract class Component
{
    protected string _name;

    protected Component(string name)
    {
        _name = name;
    }

    public abstract void Add(Component component);

    public abstract void Remove(Component component);

    public abstract void Display(int depth);
}

public class Composite : Component
{
    private List<Component> _components = new List<Component>();

    public Composite(string name) : base(name)
    {
    }

    public Composite(string name, Component[] components) : base(name)
    {
        foreach (var item in components)
        {
            Add(item);
        }
    }

    public override void Add(Component component)
    {
        _components.Add(component);
    }

    public override void Remove(Component component)
    {
        _components.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
        foreach (var item in _components)
        {
            item.Display(depth + 2);
        }
    }
}

public class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
    }

    public override void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public override void Remove(Component component)
    {
        throw new NotImplementedException();
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
    }
}