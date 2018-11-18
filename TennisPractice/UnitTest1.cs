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
            tennis.Score();


        }
    }
}

