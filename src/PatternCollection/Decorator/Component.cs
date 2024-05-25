namespace PatternCollection.Decorator;

public sealed class Component : ComponentDecorator
{
    public Component(Beverage beverage, string name, decimal cost) : base(name, cost)
    {
        _beverage = beverage;
    }

    public override decimal Cost()
    {
        return _beverage!.Cost() + .20m;
    }

    public override string GetDescription()
    {
        return $"{_beverage!.GetDescription()}, {_name}";
    }
}
