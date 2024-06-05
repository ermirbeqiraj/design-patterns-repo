namespace PatternCollection.StatePattern;

public sealed class HasQuarterState(GumballMachine machine) : State
{
    readonly GumballMachine _machine = machine;

    public override void Dispense()
    {
        Console.WriteLine("Not possible");
    }

    public override void EjectQuarter()
    {
        _machine.SetState(_machine.GetNoQuarterState());
    }

    public override void InsertQuarter()
    {
        Console.WriteLine("No more slots");
    }

    public override void TurnCrank()
    {
        _machine.SetState(_machine.GetSoldState());
    }
}