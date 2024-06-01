namespace PatternCollection.FacadePattern;

public sealed class ContentFilterService
{
    private readonly string[] _bannedWords = ["java", "not java"];
    public bool ContentIsAllowed(string content)
    {
        var foundBannedWords = false;

        foreach(var word in _bannedWords)
        {
            if(content.IndexOf(word) > -1){
                foundBannedWords = true;
                break;
            }
        }

        return foundBannedWords == false;
    }
}
