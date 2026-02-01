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
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbBg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbBot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbPAtk).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Location = new Point(0, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(922, 80);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAtk
            // 
            btnAtk.BackColor = Color.Red;
            btnAtk.FlatStyle = FlatStyle.Flat;
            btnAtk.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtk.ForeColor = Color.Linen;
            btnAtk.Location = new Point(240, 426);
            btnAtk.Name = "btnAtk";
            btnAtk.Size = new Size(150, 55);
            btnAtk.TabIndex = 0;
            btnAtk.Text = "វៃ";
            btnAtk.UseVisualStyleBackColor = false;
            // 
            // ptbBg
            // 
            ptbBg.Location = new Point(331, 251);
            ptbBg.Name = "ptbBg";
            ptbBg.Size = new Size(282, 134);
            ptbBg.TabIndex = 1;
            ptbBg.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Yellow;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(39, 426);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 55);
            btnExit.TabIndex = 2;
            btnExit.Text = "ចាកចេញ";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnShield
            // 
            btnShield.BackColor = Color.Cyan;
            btnShield.FlatStyle = FlatStyle.Flat;
            btnShield.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShield.ForeColor = SystemColors.Highlight;
            btnShield.Location = new Point(487, 426);
            btnShield.Name = "btnShield";
            btnShield.Size = new Size(150, 55);
            btnShield.TabIndex = 3;
            btnShield.Text = "រនាំង";
            btnShield.UseVisualStyleBackColor = false;
            // 
            // btnHeal
            // 
            btnHeal.BackColor = Color.Lime;
            btnHeal.FlatStyle = FlatStyle.Flat;
            btnHeal.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHeal.ForeColor = Color.Navy;
            btnHeal.Location = new Point(720, 426);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(150, 55);
            btnHeal.TabIndex = 4;
            btnHeal.Text = "ផឹកថ្នាំ";
            btnHeal.UseVisualStyleBackColor = false;
            // 
            // ptbPlayer
            // 
            ptbPlayer.Location = new Point(64, 180);
            ptbPlayer.Name = "ptbPlayer";
            ptbPlayer.Size = new Size(150, 220);
            ptbPlayer.TabIndex = 5;
            ptbPlayer.TabStop = false;
            // 
            // ptbBot
            // 
            ptbBot.Location = new Point(690, 208);
            ptbBot.Name = "ptbBot";
            ptbBot.Size = new Size(162, 110);
            ptbBot.TabIndex = 6;
            ptbBot.TabStop = false;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayer.Location = new Point(119, 141);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(43, 36);
            lblPlayer.TabIndex = 7;
            lblPlayer.Text = "អ្នក";
            // 
            // lblBot
            // 
            lblBot.AutoSize = true;
            lblBot.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBot.Location = new Point(738, 141);
            lblBot.Name = "lblBot";
            lblBot.Size = new Size(43, 36);
            lblBot.TabIndex = 8;
            lblBot.Text = "អ្នក";
            // 
            // ptbPAtk
            // 
            ptbPAtk.Location = new Point(220, 251);
            ptbPAtk.Name = "ptbPAtk";
            ptbPAtk.Size = new Size(40, 40);
            ptbPAtk.TabIndex = 9;
            ptbPAtk.TabStop = false;
            // 
            // Game3Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 493);
            Controls.Add(ptbPAtk);
            Controls.Add(lblBot);
            Controls.Add(lblPlayer);
            Controls.Add(ptbBot);
            Controls.Add(ptbPlayer);
            Controls.Add(btnHeal);
            Controls.Add(btnShield);
            Controls.Add(btnExit);
            Controls.Add(ptbBg);
            Controls.Add(btnAtk);
            Controls.Add(pictureBox1);
            Name = "Game3Form";
            Text = "Game3Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbBg).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbBot).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbPAtk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
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
    }
}