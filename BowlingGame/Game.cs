using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class Game
    {
        private int itsCurrentFrame = 0;
        private bool firstThrowInFrame = true;
        private Scorer itsScorer = new Scorer();

        public int Score()
        {
            return ScoreForFrame(itsCurrentFrame);
        }

        public void Add(int pins)
        {
            itsScorer.AddThrow(pins);
            AdjustCurrentFrame(pins);
        }

        private void AdjustCurrentFrame(int pins)
        {
            if (LastBallInFrame(pins))
                AdvanceFrame();
            else
                firstThrowInFrame = false;
        }

        

       

        public int GetCurrentFrame()
        {
            return itsCurrentFrame;
        }
        

        private void AdvanceFrame()
        {
            itsCurrentFrame = Math.Min(10, itsCurrentFrame + 1);
        }

       
        public int ScoreForFrame(int theFrame)
        {
            return itsScorer.ScoreForFrame(theFrame);
        }

        private bool LastBallInFrame(int pins)
        {
            return Strike(pins) || !firstThrowInFrame;
        }

        private bool Strike(int pins)
        {
            return (firstThrowInFrame && pins == 10);
        }

    }
}
