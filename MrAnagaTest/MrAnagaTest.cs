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
        
    }
}
