using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace PongGame
{
    class Ball
    {
        private PictureBox ball;
        private Random rand = new Random();
        Player leftsidePlayer, rightsidePlayer;
        private int xSpeed, ySpeed;
        

        public Ball(PictureBox aBall, Player leftsidePlayer, Player rightsidePlayer)
        {
            this.ball = aBall;
            this.leftsidePlayer = leftsidePlayer;
            this.rightsidePlayer = rightsidePlayer;
            xSpeed = 1;
            ySpeed = 2;
            ResetBall();
        }

        internal void ProcessMove()
        {
            DoMove(); var bottom = PongWorldInfo.bottomOfWorld - ball.Height;

            if (ball.Location.Y >= bottom || ball.Location.Y <= PongWorldInfo.topOfWorld)
            {
                ySpeed *= -1;
            }

            if (ball.Location.X <= PongWorldInfo.leftOfWorld)
            {
                Score(leftsidePlayer);
            }
            else if (ball.Location.X >= PongWorldInfo.rightOfWorld - ball.Width)
            {
                Score(rightsidePlayer);
            }

            if(leftsidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)
               || rightsidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds))
            {
                xSpeed *= -1;
                ySpeed *= 1;
                while (leftsidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)
                       || rightsidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds))
                {
                    DoMove();
                }
            }

        }

        private int DoMove()
        {
            var bottom = PongWorldInfo.bottomOfWorld - ball.Height;
            ball.Location = new Point(ball.Location.X + xSpeed,
                Math.Max(PongWorldInfo.topOfWorld,
                    Math.Min(bottom, ball.Location.Y + ySpeed)));
            return bottom;
        }

        private void Score(Player winningPlayer)
        {
            winningPlayer.score++;
            ResetBall();
        }

        private void ResetBall()
        {
            ball.Location = new Point((PongWorldInfo.leftOfWorld + PongWorldInfo.rightOfWorld) / 2,
                (PongWorldInfo.topOfWorld + PongWorldInfo.bottomOfWorld) / 2);

            do
            {
                xSpeed = rand.Next(-3, 3);
                ySpeed = rand.Next(-3, 3);
            } while (Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 3);
        }
    }
}
