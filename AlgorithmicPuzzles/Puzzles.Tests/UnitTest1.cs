using System.Collections.Generic;
using System.Linq;
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
            var toTest = new StringAlgorithms().AllPermutations("123").ToList();
            var correctResult = new List<string>(){"123", "132", "213", "312", "231", "321"};

            for (var i = 0; i < toTest.Count; ++i)
            {
                Assert.IsTrue(toTest[i] == correctResult[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var stringAlgorithms = new StringAlgorithms();
            Assert.IsTrue(stringAlgorithms.AreAnagrams("123", "231"));
            Assert.IsFalse(stringAlgorithms.AreAnagrams("123", "211"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var toto = new StringAlgorithms().GetOnlyAnagrams(
                new List<string>() { "123", "451", "1021", "321"}
                );
            
        }
    }
}
