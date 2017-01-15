using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS4150PS1;

namespace MrAnagaTest
{
    [TestClass]
    public class MrAnagaTest
    {
        MrAnaga m = new MrAnaga();

        /// <summary>
        /// Tests a correct result for NotAnagrams
        /// </summary>
        [TestMethod]
        public void TestCorrect1()
        {
            Assert.AreEqual(1, m.NotAnagrams(@"C:\Users\hannal\Downloads\test1.in"));
        }

        /// <summary>
        /// Tests a correct result for NotAnagrams
        /// </summary>
        [TestMethod]
        public void TestCorrect2()
        {
            Assert.AreEqual(2, m.NotAnagrams(@"C:\Users\hannal\Downloads\test2.in"));
        }


        /// <summary>
        /// Tests a correct result for NotAnagrams
        /// </summary>
        [TestMethod]
        public void TestCorrect3()
        {
            Assert.AreEqual(2, m.NotAnagrams(@"C:\Users\hannal\Downloads\test2.in"));
        }

    }
}
