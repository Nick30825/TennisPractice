using System;
using System.Collections.Generic;

namespace TennisPractice
{
    public class Tennis
    {
        private int _firstPlyaerScoreTimes;
        private Dictionary<int, string> _ScoreLookup = new Dictionary<int, String>
        {
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };
        private int _secondPlayerScoreTimes;

        public String Score()
        {
            
            if (_firstPlyaerScoreTimes>0)
            {
                return $"{_ScoreLookup[_firstPlyaerScoreTimes]} Love";
            }

            if (_secondPlayerScoreTimes >0)
                return $"Love {_ScoreLookup[_secondPlayerScoreTimes]}";

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlyaerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}