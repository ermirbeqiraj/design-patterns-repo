namespace PatternCollection.Composite;

public abstract class OrganizationComponent
{
    public abstract void Add(OrganizationComponent component);
    public abstract void Print();
}
