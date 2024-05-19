namespace PatternCollection.Strategy.PersistenceBehaviors;

public sealed class CloudPersistenceBehavior : IPersistenceBehavior
{
    public string Save()
    {
        return nameof(CloudPersistenceBehavior);
    }
}
