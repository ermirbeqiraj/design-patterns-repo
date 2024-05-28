using PatternCollection.Factory.AbstractFactory;

namespace PatternCollection.Tests;

public sealed class AbstractFactoryTests
{
    [Fact]
    public void PizzaPrepare_WhenGivenNYFactory_ReturnsNyTypes()
    {
        IIngredientFactory factory = new IIngredientFactoryNY();
        Pizza cheesePizza = new CheesePizza(factory);

        cheesePizza.Prepare();

        var isNyCheese = cheesePizza.Cheese is ChesseTypeNY;
        
        Assert.True(isNyCheese);
    }
}