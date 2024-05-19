using PatternCollection.Strategy;
using PatternCollection.Strategy.PersistenceBehaviors;

namespace PatternCollection.Tests;

public class StrategyTests
{
    [Fact]
    public void Player_WhenSwappingBehavior_ReturnExpected()
    {
        Player player = new OnlinePlayer();

        player.SetPersistenceBehavior(new CloudPersistenceBehavior());
        var onlineState = player.SaveState();
        player.SetPersistenceBehavior(new LocalPersistenceBehavior());
        var offlineState = player.SaveState();

        Assert.Equal(nameof(CloudPersistenceBehavior), onlineState);
        Assert.Equal(nameof(LocalPersistenceBehavior), offlineState);
    }
}