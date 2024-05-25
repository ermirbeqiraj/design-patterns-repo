namespace PatternCollection.Factory.FactoryMethod;

public sealed class NyPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if(type == "Cheese")
        {
            return new NyCheesePizza();
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}
