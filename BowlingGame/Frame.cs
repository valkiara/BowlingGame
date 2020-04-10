using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class Frame
    {
        private int itsScore;

        public int getScore()
        {
            return itsScore;
        }

        public void Add(int pins)
        {
            itsScore += pins;
        }
    }

}
