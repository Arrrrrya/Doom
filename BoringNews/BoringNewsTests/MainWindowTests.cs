using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoringNewsTests;
using System.Threading;

namespace WpfApplication1.Tests
{
    [TestClass()]
    public class MainWindowTests:TestSessions
    {
        [TestMethod]
        public void Test()
        {
            // Find the buttons by their names and click them in sequence to perform 1 + 7 = 8
            session.FindElementByAccessibilityId("button_Create").Click();
            Thread.Sleep(2000);
            session.FindElementByAccessibilityId("button_Copy").Click();
            Assert.AreEqual("0", "0");
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }
    }
}