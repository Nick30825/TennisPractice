using System;
using System.Collections.Generic;

namespace TennisPractice
{
    public class Tennis
    {
        private int _firstPlyaerScoreTimes;


        public String Score()
        {
            var scoreLookup= new Dictionary< int , String >
            {
                {1, "Fifteen" },
                {2, "Thirty" },
            };
            if (_firstPlyaerScoreTimes == 1)
            {
                return $"{scoreLookup[_firstPlyaerScoreTimes]} Love";
            }
            if (_firstPlyaerScoreTimes == 2)
            {
                return $"{scoreLookup[_firstPlyaerScoreTimes]} Love";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlyaerScoreTimes++;
        }
    }
}