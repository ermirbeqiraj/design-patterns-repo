namespace PatternCollection.Strategy;

public abstract class Player
{
    IPersistenceBehavior? _persistenceBehavior;
    public void SetPersistenceBehavior(IPersistenceBehavior behavior) => _persistenceBehavior = behavior;

    public string SaveState()
    {
        if (_persistenceBehavior == null)
            throw new InvalidOperationException();

        return _persistenceBehavior.Save();
    }
}

