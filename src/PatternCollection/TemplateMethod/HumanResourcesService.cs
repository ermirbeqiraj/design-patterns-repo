namespace PatternCollection.TemplateMethod;

public abstract class HumanResourcesService
{
    protected List<Candidate> _candidates = [];

    public Candidate GetTopCandidate()
    {
        PopulateCandidates();

        SortCandidates();

        return _candidates[0];
    }

    protected abstract void SortCandidates();

    protected virtual void PopulateCandidates()
    {
        _candidates =
        [
            new("Amanda", 3.1f, 1.2f, true),
            new("Willson", 3.1f, 1.2f, true),
        ];
    }
}
