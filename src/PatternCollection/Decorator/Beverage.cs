namespace PatternCollection.Decorator;

public abstract class Beverage(string name, decimal cost)
{
    protected readonly decimal _cost = cost;
    protected readonly string _name = name;

    public abstract decimal Cost();
    public abstract string GetDescription();
}
