using PatternCollection.Observer;
using PatternCollection.Observer.Listeners;

namespace PatternCollection.Tests;

public class ObserverTests
{
    [Theory]
    [InlineData(22f)]
    [InlineData(32f)]
    [InlineData(42f)]
    [InlineData(52f)]
    public void Subscribe_WhenListening_ReceivesUpdates(float temp)
    {
        var subject = new AuditLogMonitor();
        var fileLogs = new FileLogListener();
        var structureLogs = new StructuredLogListener();

        var audit = new AuditEvent { Temperature = temp };

        subject.Subscribe(fileLogs);
        subject.Subscribe(structureLogs);
        subject.Run(audit);

        Assert.NotNull(fileLogs.LastEvent);
        Assert.NotNull(structureLogs.LastEvent);
        Assert.Equal(audit, fileLogs.LastEvent);
        Assert.Equal(audit, structureLogs.LastEvent);
    }
}