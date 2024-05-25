using PatternCollection.Factory.FactoryMethod;

namespace PatternCollection.Tests;

public sealed class FactoryMethodTests
{
    [Fact]
    public void Order_WhenGivenKnownType_ReturnsCorrectImplementation()
    {
        PizzaStore store = new NyPizzaStore();

        var pizza = store.Order("Cheese");
    
        Assert.True(pizza is NyCheesePizza);
    }
}
