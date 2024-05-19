namespace PatternCollection.Strategy.PersistenceBehaviors;

public sealed class LocalPersistenceBehavior : IPersistenceBehavior
{
    public string Save()
    {
        return nameof(LocalPersistenceBehavior);
    }
}