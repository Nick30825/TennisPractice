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
                {1, "Fifteen Love" },
            };
            if (_firstPlyaerScoreTimes == 1)
            {
                return $"{scoreLookup[_firstPlyaerScoreTimes]}";
            }
            if (_firstPlyaerScoreTimes == 2)
            {
                return "Thirty Love";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlyaerScoreTimes++;
        }
    }
}