using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnTeests.Tests
{
    [TestClass]
    public class UnTeests : Raschet
    {
        [TestMethod]
        public void Computte()
        {
            Raschet raschet = new Raschet();
            first = 5;
            second = 5;
            double result = 20;
            double actual = 20;
            Compute();
            Assert.AreEqual(result, actual);

        }
    }
}
