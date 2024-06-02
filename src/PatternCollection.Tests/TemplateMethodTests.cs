using PatternCollection.TemplateMethod;

namespace PatternCollection.Tests;

public sealed class TemplateMethodTests
{
    [Fact]
    public void GetTopCandidate_WhenInvokedInDifferentDepartments_BringsDifferentCandidates()
    {
        HumanResourcesService hrOfIT = new ITDepartmentHumanResourcesService();
        HumanResourcesService hrOfAccounting = new AccountingDepartmentResourcesService();

        var topItCandidate = hrOfIT.GetTopCandidate();
        var topAccountantCand = hrOfAccounting.GetTopCandidate();

        Assert.NotEqual(topItCandidate, topAccountantCand);
    }
}