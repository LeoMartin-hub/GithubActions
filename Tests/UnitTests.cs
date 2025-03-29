namespace GithubActionsLab;

[TestClass]
public class OperationsTests
{
	 [TestMethod]
    public void Subtract_Valid_Patino()
    {
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(-4, Program.Subtract("3", "7"));
        Assert.AreEqual(0, Program.Subtract("5", "5"));
    }

    [TestMethod]
    public void Subtract_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }

    [TestMethod]
    public void Subtract_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }

    [TestMethod]
    public void Multiply_Valid_Patino()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(0, Program.Multiply("0", "7"));
        Assert.AreEqual(-15, Program.Multiply("-3", "5"));
    }

    [TestMethod]
    public void Multiply_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("2", "b"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("b", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("b", "b"));
    }

    [TestMethod]
    public void Multiply_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }

    [TestMethod]
    public void Divide_Valid_Patino()
    {
        Assert.AreEqual(2, Program.Divide("6", "3"));
        Assert.AreEqual(0, Program.Divide("0", "7"));
        Assert.AreEqual(-4, Program.Divide("-8", "2"));
    }

    [TestMethod]
    public void Divide_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("4", "c"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("c", "4"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("c", "c"));
    }

    [TestMethod]
    public void Divide_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("4", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "4"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }

    [TestMethod]
    public void Divide_ByZero_Patino()
    {
        Assert.ThrowsException<DivideByZeroException>(() => Program.Divide("4", "0"));
    }

    [TestMethod]
    public void Power_Valid_Patino()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
        Assert.AreEqual(0.25, Program.Power("2", "-2"));
    }

    [TestMethod]
    public void Power_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "d"));
        Assert.ThrowsException<FormatException>(() => Program.Power("d", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Power("d", "d"));
    }

    [TestMethod]
    public void Power_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}
