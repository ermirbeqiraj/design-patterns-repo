namespace PatternCollection.StatePattern;

public sealed class SoldOutState(GumballMachine machine) : State
{
    readonly GumballMachine _machine = machine;
    
    public override void Dispense()
    {
        Console.WriteLine("Hehehe");
    }

    public override void EjectQuarter()
    {
        Console.WriteLine("What quarter?");
    }

    public override void InsertQuarter()
    {
        Console.WriteLine("Not possible");
    }

    public override void TurnCrank()
    {
        Console.WriteLine("Nothing's gonna happen");
    }
}
