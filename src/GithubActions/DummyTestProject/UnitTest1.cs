using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DummyTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1)]
        public void TestMethod1(int value)
        {
            Assert.AreEqual(1, value);
        }
    }
}
