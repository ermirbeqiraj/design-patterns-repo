namespace PatternCollection.Factory.FactoryMethod;

public abstract class PizzaStore
{
    public Pizza Order(string type)
    {
        Pizza pizza = CreatePizza(type);

        pizza.Prepare();

        pizza.Bake();

        pizza.Cut();
        
        pizza.Box();
        
        return pizza;
    }

    protected abstract Pizza CreatePizza(string type);
}
