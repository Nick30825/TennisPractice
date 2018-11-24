using System;
using System.Collections.Generic;

namespace TennisPractice
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private Dictionary<int, string> _ScoreLookup = new Dictionary<int, String>
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };
        private int _secondPlayerScoreTimes;

        public String Score()
        {
            
            if (_firstPlayerScoreTimes != _secondPlayerScoreTimes )
            {
                return $"{_ScoreLookup[_firstPlayerScoreTimes]} {_ScoreLookup[_secondPlayerScoreTimes]}";
            }

            if (_firstPlayerScoreTimes == 1)
            {
                return "Fifteen All";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}