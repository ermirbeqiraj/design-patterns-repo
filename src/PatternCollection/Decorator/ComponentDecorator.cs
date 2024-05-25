namespace PatternCollection.Decorator;

public abstract class ComponentDecorator(string name, decimal cost) : Beverage(name, cost)
{

    protected Beverage? _beverage;
}
