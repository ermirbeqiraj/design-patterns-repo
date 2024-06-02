namespace PatternCollection.TemplateMethod;

public sealed class AccountingDepartmentResourcesService : HumanResourcesService
{
    private readonly IComparer<Candidate> _candidateComparer = new AccountingCandidateComparer();
    protected override void SortCandidates()
    {
        _candidates.Sort(_candidateComparer);
    }
}