using Space_Race.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Space_Race
{
    public partial class Form1 : Form
    {
        //Components' speeds
        int playerSpeed = 6;
        int bulletSpeed = 6;

        //Player scores
        int player1Score = 0;
        int player2Score = 0;

        //List of bullets
        List<Rectangle> bulletList = new List<Rectangle>();
        List<Rectangle> bulletList2 = new List<Rectangle>();
        int bulletXSize = 15;

        //Declare moving options
        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;

        //Declare random generator, sound-player and brush
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Random randGen = new Random();
        int randValue = 0;
        SoundPlayer player = new SoundPlayer();
        int page = 1;

        public Form1()
        {
            InitializeComponent();
            //Set gamescreen resolution
            this.Size = new Size(900, 600);
            //Play theme song
            player = new SoundPlayer(Properties.Resources.theme_song);
            player.Play();
        }


        //Start button
        private void startButton_Click(object sender, EventArgs e)
        {
            gameTitle.Visible = false;
            player1ScoreLabel.Visible = true;
            player2ScoreLabel.Visible = true;
            player1.Location = new Point(this.Width / 4 - player1.Width, 500);
            player2.Location = new Point(this.Width / 4 * 3 - player2.Width, 500);
            player1.Visible = true;
            player2.Visible = true;
            startButton.Visible = false;
            quitButton.Visible = false;
            bulletList.Clear();
            bulletList2.Clear();
            player.Stop();
            timer1.Start();
            this.Focus();
        }


        //Quit button
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Draw bullets
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < bulletList.Count; i++)
            {
                e.Graphics.FillRectangle(whiteBrush, bulletList[i]);
            }

            for (int i = 0; i < bulletList2.Count; i++)
            {
                e.Graphics.FillRectangle(whiteBrush, bulletList2[i]);
            }
        }


        ///Game logic
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Move player 1
            if (wDown == true)
            {
                player1.Top -= playerSpeed;
                player1.Image = Resources.rocket;
            }
            
            if (sDown == true && player1.Top <= 490)
            {
                player1.Top += playerSpeed;
                player1.Image = Resources.rocket;
                player1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }

            if (wDown == false && sDown == false)
            {
                player1.Image = Resources.spaceships;
            }
            //Move player 2
            if (upArrowDown == true)
            {
                player2.Top -= playerSpeed;
                player2.Image = Resources.rocket;
            }

            if (downArrowDown == true && player2.Top <= 490)
            {
                player2.Top += playerSpeed;
                player2.Image = Resources.rocket;
                player2.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }

            if (upArrowDown == false && downArrowDown == false)
            {
                player2.Image = Resources.spaceships;
            }

            //Randomly set y location for bullets from both sides
            randValue = randGen.Next(1, 100);

            if (randValue < 16)
            {
                int y = randGen.Next(100, this.Height - 50);
                Rectangle bullet = new Rectangle(0, y - 75, 15, 3);
                bulletList.Add(bullet);
               
            }

            if (randValue < 16)
            {
                int y = randGen.Next(100, this.Height - 50);
                Rectangle bullet2 = new Rectangle(this.Width, y - 75, 15, 3);
                bulletList2.Add(bullet2);

            }

            //Spawn bullets from the sides of the screen

            //From right to left
            for (int i = 0; i < bulletList.Count; i++)
            {
                int x = bulletList[i].X + bulletSpeed;
                bulletList[i] = new Rectangle(x, bulletList[i].Y, bulletList[i].Width, bulletList[i].Height);
            }
            //Remove bullets that go past the screen 
            for (int i = 0; i < bulletList.Count; i++)
            {
                if (bulletList[i].X > this.Width - bulletXSize)
                {
                    bulletList.RemoveAt(i);
                }
            }

            //Vice versa
            for (int i = 0; i < bulletList2.Count; i++)
            {
                int x = bulletList2[i].X - bulletSpeed;
                bulletList2[i] = new Rectangle(x, bulletList2[i].Y, bulletList2[i].Width, bulletList2[i].Height);
            }
            //Remove bullets that go past the screen 
            for (int i = 0; i < bulletList2.Count; i++)
            {
                if (bulletList2[i].X < 0 + bulletXSize)
                {
                    bulletList2.RemoveAt(i);
                }
            }

            //Check for collision between players and bullets
            Rectangle player1Bounds = new Rectangle(player1.Bounds.X, player1.Bounds.Y, player1.Width, player1.Height);
            Rectangle player2Bounds = new Rectangle(player2.Bounds.X, player2.Bounds.Y, player2.Width, player2.Height);
            
            //Reset players' positions after hitting one of the bullets
            for (int i = 0; i < bulletList.Count; i++)
            {
                if (player1Bounds.IntersectsWith(bulletList[i]))
                {
                    player = new SoundPlayer(Properties.Resources.bullet_collision);
                    player.Play();
                    bulletList.RemoveAt(i);
                    player1.Location = new Point(this.Width / 4 - player1.Width, 500);
                }
            }

            for (int i = 0; i < bulletList2.Count; i++)
            {
                if (player1Bounds.IntersectsWith(bulletList2[i]))
                {
                    
                    player = new SoundPlayer(Properties.Resources.bullet_collision);
                    player.Play();
                    bulletList2.RemoveAt(i);
                    player1.Location = new Point(this.Width / 4 - player1.Width, 500);
                }
            }

            for (int i = 0; i < bulletList.Count; i++)
            {
                if (player2Bounds.IntersectsWith(bulletList[i]))
                {
                    player = new SoundPlayer(Properties.Resources.bullet_collision);
                    player.Play();
                    bulletList.RemoveAt(i);
                    player2.Location = new Point(this.Width / 4 * 3 - player2.Width, 500);
                }
            }

            for (int i = 0; i < bulletList2.Count; i++)
            {
                if (player2Bounds.IntersectsWith(bulletList2[i]))
                {
                    player = new SoundPlayer(Properties.Resources.bullet_collision);
                    player.Play();
                    bulletList2.RemoveAt(i);
                    player2.Location = new Point(this.Width / 4 * 3 - player2.Width, 500);
                }
            }

            //Give players score if they reach the top and reset their postions
            if (player1.Top < 0 - player1.Width)
            {
                player = new SoundPlayer(Properties.Resources.scoring);
                player.Play();
                player1.Location = new Point(this.Width / 4 - player1.Width, 500);
                player1Score++;
                player1ScoreLabel.Text = $"{player1Score}";
            }
            if (player2.Top < 0 - player2.Width)
            {
                player = new SoundPlayer(Properties.Resources.scoring);
                player.Play();
                player2.Location = new Point(this.Width / 4 * 3 - player2.Width, 500);
                player2Score++;
                player2ScoreLabel.Text = $"{player2Score}";
            }

            //Check score and stop game if the time is over
            //for(int timeLeft = 60; timeLeft >= 0;  timeLeft -= 1)
            //{
            //    timeLeftLabel.Text += $"{timeLeft}";
            //}
            if (player1Score == 5 || player2Score == 5)
            {
                player = new SoundPlayer(Properties.Resources.winner);
                player.Play();
                bulletList.Clear();
                bulletList2.Clear();
                player1.Visible = false;
                player2.Visible = false;
                gameTimer.Enabled = false;
                winTitle.Visible = true;
                player1ScoreLabel.Visible = false;
                player2ScoreLabel.Visible = false;
                if (player1Score == 5)
                {
                    winTitle.Text = "Player  1 Wins!!";
                }
                else winTitle.Text = "Player  2 Wins!!";
                winTitle.Location = new Point(this.Width / 2 - winTitle.Width / 2, this.Height / 2 - winTitle.Height / 2);
            }
            //else
            //{
            //    gameTimer.Enabled = false;
            //    winLabel.Visible = true;
            //    player1ScoreLabel.Visible = false;
            //    player2ScoreLabel.Visible = false;
            //    winLabel.Text = "Tie!!";
            //}
            Refresh();
        }

        
        //Buttons pressed check
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }


        //Buttons released check
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }
    }
}
