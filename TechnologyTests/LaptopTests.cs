using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests;


[TestClass]
public class LaptopTests
{
    [TestMethod]
    public void TestSetsWeightCorrectly()
    {
        Laptop testLaptop = new Laptop(16, 128, true, 14);
        Assert.AreEqual(14, testLaptop.Weight);
    }

    [TestMethod]
    public void TestCheckWeight()
    {
        Laptop testLaptop = new Laptop(16, 128, true, 14);
        Assert.AreEqual(testLaptop.CheckWeight(), "The laptop weighs 14 oz.");
    }

}