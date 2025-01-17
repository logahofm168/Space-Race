using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Race
{
    public partial class Form1 : Form
    {
        // player variabels 
        Rectangle spacePlayer1 = new Rectangle(135, 360, 10, 30);
        Rectangle spacePlayer2 = new Rectangle(390, 360, 10, 30);

        //List of asteroids
        List<Rectangle> asteroid = new List<Rectangle>();
        List<int> asteroidSpeeds = new List<int>();

        // lables
        int P1score = 0;
        int P2score = 0;
        int time = 500;

        //player score
        int spaceplayer1Score = 0;
        int spaceplayer2Score = 0;

        //player speed
        int spacePlayer1Speed = 5;
        int spacePlayer2Speed = 5;

        //asteroid variabels 
        int asteroidSpeed = 4;
        int asteroidSize = 4;

        //player movments
        bool upPressed = false;
        bool downPressed = false;
        bool wPressed = false;
        bool sPressed = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Pen whitePen = new Pen(Color.White);

        Random ranGen = new Random();
        int ranValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move space player 1
            if (wPressed == true && spacePlayer1.Y > 0)
            {
                spacePlayer1.Y -= spacePlayer1Speed;
            }

            if (sPressed == true && spacePlayer1.Y < this.Height - spacePlayer1.Height)
            {
                spacePlayer1.Y += spacePlayer1Speed;
            }

            //move space player 2
            if (upPressed == true && spacePlayer2.Y > 0)
            {
                spacePlayer2.Y -= spacePlayer2Speed;
            }

            if (downPressed == true && spacePlayer2.Y < this.Height - spacePlayer2.Height)
            {
                spacePlayer2.Y += spacePlayer2Speed;
            }

            //create asteroid
            int ranValue = ranGen.Next(0, 101);

            if (ranValue < 20)
            {
                int size = ranGen.Next(5, 15);
                int y = ranGen.Next(0, this.Width - 285);
                Rectangle newAsteroid = new Rectangle(0, y, asteroidSize, asteroidSize);
                asteroid.Add(newAsteroid);
                asteroidSpeeds.Add(ranGen.Next(2, 3));
            }
            else if (ranValue < 30)
            {
                int size = ranGen.Next(5, 15);
                int y = ranGen.Next(0, this.Width - 285);
                Rectangle newAsteroid = new Rectangle(570, y, asteroidSize, asteroidSize);
                asteroid.Add(newAsteroid);
                asteroidSpeeds.Add(-2);
            }

            //astroid movments 
            for (int i = 0; i < asteroid.Count; i++)
            {
                int x = asteroid[i].X + asteroidSpeeds[i];
                asteroid[i] = new Rectangle(x, asteroid[i].Y, asteroid[i].Width, asteroid[i].Height);
            }

            //Remove if astroid goes off screen 
            for (int i = 0; i < asteroid.Count; i++)
            {
                if (asteroid[i].X > 600)
                {
                    asteroid.RemoveAt(i);
                    asteroidSpeeds.RemoveAt(i);
                }
            }

            //check if either player hits an astroid and reset them 
            for (int i = 0; i < asteroid.Count; i++)
            {
                if (spacePlayer1.IntersectsWith(asteroid[i]))
                {
                    spacePlayer1.X = (135);
                    spacePlayer1.Y = (360);
                }
                else if (spacePlayer2.IntersectsWith(asteroid[i]))
                {
                    spacePlayer2.X = (390);
                    spacePlayer2.Y = (360);
                }
            }

            //Add point to player and resets corasponding player 
            if (spacePlayer1.Y < 10)
            {
                P1score++;

                spacePlayer1.X = (135);
                spacePlayer1.Y = (360);
            }

            if (spacePlayer2.Y < 10)
            {
                P2score++;

                spacePlayer2.X = (390);
                spacePlayer2.Y = (360);
            }

            //check player score, if player score is three stop timer
            if (P1score == 3)
            {
                gameTimer.Stop();

                winnerLabel.Visible = true;
                winnerLabel.Text = "player 1 wins";
            }
            else if (P2score == 3)
            {
                gameTimer.Stop();

                winnerLabel.Visible = true;
                winnerLabel.Text = "player 2 wins";
            }
            
            if (P1score == 3 && P2score == 3)
            {
                gameTimer.Stop();

                winnerLabel.Visible = true;
                winnerLabel.Text = "draw play again";
            }

            //check if either player has hit the bottom
            //if(spacePlayer1.Y > this.Height - spacePlayer1.Height)
            //{
            //    spacePlayer1.Y > this.Height - spacePlayer1.Height;
            //}

            Refresh();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //draw players
            e.Graphics.DrawRectangle(whitePen, spacePlayer1);
            e.Graphics.DrawRectangle(whitePen, spacePlayer2);

            //draw timer 
            e.Graphics.FillRectangle(whiteBrush, 287, 5, 7, 405);

            //update labels
            player1ScoreLabel.Text = $"{P1score}";
            player2ScoreLabel.Text = $"{P2score}";

            //draw astroid 
            for (int i = 0; i < asteroid.Count; i++)
            {
                e.Graphics.FillRectangle(whiteBrush, asteroid[i]);
            }
        }
    }
}
