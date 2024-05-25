using PatternCollection.Decorator;

namespace PatternCollection.Tests;

public sealed class DecoratorTests
{
    private readonly Beverage[] _drinks =
    [
        new BaseDrink("Espresso", 1.99m)
    ];

    private readonly Dictionary<string, decimal> _components = new()
    {
        { "Whipped Cream", .20m },
        { "Syrup", .20m },
        { "Whiskey", .20m },
    };

    [Fact]
    public void Decorator_WhenGivenComponents_ReturnsExpected()
    {
        Beverage espresso = _drinks[0];

        foreach (var item in _components)
        {
            espresso = new Component(espresso, item.Key, item.Value);
        }

        Assert.Equal(2.59m, espresso.Cost());
        Assert.Equal("Espresso, Whipped Cream, Syrup, Whiskey", espresso.GetDescription());
    }
}
