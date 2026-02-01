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
            picBackGround = new PictureBox();
            btnStart = new Button();
            lbQuestion = new Label();
            panelQuestion = new Panel();
            btnExit = new Button();
            btnA = new btnGame2();
            btnB = new btnGame2();
            btnC = new btnGame2();
            btnD = new btnGame2();
            lbShow = new Label();
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
            lbShow.ForeColor = Color.White;
            lbShow.Location = new Point(298, 55);
            lbShow.Name = "lbShow";
            lbShow.Size = new Size(91, 67);
            lbShow.TabIndex = 17;
            lbShow.Text = "Text";
            // 
            // Game2Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 588);
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
    }
}