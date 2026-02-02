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
        int playerHP = 5, botHP = 20, botPowerUp = 1, movePhase = 1;
        Random rnd = new Random();

        public Game3Form()
        {
            InitializeComponent();
        }

        private void Game3Form_Load(object sender, EventArgs e)
        {

        }

        private async void btnAtk_Click(object sender, EventArgs e)
        {
            int botPick = rnd.Next(1, 5);

            if (botPick == 1 || botPick == 2)
            {
                playerATK();
                while (fireballTimer.Enabled)
                {
                    await Task.Delay(100);
                }
                botHP--;
                bHealth();

                if (botHP <= 10)
                {
                    if (botPowerUp == 1)
                    {
                        //Bot power up animation

                        botPowerUp--;
                    }
                    botATK();
                    while (BossATKTimer.Enabled)
                    {
                        await Task.Delay(100);
                    }
                    playerHP = playerHP - 2;
                    pHealth();
                    return;
                }
                botATK();
                while (BossATKTimer.Enabled)
                {
                    await Task.Delay(100);
                }
                playerHP--;
                pHealth();
            }
            else if (botPick == 3)
            {
                //Defend bot


                playerATK();
                while (BossATKTimer.Enabled)
                {
                    await Task.Delay(100);
                }

            }
            else
            {
                playerATK();
                while (fireballTimer.Enabled)
                {
                    await Task.Delay(100);
                }
                botHP--;
                bHealth();
            }
        }

        private async void btnShield_Click(object sender, EventArgs e)
        {
            int botPick = rnd.Next(1, 5);

            if (botPick == 1 || botPick == 2)
            {
                //Defend player


                botATK();
                while (BossATKTimer.Enabled)
                {
                    await Task.Delay(100);
                }

            }
            else if (botPick == 3)
            {
                //Defend 2
            }
            else
            {
                botHP++;
                bHealth();
            }
        }

        private async void btnHeal_Click(object sender, EventArgs e)
        {
            int botPick = rnd.Next(2, 5);

            if (botPick == 2)
            {
                if (botHP <= 10)
                {
                    botATK();
                    while (BossATKTimer.Enabled)
                    {
                        await Task.Delay(100);
                    }
                    playerHP = playerHP - 2;
                    pHealth();
                    return;
                }
                botATK();
                while (BossATKTimer.Enabled)
                {
                    await Task.Delay(100);
                }
                playerHP--;
                pHealth();
            }
            else if (botPick == 3)
            {
                playerHP++;
                pHealth();

                //Defend bot

            }
            else
            {
                playerHP++;
                pHealth();
                botHP++;
                bHealth();
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
            int targetX = 620;

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

        private void pHealth()
        {
            if (playerHP == 5)
            {
                ptbpHeart1.Visible = true;
                ptbpHeart2.Visible = true;
                ptbpHeart3.Visible = true;
                ptbpHeart4.Visible = true;
                ptbpHeart5.Visible = true;
                lblPHP.Text = playerHP.ToString();
            }
            else if (playerHP == 4)
            {
                ptbpHeart1.Visible = true;
                ptbpHeart2.Visible = true;
                ptbpHeart3.Visible = true;
                ptbpHeart4.Visible = true;
                ptbpHeart5.Visible = false;
                lblPHP.Text = playerHP.ToString();
            }
            else if (playerHP == 3)
            {
                ptbpHeart1.Visible= true;
                ptbpHeart2.Visible = true;
                ptbpHeart3.Visible = true;
                ptbpHeart4.Visible = false;
                ptbpHeart5.Visible = false;
                lblPHP.Text = playerHP.ToString();
            }
            else if (playerHP == 2)
            {
                ptbpHeart1.Visible = true;
                ptbpHeart2.Visible = true;
                ptbpHeart3.Visible = false;
                ptbpHeart4.Visible = false;
                ptbpHeart5.Visible = false;
                lblPHP.Text = playerHP.ToString();
            }
            else if (playerHP == 1)
            {
                ptbpHeart1.Visible = false;
                ptbpHeart2.Visible = false;
                ptbpHeart3.Visible = false;
                ptbpHeart4.Visible = false;
                ptbpHeart5.Visible = false;
                lblPHP.Text = playerHP.ToString();
            }
        }
        private void bHealth()
        {
            if (botHP == 20)
            {
                ptbbHealth1.Visible = true;
                ptbbHealth2.Visible = true;
                ptbbHealth3.Visible = true;
                ptbbHealth4.Visible = true;
                ptbbHealth5.Visible = true;
                lblBHP.Text = botHP.ToString();
            }
            else if (botHP >= 16)
            {
                ptbbHealth1.Visible = true;
                ptbbHealth2.Visible = true;
                ptbbHealth3.Visible = true;
                ptbbHealth4.Visible = true;
                ptbbHealth5.Visible = false;
                lblBHP.Text = botHP.ToString();
            }
            else if (botHP >= 12)
            {
                ptbbHealth1.Visible = true;
                ptbbHealth2.Visible = true;
                ptbbHealth3.Visible = true;
                ptbbHealth4.Visible = false;
                ptbbHealth5.Visible = false;
                lblBHP.Text = botHP.ToString();
            }
            else if (botHP >= 8)
            {
                ptbbHealth1.Visible = true;
                ptbbHealth2.Visible = true;
                ptbbHealth3.Visible = false;
                ptbbHealth4.Visible = false;
                ptbbHealth5.Visible = false;
                lblBHP.Text = botHP.ToString();
            }
            else if (botHP >= 1)
            {
                ptbbHealth1.Visible = true;
                ptbbHealth2.Visible = false;
                ptbbHealth3.Visible = false;
                ptbbHealth4.Visible = false;
                ptbbHealth5.Visible = false;
                lblBHP.Text = botHP.ToString();
            }
            else
            {
                ptbbHealth1.Visible = false;
                ptbbHealth2.Visible = false;
                ptbbHealth3.Visible = false;
                ptbbHealth4.Visible = false;
                ptbbHealth5.Visible = false;
                lblBHP.Text = botHP.ToString();
            }
        }


    }
}
