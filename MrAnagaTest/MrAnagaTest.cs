using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS4150PS1;
using System.IO;
using System.Collections;

namespace MrAnagaTest
{
    [TestClass]
    public class MrAnagaTest
    {
        MrAnaga m = new MrAnaga();
        ArrayList words;

        /// <summary>
        /// Tests a correct result 3 2 1
        /// </summary>
       [TestMethod]
       public void TestCorrect1()
        {
            words = new ArrayList();
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\test1.in"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }

            Assert.AreEqual("1", m.NotAnagrams(words));
        }

        /// <summary>
        /// Tests a correct result 6 4 2
        /// </summary>
        [TestMethod]
        public void TestCorrect2()
        {
            words = new ArrayList();
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\test2.in"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }

            Assert.AreEqual("2", m.NotAnagrams(words));
        }

        /// <summary>
        /// Tests a correct result 
        /// </summary>
        [TestMethod]
        public void TestCorrect3()
        {
            words = new ArrayList();
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\test3.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }

            Assert.AreEqual("6", m.NotAnagrams(words));
        }

        /// <summary>
        /// Tests a correct result
        /// </summary>
        [TestMethod]
        public void TestCorrect4()
        {
            words = new ArrayList();
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\test4.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }

            Assert.AreEqual("26", m.NotAnagrams(words));
        }

        /// <summary>
        /// Tests a correct result
        /// </summary>
        [TestMethod]
        public void TestCorrect5()
        {
            words = new ArrayList();
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\test5.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }
            Assert.AreEqual("0", m.NotAnagrams(words));
        }
    }
}
