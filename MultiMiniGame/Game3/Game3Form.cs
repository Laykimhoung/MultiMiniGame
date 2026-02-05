using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace MultiMiniGame.Game3
{
    public partial class Game3Form : Form
    {
        int playerHP = 5, botHP = 15, movePhase = 1;
        Random rnd = new Random();

        public Game3Form()
        {
            InitializeComponent();
        }

        private void Game3Form_Load(object sender, EventArgs e)
        {
            ptbpHeart1.Parent = ptbBg;
            ptbpHeart1.BackColor = Color.Transparent;

            ptbpHeart2.Parent = ptbBg;
            ptbpHeart2.BackColor = Color.Transparent;

            ptbpHeart3.Parent = ptbBg;
            ptbpHeart3.BackColor = Color.Transparent;

            ptbpHeart4.Parent = ptbBg;
            ptbpHeart4.BackColor = Color.Transparent;

            ptbpHeart5.Parent = ptbBg;
            ptbpHeart5.BackColor = Color.Transparent;

            ptbbHealth1.Parent = ptbBg;
            ptbbHealth1.BackColor = Color.Transparent;

            ptbbHealth2.Parent = ptbBg;
            ptbbHealth2.BackColor = Color.Transparent;

            ptbbHealth3.Parent = ptbBg;
            ptbbHealth3.BackColor = Color.Transparent;

            ptbbHealth4.Parent = ptbBg;
            ptbbHealth4.BackColor = Color.Transparent;

            ptbbHealth5.Parent = ptbBg;
            ptbbHealth5.BackColor = Color.Transparent;

            ptbPlayer.Parent = ptbBg;
            ptbPlayer.BackColor = Color.Transparent;

            ptbBot.Parent = ptbBg;
            ptbBot.BackColor = Color.Transparent;

            ptbPAtk.Parent = ptbBg;
            ptbPAtk.BackColor = Color.Transparent;

            ptbBotShield.Parent = ptbBg;
            ptbBotShield.BackColor = Color.Transparent;

            lblPHP.Parent = ptbBg;
            lblPHP.BackColor = Color.Transparent;

            lblBHP.Parent = ptbBg;
            lblBHP.BackColor = Color.Transparent;

            lblPlayer.Parent = ptbBg;
            lblPlayer.BackColor = Color.Transparent;

            lblBot.Parent = ptbBg;
            lblBot.BackColor = Color.Transparent;

            SoundPlayer sG3 = new SoundPlayer(@"Sounds\G3_VaiBoss.wav");
            sG3.PlayLooping();
        }

        private async void btnAtk_Click(object sender, EventArgs e)
        {
            Enablebtns(false);
            int botPick = rnd.Next(1, 4);
            if (botPick == 1)
            {
                playerATK();
                while (fireballTimer.Enabled)
                {
                    await Task.Delay(100);
                }
                botHP--;
                bHealth();
                if (botHP == 0) return;
                if (botHP == 7)
                {
                    ptbBot.Image = Properties.Resources.G3_EyeofCthulhuPhase2;
                }
                if (botHP <= 7)
                {
                    botATK();
                    while (BossATKTimer.Enabled)
                    {
                        await Task.Delay(100);
                    }
                    playerHP = playerHP - 2;
                    pHealth();
                    Enablebtns(true);
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
            else if (botPick == 2)
            {
                ptbBotShield.Visible = true;
                playerATK();
                while (fireballTimer.Enabled)
                {
                    await Task.Delay(100);
                }
                ptbBotShield.Visible = false;
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
                if (botHP == 7)
                {
                    ptbBot.Image = Properties.Resources.G3_EyeofCthulhuPhase2;
                }
            }
            Enablebtns(true);
        }

        private async void btnShield_Click(object sender, EventArgs e)
        {
            Enablebtns(false);
            int botPick = rnd.Next(1, 5);
            if (botPick == 1 || botPick == 2)
            {
                ptbPlayer.Image = Properties.Resources.G3_PlayerShield;
                botATK();
                while (BossATKTimer.Enabled)
                {
                    await Task.Delay(100);
                }
                ptbPlayer.Image = Properties.Resources.G3_Player;
            }
            else if (botPick == 3)
            {
                //Defend 2
                ptbPlayer.Image = Properties.Resources.G3_PlayerShield;
                ptbBotShield.Visible = true;
                await Task.Delay(1500);
                ptbPlayer.Image = Properties.Resources.G3_Player;
                ptbBotShield.Visible = false;
            }
            else
            {
                ptbPlayer.Image = Properties.Resources.G3_PlayerShield;
                if (botHP < 15)
                    botHP++;
                bHealth();
                await Task.Delay(1500);
                ptbPlayer.Image = Properties.Resources.G3_Player;
            }
            Enablebtns(true);
        }

        private async void btnHeal_Click(object sender, EventArgs e)
        {
            if (playerHP == 5)
            {
                MessageBox.Show("អ្នកមានជីវិតពេញហើយ!", "ព័ត៌មាន", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Enablebtns(false);
            int botPick = rnd.Next(2, 5);

            if (botPick == 2)
            {
                if (botHP <= 7)
                {
                    botATK();
                    while (BossATKTimer.Enabled)
                    {
                        await Task.Delay(100);
                    }
                    playerHP = playerHP - 2;
                    pHealth();
                    Enablebtns(true);
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
                ptbBotShield.Visible = true;
                await Task.Delay(1500);
                ptbBotShield.Visible = false;
            }
            else
            {
                playerHP++;
                pHealth();
                if (botHP < 15)
                    botHP++;
                bHealth();
            }
            Enablebtns(true);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("គួរតែរត់គេច ឬអត់?", "រត់គេច", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
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
            ptbBot.Location = new Point(680, 287);
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
                //(680, 287) -> (-146, 312)
                if (ptbBot.Left > -146)
                {
                    ptbBot.Left -= 15; // Speed
                    ptbBot.Top += 1;
                }
                else
                {
                    ptbBot.Location = new Point(915, 200);
                    movePhase = 2;
                }
            }
            else if (movePhase == 2)
            {
                //(915, 172) -> (680, 287)
                if (ptbBot.Left > 680)
                {
                    ptbBot.Left -= 14;
                    ptbBot.Top += 5;
                }
                else
                {
                    BossATKTimer.Stop();
                    ptbBot.Location = new Point(680, 287);
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
                ptbpHeart1.Visible = true;
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
                ptbpHeart1.Visible = true;
                ptbpHeart2.Visible = false;
                ptbpHeart3.Visible = false;
                ptbpHeart4.Visible = false;
                ptbpHeart5.Visible = false;
                lblPHP.Text = playerHP.ToString();
            }
            else
            {
                ptbpHeart1.Visible = false;
                ptbpHeart2.Visible = false;
                ptbpHeart3.Visible = false;
                ptbpHeart4.Visible = false;
                ptbpHeart5.Visible = false;
                if (playerHP >= 0)
                {
                    lblPHP.Text = "0";
                    lblPHP.Text = playerHP.ToString();
                }
                GameOver(true);
            }
        }
        private void bHealth()
        {
            if (botHP == 15)
            {
                ptbbHealth1.Visible = true;
                ptbbHealth2.Visible = true;
                ptbbHealth3.Visible = true;
                ptbbHealth4.Visible = true;
                ptbbHealth5.Visible = true;
                lblBHP.Text = botHP.ToString();
            }
            else if (botHP >= 12)
            {
                ptbbHealth1.Visible = true;
                ptbbHealth2.Visible = true;
                ptbbHealth3.Visible = true;
                ptbbHealth4.Visible = true;
                ptbbHealth5.Visible = false;
                lblBHP.Text = botHP.ToString();
            }
            else if (botHP >= 9)
            {
                ptbbHealth1.Visible = true;
                ptbbHealth2.Visible = true;
                ptbbHealth3.Visible = true;
                ptbbHealth4.Visible = false;
                ptbbHealth5.Visible = false;
                lblBHP.Text = botHP.ToString();
            }
            else if (botHP >= 6)
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
                GameOver(false);
            }
        }

        private void Enablebtns(bool enable)
        {
            btnAtk.Enabled = enable;
            btnHeal.Enabled = enable;
            btnShield.Enabled = enable;
        }
        private void GameOver(bool i)
        {
            if (i)
            {
                ptbPlayer.Image = Properties.Resources.G3_PlayerDie;
                lblMessage.Text = "អ្នកបានបរាជ័យ!";
            }
            else
            {
                ptbBot.Visible = false;
                lblMessage.Text = "អ្នកបានជ័យជម្នះ!";
            }
            Enablebtns(false);
            pnlMessage.Visible = true;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            playerHP = 5;
            botHP = 15;
            pHealth();
            bHealth();
            Enablebtns(true);
            ptbBot.Visible = true;
            pnlMessage.Visible = false;
            ptbPlayer.Image = Properties.Resources.G3_Player;
            ptbBot.Image = Properties.Resources.G3_EyeofCthulhuPhase1;
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void ptbpHeart1_Click(object sender, EventArgs e)
        {
            int Cheat = rnd.Next(0, 5);
            if (Cheat == 4)
            {
                if (playerHP < 5)
                {
                    playerHP++;
                    pHealth();
                }
            }
        }
    }
}
