using BowlingGame;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]

    public class TestGame
    {
        private Game g;

        [SetUp]
        public void Setup()
        {
            g = new Game();
        }


        [Test]
        public void TestTwoThrowsNoMark()
        {
            g.Add(4);
            g.Add(5);
            Assert.AreEqual(9, g.Score());
        }

        [Test]
        public void TestFourThrosNoMark()
        {
            g.Add(5);
            g.Add(4);
            g.Add(7);
            g.Add(2);
            Assert.AreEqual(18, g.Score());
            Assert.AreEqual(9, g.ScoreForFrame(1));
            Assert.AreEqual(18, g.ScoreForFrame(2));
        }

        [Test]
        public void TestSimpleSpare()
        {
            g.Add(3);
            g.Add(7);
            g.Add(3);
            Assert.AreEqual(13, g.ScoreForFrame(1));
        }



        [Test]
        public void TestSimpleFrameAfterSpare()
        {
            g.Add(3);
            g.Add(7);
            g.Add(3);
            g.Add(2);

            Assert.AreEqual(13, g.ScoreForFrame(1));
            Assert.AreEqual(18, g.ScoreForFrame(2));
            Assert.AreEqual(18, g.Score());
        }

        [Test]
        public void testSimpleStike()
        {
            g.Add(10);
            g.Add(3);
            g.Add(6);

            Assert.AreEqual(19, g.ScoreForFrame(1));
            Assert.AreEqual(28, g.Score());
        }


        [Test]
        public void TestPerfectGame()
        {
            for (int i = 0; i < 12; i++)
            {
                g.Add(10);
            }

            Assert.AreEqual(300, g.Score());
        }

        [Test]
        public void TestEndOfArray()
        {
            for (int i = 0; i < 9; i++)
            {
                g.Add(0);
                g.Add(0);
            }

            g.Add(2);
            g.Add(8); //10th frmae spare
            g.Add(10); //Strike in last position of array
            Assert.AreEqual(20, g.Score());

        }

        [Test]
        public void TestSampleGame()
        {
            g.Add(1);
            g.Add(4);
            g.Add(4);
            g.Add(5);
            g.Add(6);
            g.Add(4);
            g.Add(5);
            g.Add(5);
            g.Add(10);
            g.Add(0);
            g.Add(1);
            g.Add(7);
            g.Add(3);
            g.Add(6);
            g.Add(4);
            g.Add(10);
            g.Add(2);
            g.Add(8);
            g.Add(6);

            Assert.AreEqual(133, g.Score());
        }

        [Test]
        public void TestHeartBreak()
        {
            for (int i = 0; i < 11; i++)
            {
                g.Add(10);
            }
            g.Add(9);
            Assert.AreEqual(299, g.Score());
        }

        [Test]
        public void TestThenthFrameSpare()
        {
            for (int i = 0; i < 9; i++)
            {
                g.Add(10);
            }
            g.Add(9);
            g.Add(1);
            g.Add(1);
            Assert.AreEqual(270, g.Score());
        }
    }

}