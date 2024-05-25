namespace PatternCollection.Factory;

public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza;
        if(type == "CheesePizza")
        {
            pizza = new CheesePizza();
        }
        else
        {
            throw new NotImplementedException();
        }

        return pizza;
    }
}
