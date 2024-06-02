namespace PatternCollection.TemplateMethod;

public sealed class AccountingCandidateComparer : IComparer<Candidate>
{
    public int Compare(Candidate? x, Candidate? y)
    {
        var xScore = GetScore(x);
        var yScore = GetScore(y);

        if (xScore == yScore)
            return 0;

        return xScore < yScore ? 1 : -1;
    }

    // formula favors those whos name starts with reversed alphabet letters, because.. why not.
    private float GetScore(Candidate? candidate)
    {
        if (candidate is null)
            return 0f;

        int nameStartScore = candidate.Name.ToUpper()[0];
        return nameStartScore;
    }
}