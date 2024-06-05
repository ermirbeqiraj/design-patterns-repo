namespace PatternCollection.StatePattern;

public sealed class NoQuarterState(GumballMachine machine) : State
{
    readonly GumballMachine _machine = machine;

    public override void Dispense()
    {
        Console.WriteLine("Nice try..");
    }

    public override void EjectQuarter()
    {
        Console.WriteLine("Eject what?");
    }

    public override void InsertQuarter()
    {
        _machine.SetState(_machine.GetHasQuarterState());
    }

    public override void TurnCrank()
    {
        Console.WriteLine("Crank turned, but no coins");
    }
}
