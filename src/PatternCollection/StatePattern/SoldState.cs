namespace PatternCollection.StatePattern;

public sealed class SoldState(GumballMachine machine) : State
{
    readonly GumballMachine _machine = machine;

    public override void Dispense()
    {
        _machine.ReleaseBall();

        if (_machine.GetAvailableCount() > 0)
            _machine.SetState(_machine.GetNoQuarterState());
        else
            _machine.SetState(_machine.GetSoldOutState());
    }

    public override void EjectQuarter()
    {
        Console.WriteLine("Too late for that, don't you think?");
    }

    public override void InsertQuarter()
    {
        Console.WriteLine("Wait, get the ball!");
    }

    public override void TurnCrank()
    {
        Console.WriteLine("Hold up! One thing at a time.");
    }
}
