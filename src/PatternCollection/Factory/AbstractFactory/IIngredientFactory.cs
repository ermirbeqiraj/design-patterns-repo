namespace PatternCollection.Factory.AbstractFactory;

public interface IIngredientFactory
{
    Sauce CreateSauce();

    Cheese CreateCheese();
}
