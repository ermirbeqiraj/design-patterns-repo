using PatternCollection.StatePattern;

namespace PatternCollection.Tests;

public sealed class StatePatternTests
{
    [Fact]
    public void GumballMachine_State_IsExpected()
    {
        var machine = new GumballMachine(1);
        var startsAtNoQ = machine.GetCurrentState() is NoQuarterState;

        machine.InsertQuarter();

        var becomesHasQ = machine.GetCurrentState() is HasQuarterState;

        machine.EjectQuarter();

        var becomesNoQ = machine.GetCurrentState() is NoQuarterState;

        machine.InsertQuarter();

        machine.TurnCrank();

        var becomesSoldOut = machine.GetCurrentState() is SoldOutState;

        Assert.True(startsAtNoQ);
        Assert.True(becomesHasQ);
        Assert.True(becomesNoQ);
        Assert.True(becomesSoldOut);
    }
}