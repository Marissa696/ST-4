namespace BugTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test_Assign_To_Assigned()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Assigned, state);
    }

    [TestMethod]
    public void Test_Assign_To_Closed()
    {
        var bug = new Bug(Bug.State.Assigned);
        bug.Close();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Closed, state);
    }

    [TestMethod]
    public void Test_Close_While_Open()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Close();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Open, state);
    }

    [TestMethod]
    public void Test_Defer_While_Assigned()
    {
        var bug = new Bug(Bug.State.Assigned);
        bug.Defer();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Defered, state);
    }

    [TestMethod]
    public void Test_Defer_While_Closed()
    {
        var bug = new Bug(Bug.State.Closed);
        bug.Defer();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Closed, state);
    }

    [TestMethod]
    public void Test_Assign_While_Closed()
    {
        var bug = new Bug(Bug.State.Closed);
        bug.Assign();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Closed, state);
    }

    [TestMethod]
    public void Test_Close_While_Assigned()
    {
        var bug = new Bug(Bug.State.Assigned);
        bug.Close();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Closed, state);
    }

    [TestMethod]
    public void Test_Assign_While_Deferred()
    {
        var bug = new Bug(Bug.State.Defered);
        bug.Assign();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Assigned, state);
    }

    [TestMethod]
    public void Test_Defer_While_Deferred()
    {
        var bug = new Bug(Bug.State.Defered);
        bug.Defer();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Defered, state);
    }

    [TestMethod]
    public void Test_Close_While_Deferred()
    {
        var bug = new Bug(Bug.State.Defered);
        bug.Close();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Closed, state);
    }

    [TestMethod]
    public void Test_Assign_While_Assigned()
    {
        var bug = new Bug(Bug.State.Assigned);
        bug.Assign();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Assigned, state);
    }

    [TestMethod]
    public void Test_Assign_While_Open()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Assigned, state);
    }

    [TestMethod]
    public void Test_Defer_While_Closed()
    {
        var bug = new Bug(Bug.State.Closed);
        bug.Defer();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Closed, state);
    }

    [TestMethod]
    public void Test_Close_While_Open()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Close();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Open, state);
    }
}