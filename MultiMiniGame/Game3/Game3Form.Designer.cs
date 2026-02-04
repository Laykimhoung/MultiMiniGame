namespace MultiMiniGame.Game3
{
    partial class Game3Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game3Form));
            btnAtk = new Button();
            ptbBg = new PictureBox();
            btnExit = new Button();
            btnShield = new Button();
            btnHeal = new Button();
            ptbPlayer = new PictureBox();
            ptbBot = new PictureBox();
            lblPlayer = new Label();
            lblBot = new Label();
            ptbPAtk = new PictureBox();
            pictureBox1 = new PictureBox();
            ptbBotShield = new PictureBox();
            fireballTimer = new System.Windows.Forms.Timer(components);
            BossATKTimer = new System.Windows.Forms.Timer(components);
            btnPlayAgain = new Button();
            ptbpHeart1 = new PictureBox();
            ptbpHeart2 = new PictureBox();
            ptbpHeart3 = new PictureBox();
            ptbpHeart4 = new PictureBox();
            ptbpHeart5 = new PictureBox();
            ptbbHealth1 = new PictureBox();
            ptbbHealth2 = new PictureBox();
            ptbbHealth3 = new PictureBox();
            ptbbHealth4 = new PictureBox();
            ptbbHealth5 = new PictureBox();
            lblPHP = new Label();
            lblBHP = new Label();
            pnlMessage = new Panel();
            btnExit2 = new Button();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbBg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbBot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbPAtk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbBotShield).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbpHeart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbpHeart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbpHeart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbpHeart4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbpHeart5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbbHealth1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbbHealth2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbbHealth3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbbHealth4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbbHealth5).BeginInit();
            pnlMessage.SuspendLayout();
            SuspendLayout();
            // 
            // btnAtk
            // 
            btnAtk.BackColor = Color.Red;
            btnAtk.FlatStyle = FlatStyle.Flat;
            btnAtk.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtk.ForeColor = Color.Linen;
            btnAtk.Location = new Point(235, 508);
            btnAtk.Name = "btnAtk";
            btnAtk.Size = new Size(150, 55);
            btnAtk.TabIndex = 0;
            btnAtk.Text = "វៃ";
            btnAtk.UseVisualStyleBackColor = false;
            btnAtk.Click += btnAtk_Click;
            // 
            // ptbBg
            // 
            ptbBg.Dock = DockStyle.Fill;
            ptbBg.Image = Properties.Resources.G3_Background;
            ptbBg.Location = new Point(0, 0);
            ptbBg.Name = "ptbBg";
            ptbBg.Size = new Size(925, 499);
            ptbBg.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbBg.TabIndex = 1;
            ptbBg.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Yellow;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(37, 508);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 55);
            btnExit.TabIndex = 2;
            btnExit.Text = "រត់គេច";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnShield
            // 
            btnShield.BackColor = Color.Cyan;
            btnShield.FlatStyle = FlatStyle.Flat;
            btnShield.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShield.ForeColor = SystemColors.Highlight;
            btnShield.Location = new Point(488, 508);
            btnShield.Name = "btnShield";
            btnShield.Size = new Size(150, 55);
            btnShield.TabIndex = 3;
            btnShield.Text = "រនាំង";
            btnShield.UseVisualStyleBackColor = false;
            btnShield.Click += btnShield_Click;
            // 
            // btnHeal
            // 
            btnHeal.BackColor = Color.Lime;
            btnHeal.FlatStyle = FlatStyle.Flat;
            btnHeal.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHeal.ForeColor = Color.Navy;
            btnHeal.Location = new Point(721, 508);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(150, 55);
            btnHeal.TabIndex = 4;
            btnHeal.Text = "ផឹកថ្នាំ";
            btnHeal.UseVisualStyleBackColor = false;
            btnHeal.Click += btnHeal_Click;
            // 
            // ptbPlayer
            // 
            ptbPlayer.Image = Properties.Resources.G3_Player;
            ptbPlayer.Location = new Point(25, 284);
            ptbPlayer.Name = "ptbPlayer";
            ptbPlayer.Size = new Size(189, 194);
            ptbPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbPlayer.TabIndex = 5;
            ptbPlayer.TabStop = false;
            // 
            // ptbBot
            // 
            ptbBot.Image = Properties.Resources.G3_EyeofCthulhuPhase11;
            ptbBot.Location = new Point(680, 287);
            ptbBot.Name = "ptbBot";
            ptbBot.Size = new Size(162, 110);
            ptbBot.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbBot.TabIndex = 6;
            ptbBot.TabStop = false;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = Color.Transparent;
            lblPlayer.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer.ForeColor = SystemColors.HotTrack;
            lblPlayer.Location = new Point(91, 245);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(45, 36);
            lblPlayer.TabIndex = 7;
            lblPlayer.Text = "អ្នក";
            // 
            // lblBot
            // 
            lblBot.AutoSize = true;
            lblBot.BackColor = Color.Transparent;
            lblBot.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBot.ForeColor = Color.Red;
            lblBot.Location = new Point(721, 245);
            lblBot.Name = "lblBot";
            lblBot.Size = new Size(72, 36);
            lblBot.TabIndex = 8;
            lblBot.Text = "បិសាច";
            // 
            // ptbPAtk
            // 
            ptbPAtk.Image = Properties.Resources.G3_Fireball;
            ptbPAtk.Location = new Point(201, 287);
            ptbPAtk.Name = "ptbPAtk";
            ptbPAtk.Size = new Size(98, 105);
            ptbPAtk.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbPAtk.TabIndex = 9;
            ptbPAtk.TabStop = false;
            ptbPAtk.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.G3_Background;
            pictureBox1.Location = new Point(0, 499);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(925, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ptbBotShield
            // 
            ptbBotShield.Image = Properties.Resources.G3_BossShield;
            ptbBotShield.Location = new Point(637, 267);
            ptbBotShield.Name = "ptbBotShield";
            ptbBotShield.Size = new Size(39, 220);
            ptbBotShield.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbBotShield.TabIndex = 10;
            ptbBotShield.TabStop = false;
            ptbBotShield.Visible = false;
            // 
            // fireballTimer
            // 
            fireballTimer.Interval = 15;
            fireballTimer.Tick += fireballTimer_Tick;
            // 
            // BossATKTimer
            // 
            BossATKTimer.Interval = 15;
            BossATKTimer.Tick += BossATKTimer_Tick;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.BackColor = Color.Lime;
            btnPlayAgain.FlatStyle = FlatStyle.Flat;
            btnPlayAgain.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayAgain.ForeColor = SystemColors.ActiveCaptionText;
            btnPlayAgain.Location = new Point(158, 86);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(144, 55);
            btnPlayAgain.TabIndex = 11;
            btnPlayAgain.Text = "លេងម្តងទៀត";
            btnPlayAgain.UseVisualStyleBackColor = false;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // ptbpHeart1
            // 
            ptbpHeart1.Image = Properties.Resources.G3_Heart;
            ptbpHeart1.Location = new Point(25, 182);
            ptbpHeart1.Name = "ptbpHeart1";
            ptbpHeart1.Size = new Size(40, 40);
            ptbpHeart1.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbpHeart1.TabIndex = 12;
            ptbpHeart1.TabStop = false;
            // 
            // ptbpHeart2
            // 
            ptbpHeart2.Image = Properties.Resources.G3_Heart;
            ptbpHeart2.Location = new Point(71, 182);
            ptbpHeart2.Name = "ptbpHeart2";
            ptbpHeart2.Size = new Size(40, 40);
            ptbpHeart2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbpHeart2.TabIndex = 13;
            ptbpHeart2.TabStop = false;
            // 
            // ptbpHeart3
            // 
            ptbpHeart3.Image = Properties.Resources.G3_Heart;
            ptbpHeart3.Location = new Point(117, 182);
            ptbpHeart3.Name = "ptbpHeart3";
            ptbpHeart3.Size = new Size(40, 40);
            ptbpHeart3.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbpHeart3.TabIndex = 14;
            ptbpHeart3.TabStop = false;
            // 
            // ptbpHeart4
            // 
            ptbpHeart4.Image = Properties.Resources.G3_Heart;
            ptbpHeart4.Location = new Point(163, 182);
            ptbpHeart4.Name = "ptbpHeart4";
            ptbpHeart4.Size = new Size(40, 40);
            ptbpHeart4.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbpHeart4.TabIndex = 15;
            ptbpHeart4.TabStop = false;
            // 
            // ptbpHeart5
            // 
            ptbpHeart5.Image = Properties.Resources.G3_Heart;
            ptbpHeart5.Location = new Point(209, 182);
            ptbpHeart5.Name = "ptbpHeart5";
            ptbpHeart5.Size = new Size(40, 40);
            ptbpHeart5.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbpHeart5.TabIndex = 16;
            ptbpHeart5.TabStop = false;
            // 
            // ptbbHealth1
            // 
            ptbbHealth1.Image = Properties.Resources.G3_Heart;
            ptbbHealth1.Location = new Point(635, 182);
            ptbbHealth1.Name = "ptbbHealth1";
            ptbbHealth1.Size = new Size(40, 40);
            ptbbHealth1.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbbHealth1.TabIndex = 17;
            ptbbHealth1.TabStop = false;
            // 
            // ptbbHealth2
            // 
            ptbbHealth2.Image = Properties.Resources.G3_Heart;
            ptbbHealth2.Location = new Point(681, 182);
            ptbbHealth2.Name = "ptbbHealth2";
            ptbbHealth2.Size = new Size(40, 40);
            ptbbHealth2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbbHealth2.TabIndex = 18;
            ptbbHealth2.TabStop = false;
            // 
            // ptbbHealth3
            // 
            ptbbHealth3.Image = Properties.Resources.G3_Heart;
            ptbbHealth3.Location = new Point(727, 182);
            ptbbHealth3.Name = "ptbbHealth3";
            ptbbHealth3.Size = new Size(40, 40);
            ptbbHealth3.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbbHealth3.TabIndex = 19;
            ptbbHealth3.TabStop = false;
            // 
            // ptbbHealth4
            // 
            ptbbHealth4.Image = Properties.Resources.G3_Heart;
            ptbbHealth4.Location = new Point(773, 182);
            ptbbHealth4.Name = "ptbbHealth4";
            ptbbHealth4.Size = new Size(40, 40);
            ptbbHealth4.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbbHealth4.TabIndex = 20;
            ptbbHealth4.TabStop = false;
            // 
            // ptbbHealth5
            // 
            ptbbHealth5.Image = Properties.Resources.G3_Heart;
            ptbbHealth5.Location = new Point(819, 182);
            ptbbHealth5.Name = "ptbbHealth5";
            ptbbHealth5.Size = new Size(40, 40);
            ptbbHealth5.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbbHealth5.TabIndex = 21;
            ptbbHealth5.TabStop = false;
            // 
            // lblPHP
            // 
            lblPHP.AutoSize = true;
            lblPHP.BackColor = Color.Transparent;
            lblPHP.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPHP.ForeColor = Color.Red;
            lblPHP.Location = new Point(255, 182);
            lblPHP.Name = "lblPHP";
            lblPHP.Size = new Size(27, 36);
            lblPHP.TabIndex = 22;
            lblPHP.Text = "5";
            // 
            // lblBHP
            // 
            lblBHP.AutoSize = true;
            lblBHP.BackColor = Color.Transparent;
            lblBHP.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBHP.ForeColor = Color.Red;
            lblBHP.Location = new Point(592, 182);
            lblBHP.Name = "lblBHP";
            lblBHP.Size = new Size(37, 36);
            lblBHP.TabIndex = 23;
            lblBHP.Text = "15";
            // 
            // pnlMessage
            // 
            pnlMessage.BackColor = SystemColors.ActiveBorder;
            pnlMessage.Controls.Add(btnExit2);
            pnlMessage.Controls.Add(lblMessage);
            pnlMessage.Controls.Add(btnPlayAgain);
            pnlMessage.Location = new Point(300, 251);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Size = new Size(307, 146);
            pnlMessage.TabIndex = 24;
            pnlMessage.Visible = false;
            // 
            // btnExit2
            // 
            btnExit2.BackColor = Color.OrangeRed;
            btnExit2.FlatStyle = FlatStyle.Flat;
            btnExit2.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit2.ForeColor = SystemColors.ActiveCaptionText;
            btnExit2.Location = new Point(5, 86);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new Size(144, 55);
            btnExit2.TabIndex = 26;
            btnExit2.Text = "ចាកចេញ";
            btnExit2.UseVisualStyleBackColor = false;
            btnExit2.Click += btnExit2_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(28, 33);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(43, 36);
            lblMessage.TabIndex = 25;
            lblMessage.Text = "អ្នក";
            // 
            // Game3Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 579);
            Controls.Add(ptbBot);
            Controls.Add(pnlMessage);
            Controls.Add(lblBHP);
            Controls.Add(lblPHP);
            Controls.Add(ptbbHealth5);
            Controls.Add(ptbbHealth4);
            Controls.Add(ptbbHealth3);
            Controls.Add(ptbbHealth2);
            Controls.Add(ptbbHealth1);
            Controls.Add(ptbpHeart5);
            Controls.Add(ptbpHeart4);
            Controls.Add(ptbpHeart3);
            Controls.Add(ptbpHeart2);
            Controls.Add(ptbpHeart1);
            Controls.Add(ptbBotShield);
            Controls.Add(ptbPAtk);
            Controls.Add(lblBot);
            Controls.Add(lblPlayer);
            Controls.Add(ptbPlayer);
            Controls.Add(btnHeal);
            Controls.Add(btnShield);
            Controls.Add(btnExit);
            Controls.Add(btnAtk);
            Controls.Add(ptbBg);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game3Form";
            Text = "មេវៃ";
            Load += Game3Form_Load;
            ((System.ComponentModel.ISupportInitialize)ptbBg).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbBot).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbPAtk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbBotShield).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbpHeart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbpHeart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbpHeart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbpHeart4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbpHeart5).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbbHealth1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbbHealth2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbbHealth3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbbHealth4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbbHealth5).EndInit();
            pnlMessage.ResumeLayout(false);
            pnlMessage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAtk;
        private PictureBox ptbBg;
        private Button btnExit;
        private Button btnShield;
        private Button btnHeal;
        private PictureBox ptbPlayer;
        private PictureBox ptbBot;
        private Label lblPlayer;
        private Label lblBot;
        private PictureBox ptbPAtk;
        private PictureBox pictureBox1;
        private PictureBox ptbBotShield;
        private System.Windows.Forms.Timer fireballTimer;
        private System.Windows.Forms.Timer BossATKTimer;
        private Button btnPlayAgain;
        private PictureBox ptbpHeart1;
        private PictureBox ptbpHeart2;
        private PictureBox ptbpHeart3;
        private PictureBox ptbpHeart4;
        private PictureBox ptbpHeart5;
        private PictureBox ptbbHealth1;
        private PictureBox ptbbHealth2;
        private PictureBox ptbbHealth3;
        private PictureBox ptbbHealth4;
        private PictureBox ptbbHealth5;
        private Label lblPHP;
        private Label lblBHP;
        private Panel pnlMessage;
        private Button btnExit2;
        private Label lblMessage;
    }
}