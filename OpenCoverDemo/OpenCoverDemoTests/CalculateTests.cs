using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenCoverDemo.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [TestMethod()]
        public void GetSumTest()
        {
            int n = 10;
            if (n < 5)
            {
                Assert.IsTrue(Calculate.GetSum(n) == 55);
            }else
            {
                Assert.IsTrue(Calculate.GetSum(n) == 55);
            }
        }
    }
}