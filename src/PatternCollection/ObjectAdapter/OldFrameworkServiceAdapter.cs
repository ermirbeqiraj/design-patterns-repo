namespace PatternCollection.ObjectAdapter;

// here's how we setup an adapter, which makes use of the old code, but in the new way ;)
public sealed class OldFrameworkServiceAdapter : IShinyNewInterface
{
    private readonly OldFrameworkService _oldie;
    public OldFrameworkServiceAdapter(OldFrameworkService oldFrameworkService)
    {
        _oldie = oldFrameworkService;
    }

    public string DoThingsTheNewWay()
    {
        var method1Result = _oldie.Method1();
        var method2Result = _oldie.Method2();

        return $"{method1Result}:{method2Result}"; // assume some changes in the requirements of the new interface
    }
}