using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiMiniGame.Game3
{
    public partial class Game3Form : Form
    {
        int playerHP = 5, botHP = 5, botPowerUp = 1, movePhase = 1;
        Random rnd = new Random();

        public Game3Form()
        {
            InitializeComponent();
        }

        private void Game3Form_Load(object sender, EventArgs e)
        {

        }

        private void btnAtk_Click(object sender, EventArgs e)
        {
            int botPick = rnd.Next(1, 5);

            if (botPick == 1 || botPick == 2)
            {
                playerATK();
                botHP--;
                //Minus HP animation


                if (botHP == 0)
                {
                    MessageBox.Show("You Win!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (botHP <= 2)
                {
                    if (botPowerUp == 1)
                    {
                        //Bot power up animation

                        botPowerUp--;
                    }
                    botATK();
                    playerHP = playerHP - 2;

                    //Check HP and minus HP animation
                    if (playerHP <= 0)
                    {
                        MessageBox.Show("You Lose!", "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }
                botATK();
                playerHP--;
                //Minus HP animation

                //Check player HP
                if (playerHP <= 0)
                {
                    MessageBox.Show("You Lose!", "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (botPick == 3)
            {
                //Defend bot


                playerATK();
            }
            else
            {
                playerATK();
                botHP--;
                //Minus HP animation

                //Check bot HP
                if (botHP <= 0)
                {
                    MessageBox.Show("You Win!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnShield_Click(object sender, EventArgs e)
        {
            int botPick = rnd.Next(1, 5);

            if (botPick == 1 || botPick == 2)
            {
                //Defend player


                botATK();
            }
            else if (botPick == 3)
            {
                //Defend 2
            }
            else
            {
                botHP++;
                //Bot heal animation

            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            int botPick = rnd.Next(2, 5);

            if (botPick == 2)
            {
                if (botHP <= 2)
                {
                    botATK();
                    playerHP = playerHP - 2;

                    //Check HP and minus HP animation
                    if (playerHP <= 0)
                    {
                        MessageBox.Show("You Lose!", "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }
                botATK();
                playerHP--;

                //Check player HP
                if (playerHP <= 0)
                {
                    MessageBox.Show("You Lose!", "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (botPick == 3)
            {
                //Heal player
                playerHP++;

                //Defend bot

            }
            else
            {
                playerHP++;
                botHP++;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("គួរតែរត់គេច ឬអត់?", "រត់គេច", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void playerATK()
        {
            //Reset position
            ptbPAtk.Location = new Point(220, 284);
            ptbPAtk.Visible = true;
            fireballTimer.Start();
        }

        private void botATK()
        {
            movePhase = 1;
            ptbBot.Location = new Point(680, 251);
            BossATKTimer.Start();
        }

        private void fireballTimer_Tick(object sender, EventArgs e)
        {
            int speed = 10; // Pixels move per tick
            int targetX = 634;

            if (ptbPAtk.Left < targetX)
            {
                ptbPAtk.Left += speed;
            }
            else
            {
                fireballTimer.Stop();
                ptbPAtk.Left = targetX;

                ptbPAtk.Visible = false;
            }
        }
        private void BossATKTimer_Tick(object sender, EventArgs e)
        {
            if (movePhase == 1)
            {
                //(680, 251) -> (-146, 312)
                if (ptbBot.Left > -146)
                {
                    ptbBot.Left -= 15; // Speed
                    ptbBot.Top += 1;   // Adjustment
                }
                else
                {
                    ptbBot.Location = new Point(915, 172);
                    movePhase = 2;
                }
            }
            else if (movePhase == 2)
            {
                //(915, 172) -> (680, 251)
                if (ptbBot.Left > 680)
                {
                    ptbBot.Left -= 15;
                    ptbBot.Top += 5;
                }
                else
                {
                    BossATKTimer.Stop();
                    ptbBot.Location = new Point(680, 251);
                }
            }

        }
    }
}
