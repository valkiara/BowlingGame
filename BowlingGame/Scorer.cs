using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class Scorer
    {
        private int[] itsThrows = new int[21];
        private int itsCurrentThrow;
        private int ball;

        public void AddThrow(int pins)
        {
            itsThrows[itsCurrentThrow++] = pins;
        }

        public int ScoreForFrame(int theFrame)
        {
            int score = 0;
            ball = 0;

            for (int currentFrame = 0; currentFrame < theFrame; currentFrame++)
            {
                if (Strike())//strike
                {
                    score += 10 + NextTwoBallsForStrike();
                    ball++;
                }
                else if (Spare())
                {
                    score += 10 + NextTwoBallsForSpare();
                    ball += 2;
                }
                else
                {
                    score += TwoBallsInFrame();
                    ball += 2;
                }

            }

            return score;
        }

        
        private bool Strike()
        {
            return itsThrows[ball] == 10;
        }

        private int NextTwoBalls()
        {
            return itsThrows[ball] + itsThrows[ball + 1];
        }

        private bool Spare()
        {
            return (itsThrows[ball] + itsThrows[ball + 1]) == 10;
        }

        private int NextBall()
        {
            return itsThrows[ball];
        }

        private int TwoBallsInFrame()
        {
            return itsThrows[ball] + itsThrows[ball + 1];
        }

        private int NextTwoBallsForStrike()
        {
            return itsThrows[ball +1] + itsThrows[ball + 2];
        }

        private int NextTwoBallsForSpare()
        {
            return itsThrows[ball + 2];
        }
    }
}
