using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests;


[TestClass]
public class ComputerTests
{
    [TestMethod]
    public void TestAddRam()
    {
        Computer testComputer = new Computer(16, 128, true);
        Assert.AreEqual(16, testComputer.Ram);
        testComputer.AddRam(16);
        Assert.AreEqual(32, testComputer.Ram);
    }

    [TestMethod]
    public void TestAddStorage()
    {
        Computer testComputer = new Computer(16, 128, true);
        Assert.AreEqual(128, testComputer.Storage);
        testComputer.AddStorage(128);
        Assert.AreEqual(256, testComputer.Storage);
    }

    [TestMethod]
    public void TestSetValues()
    {
        Computer testComputer = new Computer(16, 128, true);
        Assert.AreEqual(16, testComputer.Ram);
        Assert.AreEqual(128, testComputer.Storage);
        Assert.IsTrue(testComputer.hasKeyboard);
    }
}
