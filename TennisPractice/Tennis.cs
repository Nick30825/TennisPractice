using System;
using System.Collections.Generic;

namespace TennisPractice
{
    public class Tennis
    {
        private int _firstPlyaerScoreTimes;
        private Dictionary<int, string> _ScoreLookup;


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
            
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlyaerScoreTimes++;
        }
    }
}