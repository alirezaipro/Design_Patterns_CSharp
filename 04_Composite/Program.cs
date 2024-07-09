using _04_Composite;

Component component = new Composite("Root Item", new Component[]
{
    new Leaf("Leaf Item 1"),
    new Leaf("Leaf Item 2"),
    new Composite("Composite 1", new Component[]
    {
        new Leaf("Leaft Item c 1-1"),
        new Leaf("Leaft Item c 1-2"),
        new Leaf("Leaft Item c 1-3"),
        new Composite("Composite 1-1", new Component[]
        {
            new Leaf("Leaf Item 1-1-1")
        })
    }),
    new Leaf("Leaf Item 3"),
    new Leaf("Leaf Item 4"),
});

component.Display(1);