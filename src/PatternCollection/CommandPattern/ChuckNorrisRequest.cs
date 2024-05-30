namespace PatternCollection.CommandPattern;

public sealed class ChuckNorrisRequest
{
    readonly HttpClient _client;

    public ChuckNorrisRequest()
    {
        _client = new HttpClient(); // assume we're getting this from DI system
    }

    public async Task<string> Run()
    {
        var response = await _client.GetAsync("https://api.chucknorris.io/jokes/random");
        response.EnsureSuccessStatusCode();

        var body = await response.Content.ReadAsStringAsync();
        return body;
    }
}