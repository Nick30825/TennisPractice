﻿using System;
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
        private string _firstPlayerName;
        private string _secondPlayerName;

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _secondPlayerName = secondPlayerName;
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public String Score()
        {
            return IsScoreDifferent()
                ? (IsReadyForGamePoint() ? AdvState() : LookupScore())
                : (IsDeuce() ? Deuce() : SomeScore());
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private string AdvState()
        {
            return IsAdv() ? $"{AdvPlayer()} Adv" : $"{AdvPlayer()} Win";
        }

        private string AdvPlayer()
        {
            var advPlayer = _firstPlayerScoreTimes > _secondPlayerScoreTimes
                ? _firstPlayerName
                : _secondPlayerName;
            return advPlayer;
        }

        private bool IsReadyForGamePoint()
        {
            return _firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3;
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes ) == 1;
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes >= 3;
        }

        private bool IsScoreDifferent()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
        }

        private string LookupScore()
        {
            return $"{_ScoreLookup[_firstPlayerScoreTimes]} {_ScoreLookup[_secondPlayerScoreTimes]}";
        }

        private string SomeScore()
        {
            return $"{_ScoreLookup[_firstPlayerScoreTimes]} All";
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