namespace PatternCollection.TemplateMethod;

public sealed class ITDepartmentHumanResourcesService : HumanResourcesService
{
    private readonly IComparer<Candidate> _candidateComparer = new ITCandidateComparer();

    protected override void SortCandidates()
    {
        _candidates.Sort(_candidateComparer);
    }
}
