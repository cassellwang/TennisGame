using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void Setup()
        {
            _tennisGame = new TennisGame("Summer", "Cynthia");
        }

        [Test]
        public void ZeroToZero()
        {
            Assert.AreEqual("Love All", _tennisGame.GetScore());
        }

        [Test]
        public void OneToZero()
        {
            Play(1, 0);
            Assert.AreEqual("Fifteen Love", _tennisGame.GetScore());
        }

        [Test]
        public void ZeroToOne()
        {
            Play(0, 1);
            Assert.AreEqual("Love Fifteen", _tennisGame.GetScore());
        }

        [Test]
        public void OneToOne()
        {
            Play(1, 1);
            Assert.AreEqual("Fifteen All", _tennisGame.GetScore());
        }

        [Test]
        public void ThreeToThree()
        {
            Play(3, 3);
            Assert.AreEqual("Deuce", _tennisGame.GetScore());
        }

        [Test]
        public void ThreeToFour()
        {
            Play(3, 4);
            Assert.AreEqual("Cynthia Adv", _tennisGame.GetScore());
        }

        [Test]
        public void FourToFour()
        {
            Play(4, 4);
            Assert.AreEqual("Deuce", _tennisGame.GetScore());
        }

        [Test]
        public void ThreeToFive()
        {
            Play(3, 5);
            Assert.AreEqual("Cynthia Win", _tennisGame.GetScore());
        }
        [Test]
        public void FiveToFour()
        {
            Play(5, 4);
            Assert.AreEqual("Summer Adv", _tennisGame.GetScore());
        }

        [Test]
        public void ZeorToFour()
        {
            Play(0, 4);
            Assert.AreEqual("Cynthia Win", _tennisGame.GetScore());
        }

        [Test]
        public void SixToFour()
        {
            Play(6, 4);
            Assert.AreEqual("Summer Win", _tennisGame.GetScore());
        }

        private void Play(int scoreToPlay1, int scoreToPlay2)
        {
            for (int i = 1; i <= scoreToPlay1; i++)
            {
                _tennisGame.Player1AddScore();
            }

            for (int i = 1; i <= scoreToPlay2; i++)
            {
                _tennisGame.Player2AddScore();
            }
        }
    }
}