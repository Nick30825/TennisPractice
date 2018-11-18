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

        [TestMethod]
        public void Fiftenn_Love()
        {
            _tennis.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }
        
        private void ScoreShouldBe(string excepted)
        {
            Assert.AreEqual(excepted, _tennis.Score());
        }
    }
}

