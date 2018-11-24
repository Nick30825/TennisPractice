using System;
using System.Collections.Generic;

namespace TennisPractice
{
    public class Tennis
    {
        private int _firstPlyaerScoreTimes;
        private Dictionary<int, string> _ScoreLookup;
        private int _secondPlyaerScoreTimes;

        public String Score()
        {
            _ScoreLookup = new Dictionary< int , String >
            {
                {1, "Fifteen" },
                {2, "Thirty" },
                {3, "Forty" },
            };
            if (_firstPlyaerScoreTimes>0)
            {
                return $"{_ScoreLookup[_firstPlyaerScoreTimes]} Love";
            }

            if (_secondPlyaerScoreTimes == 1)
                return "Love Fifteen";

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlyaerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlyaerScoreTimes++;
        }
    }
}