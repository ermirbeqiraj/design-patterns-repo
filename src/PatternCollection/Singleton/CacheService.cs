namespace PatternCollection.Singleton;

public sealed class CacheService
{
    private static CacheService? _instance = null;
    private static readonly object _padlock = new();
    
    private CacheService(){}

    public static CacheService Instance
    {
        get
        {
            lock(_padlock)
            {
                _instance ??= new CacheService();
                return _instance;
            }
        }
    }
}