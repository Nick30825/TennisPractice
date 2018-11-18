using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisPractice
{
    [TestClass]
    public class TennisTests
    {
        private Tennis _tennis = new Tennis();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        private void ScoreShouldBe(string excepted)
        {
            Assert.AreEqual(excepted, _tennis.Score());
        }
    }
}

