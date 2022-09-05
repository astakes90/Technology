using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class SmartphoneTests
    {
        [TestMethod]
        public void TestInheritingBaseConstructor()
        {
            Smartphone testingSmartphone = new Smartphone(2, 3, true, 800);
            Assert.IsNotNull(testingSmartphone.Id);
        }

        [TestMethod]
        public void TestSetsNumOfSelfiesCorrectly()
        {
            Smartphone testSmartphone = new Smartphone(16, 128, true, 14);
            Assert.AreEqual(14, testSmartphone.NumOfSelfies);
        }

        [TestMethod]
        public void AddSelfie()
        {
            Smartphone testSmartphone = new Smartphone(16, 128, true, 14);
            testSmartphone.TakeSelfie();

            Assert.AreEqual(15, testSmartphone.NumOfSelfies);
        }
    }
}

