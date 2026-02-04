namespace MultiMiniGame.Game2
{
    partial class Game2Form
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
            picBackGround = new PictureBox();
            btnStart = new Button();
            lbQuestion = new Label();
            panelQuestion = new Panel();
            btnLost = new Button();
            btnExit = new Button();
            btnA = new btnGame2();
            btnB = new btnGame2();
            btnC = new btnGame2();
            btnD = new btnGame2();
            lbShow = new Label();
            btnNextRound = new Button();
            btnStop = new Button();
            btn5050 = new Button();
            btnCall = new Button();
            lbTimer = new Label();
            lbTotalMoney = new Label();
            lbR1 = new Label();
            lbR2 = new Label();
            lbR3 = new Label();
            lbR4 = new Label();
            lbR5 = new Label();
            lbR6 = new Label();
            lbR7 = new Label();
            lbR8 = new Label();
            lbR9 = new Label();
            lbR10 = new Label();
            lbR11 = new Label();
            lbR12 = new Label();
            lbR13 = new Label();
            lbR14 = new Label();
            lbR15 = new Label();
            roundTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picBackGround).BeginInit();
            panelQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // picBackGround
            // 
            picBackGround.Dock = DockStyle.Fill;
            picBackGround.Image = Properties.Resources.Game2BackGround;
            picBackGround.Location = new Point(0, 0);
            picBackGround.Name = "picBackGround";
            picBackGround.Size = new Size(958, 588);
            picBackGround.SizeMode = PictureBoxSizeMode.StretchImage;
            picBackGround.TabIndex = 0;
            picBackGround.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 192, 0);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(363, 428);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(155, 58);
            btnStart.TabIndex = 8;
            btnStart.Text = "ចាប់ផ្ដើមលេង";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lbQuestion
            // 
            lbQuestion.AutoSize = true;
            lbQuestion.BackColor = Color.Transparent;
            lbQuestion.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQuestion.ForeColor = Color.Black;
            lbQuestion.Location = new Point(96, 38);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(58, 36);
            lbQuestion.TabIndex = 10;
            lbQuestion.Text = "សំនួរ";
            // 
            // panelQuestion
            // 
            panelQuestion.Controls.Add(lbQuestion);
            panelQuestion.Location = new Point(12, 332);
            panelQuestion.Name = "panelQuestion";
            panelQuestion.Size = new Size(934, 113);
            panelQuestion.TabIndex = 11;
            // 
            // btnLost
            // 
            btnLost.BackColor = Color.Red;
            btnLost.FlatStyle = FlatStyle.Flat;
            btnLost.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLost.ForeColor = Color.White;
            btnLost.Location = new Point(325, 226);
            btnLost.Name = "btnLost";
            btnLost.Size = new Size(276, 58);
            btnLost.TabIndex = 39;
            btnLost.Text = " សូមចូលរួមចោកស្តាយផង";
            btnLost.UseVisualStyleBackColor = false;
            btnLost.Click += btnLost_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(12, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 41);
            btnExit.TabIndex = 12;
            btnExit.Text = "ចាកចេញ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.Transparent;
            btnA.FlatAppearance.BorderSize = 0;
            btnA.FlatStyle = FlatStyle.Flat;
            btnA.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnA.ForeColor = Color.White;
            btnA.Location = new Point(12, 451);
            btnA.Name = "btnA";
            btnA.Size = new Size(457, 56);
            btnA.TabIndex = 13;
            btnA.Text = "   Text";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            btnA.MouseLeave += btnA_MouseLeave;
            btnA.MouseHover += btnA_MouseHover;
            // 
            // btnB
            // 
            btnB.BackColor = Color.Transparent;
            btnB.FlatAppearance.BorderSize = 0;
            btnB.FlatStyle = FlatStyle.Flat;
            btnB.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnB.ForeColor = Color.White;
            btnB.Location = new Point(489, 451);
            btnB.Name = "btnB";
            btnB.Size = new Size(457, 56);
            btnB.TabIndex = 14;
            btnB.Text = "   Text";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            btnB.MouseLeave += btnB_MouseLeave;
            btnB.MouseHover += btnB_MouseHover;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Transparent;
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(12, 520);
            btnC.Name = "btnC";
            btnC.Size = new Size(457, 56);
            btnC.TabIndex = 15;
            btnC.Text = "   Text";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            btnC.MouseLeave += btnC_MouseLeave;
            btnC.MouseHover += btnC_MouseHover;
            // 
            // btnD
            // 
            btnD.BackColor = Color.Transparent;
            btnD.FlatAppearance.BorderSize = 0;
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnD.ForeColor = Color.White;
            btnD.Location = new Point(489, 520);
            btnD.Name = "btnD";
            btnD.Size = new Size(457, 56);
            btnD.TabIndex = 16;
            btnD.Text = "   Text";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            btnD.MouseLeave += btnD_MouseLeave;
            btnD.MouseHover += btnD_MouseHover;
            // 
            // lbShow
            // 
            lbShow.AutoSize = true;
            lbShow.BackColor = SystemColors.ActiveCaptionText;
            lbShow.Font = new Font("Khmer OS Bokor", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbShow.ForeColor = Color.Gold;
            lbShow.Location = new Point(392, 84);
            lbShow.Name = "lbShow";
            lbShow.Size = new Size(91, 67);
            lbShow.TabIndex = 17;
            lbShow.Text = "Text";
            lbShow.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnNextRound
            // 
            btnNextRound.BackColor = Color.FromArgb(0, 192, 0);
            btnNextRound.FlatStyle = FlatStyle.Flat;
            btnNextRound.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextRound.ForeColor = Color.White;
            btnNextRound.Location = new Point(374, 268);
            btnNextRound.Name = "btnNextRound";
            btnNextRound.Size = new Size(155, 58);
            btnNextRound.TabIndex = 18;
            btnNextRound.Text = "បន្តទៅជុំបន្ទាប់";
            btnNextRound.UseVisualStyleBackColor = false;
            btnNextRound.Click += btnNextRound_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Red;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(172, 268);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(164, 58);
            btnStop.TabIndex = 19;
            btnStop.Text = "បញ្ឃប់ការប្រកួត";
            btnStop.UseVisualStyleBackColor = false;
            // 
            // btn5050
            // 
            btn5050.BackColor = Color.Gold;
            btn5050.FlatStyle = FlatStyle.Flat;
            btn5050.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5050.ForeColor = Color.Black;
            btn5050.Location = new Point(28, 142);
            btn5050.Name = "btn5050";
            btn5050.Size = new Size(138, 58);
            btn5050.TabIndex = 20;
            btn5050.Text = "៥០​/៥០";
            btn5050.UseVisualStyleBackColor = false;
            btn5050.Click += btn5050_Click;
            // 
            // btnCall
            // 
            btnCall.BackColor = Color.Gold;
            btnCall.FlatStyle = FlatStyle.Flat;
            btnCall.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCall.ForeColor = Color.Black;
            btnCall.Location = new Point(28, 215);
            btnCall.Name = "btnCall";
            btnCall.Size = new Size(138, 58);
            btnCall.TabIndex = 21;
            btnCall.Text = "ទេរកជំនួយ";
            btnCall.UseVisualStyleBackColor = false;
            btnCall.Click += btnCall_Click;
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.BackColor = Color.Black;
            lbTimer.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTimer.ForeColor = Color.White;
            lbTimer.Location = new Point(392, 25);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(126, 53);
            lbTimer.TabIndex = 22;
            lbTimer.Text = "Time";
            // 
            // lbTotalMoney
            // 
            lbTotalMoney.AutoSize = true;
            lbTotalMoney.BackColor = Color.Black;
            lbTotalMoney.Font = new Font("AKbalthom HighSchool", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalMoney.ForeColor = Color.Lime;
            lbTotalMoney.Location = new Point(801, 0);
            lbTotalMoney.Name = "lbTotalMoney";
            lbTotalMoney.Size = new Size(98, 50);
            lbTotalMoney.TabIndex = 23;
            lbTotalMoney.Text = "Money";
            lbTotalMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR1
            // 
            lbR1.AutoSize = true;
            lbR1.BackColor = Color.Black;
            lbR1.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR1.ForeColor = Color.White;
            lbR1.Location = new Point(745, 280);
            lbR1.Name = "lbR1";
            lbR1.Size = new Size(70, 31);
            lbR1.TabIndex = 24;
            lbR1.Text = "Round1";
            lbR1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR2
            // 
            lbR2.AutoSize = true;
            lbR2.BackColor = Color.Black;
            lbR2.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR2.ForeColor = Color.White;
            lbR2.Location = new Point(852, 280);
            lbR2.Name = "lbR2";
            lbR2.Size = new Size(71, 31);
            lbR2.TabIndex = 25;
            lbR2.Text = "Round2";
            lbR2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR3
            // 
            lbR3.AutoSize = true;
            lbR3.BackColor = Color.Black;
            lbR3.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR3.ForeColor = Color.White;
            lbR3.Location = new Point(746, 249);
            lbR3.Name = "lbR3";
            lbR3.Size = new Size(71, 31);
            lbR3.TabIndex = 26;
            lbR3.Text = "Round3";
            lbR3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR4
            // 
            lbR4.AutoSize = true;
            lbR4.BackColor = Color.Black;
            lbR4.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR4.ForeColor = Color.White;
            lbR4.Location = new Point(851, 249);
            lbR4.Name = "lbR4";
            lbR4.Size = new Size(71, 31);
            lbR4.TabIndex = 27;
            lbR4.Text = "Round4";
            lbR4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR5
            // 
            lbR5.AutoSize = true;
            lbR5.BackColor = Color.Black;
            lbR5.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR5.ForeColor = Color.White;
            lbR5.Location = new Point(744, 218);
            lbR5.Name = "lbR5";
            lbR5.Size = new Size(72, 31);
            lbR5.TabIndex = 28;
            lbR5.Text = "Round5";
            lbR5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR6
            // 
            lbR6.AutoSize = true;
            lbR6.BackColor = Color.Black;
            lbR6.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR6.ForeColor = Color.White;
            lbR6.Location = new Point(851, 218);
            lbR6.Name = "lbR6";
            lbR6.Size = new Size(71, 31);
            lbR6.TabIndex = 29;
            lbR6.Text = "Round6";
            lbR6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR7
            // 
            lbR7.AutoSize = true;
            lbR7.BackColor = Color.Black;
            lbR7.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR7.ForeColor = Color.White;
            lbR7.Location = new Point(744, 187);
            lbR7.Name = "lbR7";
            lbR7.Size = new Size(71, 31);
            lbR7.TabIndex = 30;
            lbR7.Text = "Round7";
            lbR7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR8
            // 
            lbR8.AutoSize = true;
            lbR8.BackColor = Color.Black;
            lbR8.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR8.ForeColor = Color.White;
            lbR8.Location = new Point(851, 187);
            lbR8.Name = "lbR8";
            lbR8.Size = new Size(71, 31);
            lbR8.TabIndex = 31;
            lbR8.Text = "Round8";
            lbR8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR9
            // 
            lbR9.AutoSize = true;
            lbR9.BackColor = Color.Black;
            lbR9.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR9.ForeColor = Color.White;
            lbR9.Location = new Point(746, 156);
            lbR9.Name = "lbR9";
            lbR9.Size = new Size(71, 31);
            lbR9.TabIndex = 32;
            lbR9.Text = "Round9";
            lbR9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR10
            // 
            lbR10.AutoSize = true;
            lbR10.BackColor = Color.Black;
            lbR10.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR10.ForeColor = Color.White;
            lbR10.Location = new Point(851, 156);
            lbR10.Name = "lbR10";
            lbR10.Size = new Size(80, 31);
            lbR10.TabIndex = 33;
            lbR10.Text = "Round10";
            lbR10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR11
            // 
            lbR11.AutoSize = true;
            lbR11.BackColor = Color.Black;
            lbR11.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR11.ForeColor = Color.White;
            lbR11.Location = new Point(746, 120);
            lbR11.Name = "lbR11";
            lbR11.Size = new Size(78, 31);
            lbR11.TabIndex = 34;
            lbR11.Text = "Round11";
            lbR11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR12
            // 
            lbR12.AutoSize = true;
            lbR12.BackColor = Color.Black;
            lbR12.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR12.ForeColor = Color.White;
            lbR12.Location = new Point(852, 120);
            lbR12.Name = "lbR12";
            lbR12.Size = new Size(79, 31);
            lbR12.TabIndex = 35;
            lbR12.Text = "Round12";
            lbR12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR13
            // 
            lbR13.AutoSize = true;
            lbR13.BackColor = Color.Black;
            lbR13.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR13.ForeColor = Color.White;
            lbR13.Location = new Point(743, 89);
            lbR13.Name = "lbR13";
            lbR13.Size = new Size(79, 31);
            lbR13.TabIndex = 36;
            lbR13.Text = "Round13";
            lbR13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR14
            // 
            lbR14.AutoSize = true;
            lbR14.BackColor = Color.Black;
            lbR14.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR14.ForeColor = Color.White;
            lbR14.Location = new Point(852, 89);
            lbR14.Name = "lbR14";
            lbR14.Size = new Size(79, 31);
            lbR14.TabIndex = 37;
            lbR14.Text = "Round14";
            lbR14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbR15
            // 
            lbR15.AutoSize = true;
            lbR15.BackColor = Color.Black;
            lbR15.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbR15.ForeColor = Color.White;
            lbR15.Location = new Point(801, 58);
            lbR15.Name = "lbR15";
            lbR15.Size = new Size(80, 31);
            lbR15.TabIndex = 38;
            lbR15.Text = "Round15";
            // 
            // roundTimer
            // 
            roundTimer.Interval = 1000;
            roundTimer.Tick += roundTimer_Tick;
            // 
            // Game2Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 588);
            Controls.Add(btnLost);
            Controls.Add(lbR15);
            Controls.Add(lbR14);
            Controls.Add(lbR13);
            Controls.Add(lbR12);
            Controls.Add(lbR11);
            Controls.Add(lbR10);
            Controls.Add(lbR9);
            Controls.Add(lbR8);
            Controls.Add(lbR7);
            Controls.Add(lbR6);
            Controls.Add(lbR5);
            Controls.Add(lbR4);
            Controls.Add(lbR3);
            Controls.Add(lbR2);
            Controls.Add(lbR1);
            Controls.Add(lbTotalMoney);
            Controls.Add(lbTimer);
            Controls.Add(btnCall);
            Controls.Add(btn5050);
            Controls.Add(btnStop);
            Controls.Add(btnNextRound);
            Controls.Add(lbShow);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(btnExit);
            Controls.Add(panelQuestion);
            Controls.Add(btnStart);
            Controls.Add(picBackGround);
            Name = "Game2Form";
            Text = "Game2Form";
            Load += Game2Form_Load;
            ((System.ComponentModel.ISupportInitialize)picBackGround).EndInit();
            panelQuestion.ResumeLayout(false);
            panelQuestion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBackGround;
        private Button btnStart;
        private Label lbQuestion;
        private Panel panelQuestion;
        private Button btnExit;
        private btnGame2 btnA;
        private btnGame2 btnB;
        private btnGame2 btnC;
        private btnGame2 btnD;
        private Label lbShow;
        private Button btnNextRound;
        private Button btnStop;
        private Button btn5050;
        private Button btnCall;
        private Label lbTimer;
        private Label lbTotalMoney;
        private Label lbR1;
        private Label lbR2;
        private Label lbR3;
        private Label lbR4;
        private Label lbR5;
        private Label lbR6;
        private Label lbR7;
        private Label lbR8;
        private Label lbR9;
        private Label lbR10;
        private Label lbR11;
        private Label lbR12;
        private Label lbR13;
        private Label lbR14;
        private Label lbR15;
        private System.Windows.Forms.Timer roundTimer;
        private Button btnLost;
    }
}