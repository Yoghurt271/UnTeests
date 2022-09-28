using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnTeests.Tests
{
    [TestClass]
    public class UnTeests : Raschet
    {
        [TestMethod]
        public void Perim_5and5_20()
        {
            first = 5;
            second = 5;
            double expented = 20;
            Perim();
            Assert.AreEqual(result, expented);

        }
        [TestMethod]
        public void Diamm()
        {
            first = 6.28;
            double expented = 1;
            Diam();
            Assert.AreEqual(result, expented);
        }
    }
}
