namespace PatternCollection.Observer.Listeners;

public sealed class StructuredLogListener : IListener<AuditEvent>
{
    public AuditEvent? LastEvent { get; private set; }

    public void OnChange(AuditEvent value)
    {
        LastEvent = value;
    }
}
