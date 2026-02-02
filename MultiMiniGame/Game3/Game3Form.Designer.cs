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
            ptbPlayer.Location = new Point(64, 251);
            ptbPlayer.Name = "ptbPlayer";
            ptbPlayer.Size = new Size(150, 220);
            ptbPlayer.TabIndex = 5;
            ptbPlayer.TabStop = false;
            // 
            // ptbBot
            // 
            ptbBot.Location = new Point(680, 251);
            ptbBot.Name = "ptbBot";
            ptbBot.Size = new Size(162, 110);
            ptbBot.TabIndex = 6;
            ptbBot.TabStop = false;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = Color.Transparent;
            lblPlayer.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayer.Location = new Point(116, 208);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(43, 36);
            lblPlayer.TabIndex = 7;
            lblPlayer.Text = "អ្នក";
            // 
            // lblBot
            // 
            lblBot.AutoSize = true;
            lblBot.BackColor = Color.Transparent;
            lblBot.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBot.Location = new Point(731, 208);
            lblBot.Name = "lblBot";
            lblBot.Size = new Size(69, 36);
            lblBot.TabIndex = 8;
            lblBot.Text = "បិសាច";
            // 
            // ptbPAtk
            // 
            ptbPAtk.Location = new Point(220, 284);
            ptbPAtk.Name = "ptbPAtk";
            ptbPAtk.Size = new Size(50, 50);
            ptbPAtk.TabIndex = 9;
            ptbPAtk.TabStop = false;
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
            ptbBotShield.Location = new Point(648, 196);
            ptbBotShield.Name = "ptbBotShield";
            ptbBotShield.Size = new Size(26, 275);
            ptbBotShield.TabIndex = 10;
            ptbBotShield.TabStop = false;
            // 
            // fireballTimer
            // 
            fireballTimer.Interval = 20;
            fireballTimer.Tick += fireballTimer_Tick;
            // 
            // BossATKTimer
            // 
            BossATKTimer.Interval = 20;
            BossATKTimer.Tick += BossATKTimer_Tick;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.BackColor = Color.Red;
            btnPlayAgain.FlatStyle = FlatStyle.Flat;
            btnPlayAgain.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlayAgain.ForeColor = SystemColors.ActiveCaptionText;
            btnPlayAgain.Location = new Point(393, 251);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(144, 55);
            btnPlayAgain.TabIndex = 11;
            btnPlayAgain.Text = "លេងម្តងទឿត";
            btnPlayAgain.UseVisualStyleBackColor = false;
            // 
            // ptbpHeart1
            // 
            ptbpHeart1.Location = new Point(24, 123);
            ptbpHeart1.Name = "ptbpHeart1";
            ptbpHeart1.Size = new Size(40, 40);
            ptbpHeart1.TabIndex = 12;
            ptbpHeart1.TabStop = false;
            // 
            // ptbpHeart2
            // 
            ptbpHeart2.Location = new Point(70, 123);
            ptbpHeart2.Name = "ptbpHeart2";
            ptbpHeart2.Size = new Size(40, 40);
            ptbpHeart2.TabIndex = 13;
            ptbpHeart2.TabStop = false;
            // 
            // ptbpHeart3
            // 
            ptbpHeart3.Location = new Point(116, 123);
            ptbpHeart3.Name = "ptbpHeart3";
            ptbpHeart3.Size = new Size(40, 40);
            ptbpHeart3.TabIndex = 14;
            ptbpHeart3.TabStop = false;
            // 
            // ptbpHeart4
            // 
            ptbpHeart4.Location = new Point(162, 123);
            ptbpHeart4.Name = "ptbpHeart4";
            ptbpHeart4.Size = new Size(40, 40);
            ptbpHeart4.TabIndex = 15;
            ptbpHeart4.TabStop = false;
            // 
            // ptbpHeart5
            // 
            ptbpHeart5.Location = new Point(208, 123);
            ptbpHeart5.Name = "ptbpHeart5";
            ptbpHeart5.Size = new Size(40, 40);
            ptbpHeart5.TabIndex = 16;
            ptbpHeart5.TabStop = false;
            // 
            // Game3Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 579);
            Controls.Add(ptbpHeart5);
            Controls.Add(ptbpHeart4);
            Controls.Add(ptbpHeart3);
            Controls.Add(ptbpHeart2);
            Controls.Add(ptbpHeart1);
            Controls.Add(btnPlayAgain);
            Controls.Add(ptbBotShield);
            Controls.Add(ptbPAtk);
            Controls.Add(lblBot);
            Controls.Add(lblPlayer);
            Controls.Add(ptbBot);
            Controls.Add(ptbPlayer);
            Controls.Add(btnHeal);
            Controls.Add(btnShield);
            Controls.Add(btnExit);
            Controls.Add(btnAtk);
            Controls.Add(ptbBg);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game3Form";
            Text = "Game3Form";
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
    }
}