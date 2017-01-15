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
        /// Tests a correct result for NotAnagrams 3 2 Ans: 1
        /// </summary>
        [TestMethod]
        public void TestCorrect1()
        {
            Assert.AreEqual(1, m.NotAnagrams(@"C:\Users\hannal\Downloads\test1.in"));
        }

        /// <summary>
        /// Tests a correct result for NotAnagrams 6 4 Ans: 2
        /// </summary>
        [TestMethod]
        public void TestCorrect2()
        {
            Assert.AreEqual(2, m.NotAnagrams(@"C:\Users\hannal\Downloads\test2.in"));
        }


        /// <summary>
        /// Tests a correct result for NotAnagrams 20 5 Ans: 6
        /// </summary>
        [TestMethod]
        public void TestCorrect3()
        {
            Assert.AreEqual(6, m.NotAnagrams(@"C:\Users\hannal\Downloads\test3.txt"));
        }

        /// <summary>
        /// Tests a correct result for NotAnagrams 36 10 Ans: 26
        /// </summary>
        [TestMethod]
        public void TestCorrect4()
        {
            Assert.AreEqual(26, m.NotAnagrams(@"C:\Users\hannal\Downloads\test4.txt"));
        }


        /// <summary>
        /// Tests a correct result for NotAnagrams 36 10 Ans: 0
        /// </summary>
        [TestMethod]
        public void TestCorrect5()
        {
            Assert.AreEqual(0, m.NotAnagrams(@"C:\Users\hannal\Downloads\test5.txt"));
        }
        /// <summary>
        /// Tests for an empty file
        /// </summary>
        [TestMethod]
        public void TestEmpty()
        {
            Assert.AreEqual(0, m.NotAnagrams(@"C:\Users\hannal\Downloads\testEmpty.txt"));
        }

        /// <summary>
        /// Tests for a FileNotFoundException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void TestFileNotFound()
        {
            m.NotAnagrams(@"C:\Users\hannal\Downloads\testNotFound.txt");
        }

        
    }
}
