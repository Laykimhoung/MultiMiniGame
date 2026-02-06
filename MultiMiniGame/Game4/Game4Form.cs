using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace MultiMiniGame.Game4
{
    public partial class Game4Form : Form
    {
        bool goLeft, goRight, isGameOver, isPaused;
        int score, ballx, bally, playerSpeed, blocksRemaining;
        Random rnd = new Random();
        PictureBox[] blockArray;
        public Game4Form()
        {
            InitializeComponent();
            this.KeyPreview = true;
            isGameOver = true;
            PlaceBlocks(false);
            isPaused = true;
            isGameOver = false;
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 15;
            ball.Left = 468;
            ball.Top = 425;
            player.Left = 427;
            lblScore.Text = "Score: " + score + "  --  PRESS ENTER TO START |  PRESS ESC TO BACK TO MENU GAME ";
            ball.Parent = bg;
            ball.BackColor = Color.Transparent;
        }

        private void setupGame()
        {
            isGameOver = false;
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 15;
            lblScore.Text = "Score: " + score;
            ball.Left = 468;
            ball.Top = 425;
            player.Left = 427;
            gameTimer.Start();
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();
            lblScore.Text = "Score: " + score + " " + message;
            SoundPlayer G4_Game_Over_Sound = new SoundPlayer(@"Sounds\G4_Lose.wav");
            G4_Game_Over_Sound.Play();
        }

        private void PlaceBlocks(bool resetGame = true)
        {
            if (blockArray != null)
            {
                foreach (PictureBox pb in blockArray)
                {
                    if (pb != null && bg.Controls.Contains(pb))
                        this.Controls.Remove(pb);
                }
            }

            blockArray = new PictureBox[28];
            int a = 0, top = 50, left = 50;
            for (int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i] = new PictureBox();
                blockArray[i].Height = 20;
                blockArray[i].Width = 100;
                blockArray[i].Tag = "blocks";
                blockArray[i].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));              
                if (a == 7)
                {
                    top = top + 40;
                    left = 50;
                    a = 0;
                }

                if (a < 7)
                {
                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;
                    bg.Controls.Add(blockArray[i]);
                    blockArray[i].BringToFront();
                    left = left + 125;
                }
            }

            blocksRemaining = blockArray.Length;

            if (resetGame)
            {
                setupGame();
            }
            else
            {
                lblScore.Text = "Score: " + score;
            }
        }

        private void removeBlocks()
        {
            if (blockArray == null) return;
            foreach (PictureBox x in blockArray)
            {
                if (x != null && this.Controls.Contains(x))
                    this.Controls.Remove(x);
            }
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true && player.Right < 950)
            {
                player.Left += playerSpeed;
            }

            ball.Left += ballx;
            ball.Top += bally;
            SoundPlayer G4_Ball = new SoundPlayer(@"Sounds\G4_Bouncing_Platform.wav");

            if (ball.Left < 0 || ball.Right > 950)
            {
                ballx = -ballx;
                G4_Ball.Play();
            }
            if (ball.Top < 0)
            {
                bally = -bally;
                G4_Ball.Play();
            }

            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                ball.Top = 427;
                bally = rnd.Next(5, 10) * -1;
                SoundPlayer G4_Bouncing_Metal = new SoundPlayer(@"Sounds\G4_Bouncing_Metal.wav");
                G4_Bouncing_Metal.Play();
                if (ballx < 0)
                {
                    ballx = rnd.Next(5, 10) * -1;
                }
                else
                {
                    ballx = rnd.Next(5, 10);
                }
            }

            foreach (Control x in bg.Controls.OfType<PictureBox>().Where(pb => (string)pb.Tag == "blocks").ToArray())
            {
                if (ball.Bounds.IntersectsWith(x.Bounds))
                {
                    score += 1;
                    blocksRemaining -= 1;
                    bally = -bally;
                    bg.Controls.Remove(x);
                    SoundPlayer G4_Breaking_Glass = new SoundPlayer(@"Sounds\G4_Hit_Score.wav");
                    G4_Breaking_Glass.Play();
                }
            }

            if (blocksRemaining <= 0)
            {
                PlaceBlocks(false);
            }

            if (ball.Top > 450)
            {
                gameOver("GAME OVER!!! PRESS ENTER TO TRY AGAIN! | PRESS ESC TO BACK TO MENU GAME");
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Close();
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (isGameOver == true)
                {
                    removeBlocks();
                    PlaceBlocks();
                    isPaused = false;
                }
                else if (isPaused)
                {
                    setupGame();
                    isPaused = false;
                }
            }
        }
    }
}
