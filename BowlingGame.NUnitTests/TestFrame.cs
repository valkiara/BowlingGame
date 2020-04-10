using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame.NUnitTests
{
    public class TestFrame
    {
        [Test]
        public void testScoreNoThrows()
        {
            Frame f = new Frame();
            Assert.AreEqual(0, f.getScore());
        }


        [Test]
        public void testAddOneThrow()
        {
            Frame f = new Frame();
            f.Add(5);
            Assert.AreEqual(5, f.getScore());
        }
    }
}
