using System.Net.Http.Json;

namespace PatternCollection.CommandPattern;

public abstract class Command
{ 
    public abstract Task<string> Execute();
}
