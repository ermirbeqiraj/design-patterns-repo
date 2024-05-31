using PatternCollection.ObjectAdapter;

namespace PatternCollection.Tests;

public sealed class ObjectAdapterTests
{
    [Fact]
    public void DoThingsTheNewWay_WhenInvoked_BringsNewResult()
    {
        var oldServiceWithManyReferences = new OldFrameworkService();
        IShinyNewInterface theNewWay = new OldFrameworkServiceAdapter(oldServiceWithManyReferences);
    
        // When
        var resultOfTheNewWay = theNewWay.DoThingsTheNewWay();
    
        // Then
        Assert.Equal($"{oldServiceWithManyReferences.Method1()}:{oldServiceWithManyReferences.Method2()}",resultOfTheNewWay );
    }
}