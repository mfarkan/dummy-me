using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DunphyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1)]
        public void OneEquealsOne(int value)
        {
            Assert.AreEqual(1, value);
        }
    }
}
