namespace PatternCollection.CommandPattern;

public sealed class HttpRequestCommand : Command
{
    readonly ChuckNorrisRequest _request;

    public HttpRequestCommand(ChuckNorrisRequest request)
    {
        _request = request;
    }

    public override Task<string> Execute()
    {
        return _request.Run();
    }
}
