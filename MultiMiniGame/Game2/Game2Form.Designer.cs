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
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnStart = new Button();
            lbQuestion = new Label();
            panelQuestion = new Panel();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picBackGround).BeginInit();
            panelQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // picBackGround
            // 
            picBackGround.Image = Properties.Resources.Game2BackGround;
            picBackGround.Location = new Point(0, 0);
            picBackGround.Name = "picBackGround";
            picBackGround.Size = new Size(866, 537);
            picBackGround.SizeMode = PictureBoxSizeMode.StretchImage;
            picBackGround.TabIndex = 0;
            picBackGround.TabStop = false;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(0, 45, 160);
            btnA.FlatStyle = FlatStyle.Flat;
            btnA.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnA.ForeColor = Color.White;
            btnA.Location = new Point(31, 410);
            btnA.Name = "btnA";
            btnA.Size = new Size(386, 54);
            btnA.TabIndex = 1;
            btnA.Text = "button1";
            btnA.TextAlign = ContentAlignment.MiddleLeft;
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.BackColor = Color.FromArgb(0, 45, 160);
            btnB.FlatStyle = FlatStyle.Flat;
            btnB.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnB.ForeColor = Color.White;
            btnB.Location = new Point(460, 410);
            btnB.Name = "btnB";
            btnB.Size = new Size(386, 54);
            btnB.TabIndex = 2;
            btnB.Text = "button1";
            btnB.TextAlign = ContentAlignment.MiddleLeft;
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(0, 45, 160);
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(31, 470);
            btnC.Name = "btnC";
            btnC.Size = new Size(386, 54);
            btnC.TabIndex = 6;
            btnC.Text = "button1";
            btnC.TextAlign = ContentAlignment.MiddleLeft;
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(0, 45, 160);
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnD.ForeColor = Color.White;
            btnD.Location = new Point(460, 470);
            btnD.Name = "btnD";
            btnD.Size = new Size(386, 54);
            btnD.TabIndex = 7;
            btnD.Text = "button1";
            btnD.TextAlign = ContentAlignment.MiddleLeft;
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 192, 0);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(324, 401);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(146, 54);
            btnStart.TabIndex = 8;
            btnStart.Text = "ចាប់ផ្ដើមលេង";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lbQuestion
            // 
            lbQuestion.AutoSize = true;
            lbQuestion.BackColor = Color.Transparent;
            lbQuestion.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQuestion.ForeColor = Color.Black;
            lbQuestion.Location = new Point(96, 38);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(54, 33);
            lbQuestion.TabIndex = 10;
            lbQuestion.Text = "សំនួរ";
            // 
            // panelQuestion
            // 
            panelQuestion.Controls.Add(lbQuestion);
            panelQuestion.Location = new Point(1, 305);
            panelQuestion.Name = "panelQuestion";
            panelQuestion.Size = new Size(854, 113);
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
            // Game2Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 536);
            Controls.Add(btnExit);
            Controls.Add(panelQuestion);
            Controls.Add(btnStart);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(picBackGround);
            Name = "Game2Form";
            Text = "Game2Form";
            Load += Game2Form_Load;
            ((System.ComponentModel.ISupportInitialize)picBackGround).EndInit();
            panelQuestion.ResumeLayout(false);
            panelQuestion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBackGround;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnStart;
        private Label lbQuestion;
        private Panel panelQuestion;
        private Button btnExit;
    }
}