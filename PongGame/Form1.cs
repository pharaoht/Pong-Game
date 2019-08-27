using System;
using System.Windows.Forms;

namespace PongGame
{
    public partial class Form1 : Form
    {
        private const int movementSpeed = 3, topOfWorld = 0, bottomOfWorld = 455;
        private Player player1, player2;
        private Ball ball;

        public Form1()
        {
            InitializeComponent();
            player1 = new Player(aPaddle1, aLabelPlayer2);
            player2 = new Player(aPaddle2, aLabelPlayer1);
            ball = new Ball(aBall, player1, player2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ATimer_Tick(object sender, EventArgs e)
        {
            player1.ProcessMove();
            player2.ProcessMove();
            ball.ProcessMove();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKeys(e, true);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKeys(e, false);
        }
        private void CheckKeys(KeyEventArgs e, bool isDown)
        {
            switch (e.KeyCode)
            {
                case Keys.Oemcomma:
                case Keys.W:
                    player1.isUpPressed = isDown;
                    break;
                case Keys.O:
                case Keys.S:
                   player1.isDownPressed = isDown;
                    break;

                case Keys.Up:
                   player2.isUpPressed = isDown;
                    break;
                case Keys.Down:
                    player2.isDownPressed = isDown;
                    break;

                
                   
                
                    
               
            }
        }

        
    }
}
