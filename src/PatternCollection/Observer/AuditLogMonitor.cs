using System.Collections.Concurrent;

namespace PatternCollection.Observer;

public sealed class AuditLogMonitor
{
    readonly ConcurrentDictionary<Guid, IListener<AuditEvent>> _listeners = [];

    public Guid Subscribe(IListener<AuditEvent> listener)
    {
        var id = Guid.NewGuid();
        _listeners[id] = listener;
        return id;
    }

    public void UnSubscribe(Guid id)
    {
        _listeners.Remove(id, out _);
    }

    public void Run(AuditEvent audit)
    {
        OnChange(audit);
    }

    private void OnChange(AuditEvent audit)
    {
        Parallel.ForEach(_listeners, (item) =>
        {
            item.Value.OnChange(audit);
        });
    }
}
