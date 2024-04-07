namespace BugTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test_Assign_To_Defer()
    {
        var bug = new Bug(Bug.State.Assigned);
        bug.Defer();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Defered, state);
    }
     [TestMethod]
    public void Test_Open_To_Assign()
    {
        var bug = new Bug(Bug.State.Open);
        bug.Assign();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Assigned, state);
    }
    [TestMethod]
    public void Test_Assign_To_Close()
    {
        var bug = new Bug(Bug.State.Assigned);
        bug.Close();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Closed, state);
    }
    [TestMethod]
    public void Test_Assign_To_Assign()
    {
        var bug = new Bug(Bug.State.Assigned);
        bug.Assign();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Assigned, state);
    }
    [TestMethod]
    public void Test_Close_To_Assign()
    {
        var bug = new Bug(Bug.State.Closed);
        bug.Assign();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Assigned, state);
    }
    [TestMethod]
    public void Test_Defer_To_Assign()
    {
        var bug = new Bug(Bug.State.Defered);
        bug.Assign();
        Bug.State state = bug.getState();
        Assert.AreEqual(Bug.State.Assigned, state);
    }
    [TestMethod]
    public void Test_Defer_To_Close_Exception()
    {
        var bug = new Bug(Bug.State.Defered);
        Assert.ThrowsException<InvalidOperationException>(() => bug.Close());
    }
    [TestMethod]
    public void Test_Close_To_Defer_Exception()
    {
        var bug = new Bug(Bug.State.Closed);
        Assert.ThrowsException<InvalidOperationException>(() => bug.Defer());
    }  
    [TestMethod]
    public void Test_Open_To_Defer_Exception()
    {
        var bug = new Bug(Bug.State.Open);
        Assert.ThrowsException<InvalidOperationException>(() => bug.Defer());
    }      
    [TestMethod]
    public void Test_Open_To_Close_Exception()
    {
        var bug = new Bug(Bug.State.Open);
        Assert.ThrowsException<InvalidOperationException>(() => bug.Close());
    }
}