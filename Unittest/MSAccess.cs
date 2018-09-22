using Microsoft.VisualStudio.TestTools.UnitTesting;

using Repo.MsAccess.DemoData;

namespace Unittest
{
    [TestClass]
    public class MSAccess
    {
        [TestMethod]
        public void TestHundDemoDate()
        {
            var blu = new DemoHundeData();
            var huhu = blu.Hundeerstellen();

            Assert.AreEqual(1, huhu.Count);
        }
    }
}
