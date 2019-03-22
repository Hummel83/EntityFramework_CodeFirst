using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqLite;

namespace Unittest
{
    [TestClass]
    class ClasSqLiteDbConMods
    {
       private DbConMod bd;

        public ClasSqLiteDbConMods()
        {
            var bd = new SqLite.DbConMod();
        }


        [TestMethod]
        public void test1()
        {
            bd.addstring();
        }
    }
}
