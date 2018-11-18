using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisPractice
{
    [TestClass]
    public class TennisTests
    {
        [TestMethod]
        public void LoveAll()
        {
            var tennis = new Tennis();
            Assert.AreEqual("Love All",tennis.Score());


        }
    }
}

