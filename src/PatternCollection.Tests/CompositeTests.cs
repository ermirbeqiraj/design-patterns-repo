using PatternCollection.Composite;

namespace PatternCollection.Tests;

public sealed class CompositeTests
{
    [Fact]
    public void CompositePattern_WhenInvokePrint_AllNodesDisplay()
    {
        OrganizationComponent cLevel = new Department("CLevel");
        
        OrganizationComponent ceo = new Employee("Da Boss");
        OrganizationComponent cto = new Employee("Da boss 2");
        cLevel.Add(ceo);
        cLevel.Add(cto);

        OrganizationComponent mngmt = new Department("Mngrs");
        OrganizationComponent mng1 = new Employee("Manager 1");
        OrganizationComponent mng2 = new Employee("Manager 2");
        mngmt.Add(mng1);
        mngmt.Add(mng2);
        cLevel.Add(mngmt);

        OrganizationComponent eng = new Department("Engineering");
        eng.Add(new Employee("Engineer 1"));
        eng.Add(new Employee("Engineer 2"));
        eng.Add(new Employee("Engineer 3"));
        eng.Add(new Employee("Engineer 4"));
        eng.Add(new Employee("Engineer 5"));

        mngmt.Add(eng);

        cLevel.Print();
    }
}