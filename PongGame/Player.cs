﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace PongGame
{
    public class Player
    {
        private const int movementSpeed = 3;
        public bool isUpPressed, isDownPressed;
        public PictureBox paddle;
        private Label scoreLabel;
        private bool? wasGoingUpLastTick;
        private int numberOfTicksGoingInTheSameDirection;
        private int _score;
        private int x;
        public int score
        {
            get { return _score;}
            set { _score = value;
                x= int.Parse(scoreLabel.Text = score.ToString());
            }
        }
      
        

        public Player(PictureBox aPaddle1, Label scoreLabel)
        {
            this.paddle = aPaddle1;
            this.scoreLabel = scoreLabel;
        }

        internal void ProcessMove()
        {
            bool? goingUp = null;

                if (isUpPressed)
                {
                    goingUp = true;
                }

                if (isDownPressed)
                {
                    if (goingUp.HasValue)
                    {
                        goingUp = null;
                    }
                    else
                    {
                        goingUp = false;
                    }
                }

                if (wasGoingUpLastTick.HasValue)
                {
                    if (!goingUp.HasValue)
                    {
                        wasGoingUpLastTick = null;
                        numberOfTicksGoingInTheSameDirection = 0;
                    }
                    else if (wasGoingUpLastTick.Value == goingUp.Value)
                    {
                        numberOfTicksGoingInTheSameDirection++;
                    }
                    else
                    {
                        wasGoingUpLastTick = goingUp;
                        numberOfTicksGoingInTheSameDirection = 1;
                    }
                }
                else if (goingUp.HasValue)
                {
                    wasGoingUpLastTick = goingUp;
                    numberOfTicksGoingInTheSameDirection = 1;
                }

                DoMove(goingUp);
        }

        private void DoMove(bool? goingUp)
        {
            if (goingUp.HasValue)
            {
                var speed = (int) Math.Round(movementSpeed * ((float) numberOfTicksGoingInTheSameDirection / 10));
                if (goingUp.Value)
                {
                    speed *= -1;
                }

                paddle.Location = new Point(paddle.Location.X,
                    Math.Max(PongWorldInfo.topOfWorld, Math.Min(PongWorldInfo.bottomOfWorld - paddle.Size.Height, paddle.Location.Y + speed)));
            }

        }
    }
        
    
}
