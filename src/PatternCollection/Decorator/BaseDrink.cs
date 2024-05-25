namespace PatternCollection.Decorator;

public sealed class BaseDrink(string name, decimal cost) : Beverage(name, cost)
{
    public override decimal Cost()
    {
        return _cost;
    }

    public override string GetDescription() => _name;
}
