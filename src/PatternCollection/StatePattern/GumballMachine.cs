namespace PatternCollection.StatePattern;

public sealed class GumballMachine
{
    readonly State _soldOutState;
    readonly State _noQuarterState;
    readonly State _hasQuarterState;
    readonly State _soldState;

    State _state;
    int _availableCount;

    public GumballMachine(int numberOfGumballs)
    {
        _soldOutState = new SoldOutState(this);
        _hasQuarterState = new HasQuarterState(this);
        _noQuarterState = new NoQuarterState(this);
        _soldState = new SoldState(this);

        _availableCount = numberOfGumballs;
        _state = _availableCount > 0 ? _noQuarterState : _soldOutState;
    }

    internal void SetState(State state)
    {
        _state = state;
    }

    internal State GetHasQuarterState() => _hasQuarterState;
    internal State GetNoQuarterState() => _noQuarterState;
    internal State GetSoldState() => _soldState;
    internal State GetSoldOutState() => _soldOutState;
    internal int GetAvailableCount() => _availableCount;

    public State GetCurrentState() => _state;
    public void InsertQuarter() => _state.InsertQuarter();
    public void EjectQuarter() => _state.EjectQuarter();
    public void TurnCrank()
    {
        _state.TurnCrank();
        _state.Dispense();
    }

    internal void ReleaseBall()
    {
        if (_availableCount > 0)
        {
            Console.WriteLine("Watch out...");
            _availableCount -= 1;
        }
    }
}
