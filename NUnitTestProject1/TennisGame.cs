using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class Player
    {
        private string _playerName;
        private int _score;

        public int Score
        {
            set
            {
                _score = value;
            }
            get
            {
                return _score;
            }
        }

        public string Name
        {
            get
            {
                return _playerName;
            }
        }

        public Player(string name)
        {
            _playerName = name;

        }
    }

    public class TennisGame
    {
        private Player _player1;
        private Player _player2;
        private Dictionary<int, string> _scoreMap = new Dictionary<int, string>()
        {
            { 0,  "Love"},
            { 1,  "Fifteen"},
            { 2,  "Thirty"},
            { 3,  "Forty"}
        };

        public void Player1AddScore()
        {
            _player1.Score++;
        }

        public void Player2AddScore()
        {
            _player2.Score++;
        }

        public string GetScore()
        {
            int subtractScore = _player1.Score - _player2.Score;

            if ((int)Math.Abs(subtractScore) > 3)
                return $"{(_player1.Score == 0 ? _player2.Name : _player2.Name) } Win"; 

            if (_player1.Score == _player2.Score)
            {
                return _player1.Score > 2 ? "Deuce" : $"{_scoreMap[_player1.Score]} All";
            }

            if (_player1.Score > 2 && _player2.Score > 2)
            {
                if ((int)Math.Abs(subtractScore) >= 2)
                    return $"{(subtractScore > 0 ? _player1.Name : _player2.Name) } Win";
                else
                    return $"{(subtractScore > 0 ? _player1.Name : _player2.Name) } Adv";
            }

            return $"{_scoreMap[_player1.Score]} {_scoreMap[_player2.Score]}";
        }

        public TennisGame(string player1Name, string player2Name)
        {
            _player1 = new Player(player1Name);
            _player2 = new Player(player2Name);
        }
    }
}
