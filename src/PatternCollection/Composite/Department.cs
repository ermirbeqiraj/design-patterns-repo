namespace PatternCollection.Composite;

public sealed class Department(string name) : OrganizationComponent
{
    readonly List<OrganizationComponent> _components = [];

    public string Name { get; } = name;

    public override void Print()
    {
        Console.WriteLine(Name);
        Console.WriteLine("-------------------------");

        foreach (var item in _components)
        {
            item.Print();
        }
    }

    public override void Add(OrganizationComponent component)
    {
        _components.Add(component);
    }
}
