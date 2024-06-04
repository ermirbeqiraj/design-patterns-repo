namespace PatternCollection.Composite;

public sealed class Employee(string name) : OrganizationComponent
{
    public string Name { get; } = name;

    public override void Add(OrganizationComponent component)
    {
        throw new NotImplementedException("?");
    }

    public override void Print()
    {
        Console.WriteLine(Name);
        Console.WriteLine("-----------------");
    }
}
