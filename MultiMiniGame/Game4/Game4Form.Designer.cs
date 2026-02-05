namespace MultiMiniGame.Game4
{
    partial class Game4Form
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
            lblScore = new Label();
            ball = new PictureBox();
            player = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScore.ForeColor = SystemColors.ControlLightLight;
            lblScore.Location = new Point(21, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(79, 23);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score : 0";
            // 
            // ball
            // 
            ball.BackColor = Color.FromArgb(255, 128, 0);
            ball.Image = Properties.Resources.Gam4_ball;
            ball.Location = new Point(468, 425);
            ball.Margin = new Padding(3, 2, 3, 2);
            ball.Name = "ball";
            ball.Size = new Size(20, 20);
            ball.SizeMode = PictureBoxSizeMode.StretchImage;
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // player
            // 
            player.BackColor = SystemColors.ControlLightLight;
            player.Image = Properties.Resources.Game4Ground;
            player.Location = new Point(427, 444);
            player.Margin = new Padding(3, 2, 3, 2);
            player.Name = "player";
            player.Size = new Size(100, 20);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 2;
            player.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 16;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = Properties.Resources.lavaGame4;
            pictureBox1.Location = new Point(-6, 472);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(963, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Game4Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(955, 503);
            Controls.Add(player);
            Controls.Add(ball);
            Controls.Add(lblScore);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Game4Form";
            Text = "Breakout Game";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private PictureBox ball;
        private PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox pictureBox1;
    }
}