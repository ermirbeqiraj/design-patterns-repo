namespace PatternCollection.Factory.AbstractFactory;

public sealed class IIngredientFactoryNY : IIngredientFactory
{
    public Cheese CreateCheese()
    {
        return new ChesseTypeNY();
    }

    public Sauce CreateSauce()
    {
        return new SaceTypeNY();
    }
}
