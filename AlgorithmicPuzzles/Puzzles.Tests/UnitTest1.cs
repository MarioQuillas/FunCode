using Puzzles.SomeAlgos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Puzzles.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var toto = new StringAlgorithms();
            var titi = toto.AllPermutations("123");
        }
    }
}
