using PatternCollection.CommandPattern;

namespace PatternCollection.Tests;

public sealed class CommandTests
{
    [Fact]
    public async Task Command_WhenExecuted_ReturnsWebResponse()
    {
        // Given
        var receiver = new ChuckNorrisRequest();
        Command command = new HttpRequestCommand(receiver);
        // When
        var result = await command.Execute();
        // Then
        Assert.NotEmpty(result);
    }
}