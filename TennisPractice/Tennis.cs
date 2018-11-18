using System;

namespace TennisPractice
{
    public class Tennis
    {
        private int _firstPlyaerScoreTimes;


        public String Score()
        {
            if (_firstPlyaerScoreTimes == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlyaerScoreTimes++;
        }
    }
}