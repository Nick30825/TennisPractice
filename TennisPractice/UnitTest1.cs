using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisPractice
{
    [TestClass]
    public class TennisTests
    {
        private Tennis _tennis = new Tennis("Bob","Jack");

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            GivenFirstPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen Love");
        }
        
        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScoreTimes(2);
            ScoreShouldBe("Thirty Love");
        }
        [TestMethod]
        public void Forty_Love()
        {
            GivenFirstPlayerScoreTimes(3);
            ScoreShouldBe("Forty Love");
        }
        [TestMethod]
        public void Love_Fifteen()
        {
            _tennis.SecondPlayerScore();
            ScoreShouldBe("Love Fifteen");
        }
        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerTimes(2);
            ScoreShouldBe("Love Thirty");
        }
        [TestMethod]
        public void Fifteen_All()
        {
            GivenFirstPlayerScoreTimes(1);
            GivenSecondPlayerTimes(1);
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScoreTimes(2);
            GivenSecondPlayerTimes(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void Deuce()
        {
            GivenDeuce();
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void FirstPlayerAdv()
        {
            GivenDeuce();
            GivenFirstPlayerScoreTimes(1);
            ScoreShouldBe("Bob Adv");
        }

        [TestMethod]
        public void SecondPlayerAdv()
        {
            GivenDeuce();
            GivenSecondPlayerTimes(1);
            ScoreShouldBe("Jack Adv");
        }

        [TestMethod]
        public void SecondPlayerWin()
        {
            GivenDeuce();
            GivenSecondPlayerTimes(2);
            ScoreShouldBe("Jack Win");
        }

        private void GivenDeuce()
        {
            GivenFirstPlayerScoreTimes(3);
            GivenSecondPlayerTimes(3);
        }

        private void GivenSecondPlayerTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.SecondPlayerScore();
            }
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScore();
            }            
        }

        private void ScoreShouldBe(string excepted)
        {
            Assert.AreEqual(excepted, _tennis.Score());
        }
    }
}

