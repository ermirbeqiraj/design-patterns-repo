using PatternCollection.Factory;

namespace PatternCollection.Tests;

public sealed class SimplePizzaFactoryTests
{
    [Fact]
    public void Order_WhenGivenKnownType_ReturnsCorrectImplementation()
    {
        var simpleFactory = new SimplePizzaFactory();
        var store = new PizzaStore(simpleFactory);
    
        var pizza = store.Order("CheesePizza");
    
        Assert.True(pizza is CheesePizza);
    }
}
