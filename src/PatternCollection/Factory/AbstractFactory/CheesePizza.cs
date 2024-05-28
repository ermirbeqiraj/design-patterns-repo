namespace PatternCollection.Factory.AbstractFactory;

public sealed class CheesePizza : Pizza
{
    private readonly IIngredientFactory _ingredientFactory;

    public CheesePizza(IIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }
    public override void Prepare()
    {
        Cheese = _ingredientFactory.CreateCheese();
        _sauce = _ingredientFactory.CreateSauce();
    }
}