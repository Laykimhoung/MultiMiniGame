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
            pictureBox1 = new PictureBox();
            btnA = new Button();
            btnB = new Button();
            btnQuestion = new Button();
            btnC = new Button();
            btnD = new Button();
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Game2BackGround;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(866, 537);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(0, 45, 160);
            btnA.FlatStyle = FlatStyle.Flat;
            btnA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnA.ForeColor = Color.White;
            btnA.Location = new Point(31, 410);
            btnA.Name = "btnA";
            btnA.Size = new Size(386, 54);
            btnA.TabIndex = 1;
            btnA.Text = "button1";
            btnA.TextAlign = ContentAlignment.MiddleLeft;
            btnA.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            btnB.BackColor = Color.FromArgb(0, 45, 160);
            btnB.FlatStyle = FlatStyle.Flat;
            btnB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnB.ForeColor = Color.White;
            btnB.Location = new Point(460, 410);
            btnB.Name = "btnB";
            btnB.Size = new Size(386, 54);
            btnB.TabIndex = 2;
            btnB.Text = "button1";
            btnB.TextAlign = ContentAlignment.MiddleLeft;
            btnB.UseVisualStyleBackColor = false;
            // 
            // btnQuestion
            // 
            btnQuestion.BackColor = Color.Navy;
            btnQuestion.FlatStyle = FlatStyle.Flat;
            btnQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuestion.ForeColor = Color.White;
            btnQuestion.Location = new Point(31, 324);
            btnQuestion.Name = "btnQuestion";
            btnQuestion.Size = new Size(815, 80);
            btnQuestion.TabIndex = 5;
            btnQuestion.Text = "button1";
            btnQuestion.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(0, 45, 160);
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(31, 470);
            btnC.Name = "btnC";
            btnC.Size = new Size(386, 54);
            btnC.TabIndex = 6;
            btnC.Text = "button1";
            btnC.TextAlign = ContentAlignment.MiddleLeft;
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            btnD.BackColor = Color.FromArgb(0, 45, 160);
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnD.ForeColor = Color.White;
            btnD.Location = new Point(460, 470);
            btnD.Name = "btnD";
            btnD.Size = new Size(386, 54);
            btnD.TabIndex = 7;
            btnD.Text = "button1";
            btnD.TextAlign = ContentAlignment.MiddleLeft;
            btnD.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 45, 160);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(314, 74);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(236, 54);
            btnStart.TabIndex = 8;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // Game2Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 536);
            Controls.Add(btnStart);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnQuestion);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(pictureBox1);
            Name = "Game2Form";
            Text = "Game2Form";
            Load += Game2Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnA;
        private Button btnB;
        private Button button2;
        private Button button3;
        private Button btnQuestion;
        private Button btnC;
        private Button btnD;
        private Button btnStart;
    }
}