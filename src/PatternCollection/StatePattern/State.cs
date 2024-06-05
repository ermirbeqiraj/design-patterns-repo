namespace PatternCollection.StatePattern;

public abstract class State
{
    public abstract void InsertQuarter();
    public abstract void EjectQuarter();
    public abstract void TurnCrank();
    public abstract void Dispense();
}
