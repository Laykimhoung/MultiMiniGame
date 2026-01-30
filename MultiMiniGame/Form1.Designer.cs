namespace MultiMiniGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picBackGround = new PictureBox();
            btnGame1 = new Button();
            btnGame2 = new Button();
            btnGame3 = new Button();
            lbWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)picBackGround).BeginInit();
            SuspendLayout();
            // 
            // picBackGround
            // 
            picBackGround.Dock = DockStyle.Fill;
            picBackGround.Image = Properties.Resources.Angkor_Wat;
            picBackGround.Location = new Point(0, 0);
            picBackGround.Name = "picBackGround";
            picBackGround.Size = new Size(800, 450);
            picBackGround.SizeMode = PictureBoxSizeMode.StretchImage;
            picBackGround.TabIndex = 0;
            picBackGround.TabStop = false;
            // 
            // btnGame1
            // 
            btnGame1.FlatStyle = FlatStyle.Flat;
            btnGame1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGame1.Location = new Point(314, 186);
            btnGame1.Name = "btnGame1";
            btnGame1.Size = new Size(157, 51);
            btnGame1.TabIndex = 1;
            btnGame1.Text = "Game 1";
            btnGame1.UseVisualStyleBackColor = true;
            btnGame1.Click += btnGame1_Click;
            // 
            // btnGame2
            // 
            btnGame2.BackColor = Color.MediumBlue;
            btnGame2.FlatStyle = FlatStyle.Flat;
            btnGame2.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGame2.ForeColor = Color.White;
            btnGame2.Location = new Point(314, 272);
            btnGame2.Name = "btnGame2";
            btnGame2.Size = new Size(157, 51);
            btnGame2.TabIndex = 2;
            btnGame2.Text = "ហ្គេមមហាសេដ្ឋី";
            btnGame2.UseVisualStyleBackColor = false;
            btnGame2.Click += btnGame2_Click;
            // 
            // btnGame3
            // 
            btnGame3.FlatStyle = FlatStyle.Flat;
            btnGame3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGame3.Location = new Point(314, 354);
            btnGame3.Name = "btnGame3";
            btnGame3.Size = new Size(157, 51);
            btnGame3.TabIndex = 3;
            btnGame3.Text = "Game 3";
            btnGame3.UseVisualStyleBackColor = true;
            btnGame3.Click += btnGame3_Click;
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.BackColor = SystemColors.ActiveCaptionText;
            lbWelcome.Font = new Font("Khmer OS Muol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWelcome.ForeColor = Color.FromArgb(192, 0, 0);
            lbWelcome.Location = new Point(134, 113);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(527, 47);
            lbWelcome.TabIndex = 4;
            lbWelcome.Text = "សូមស្វាគមន៍មកកាន់ទំព័រហ្គេមរបស់យើងខ្ញុំ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbWelcome);
            Controls.Add(btnGame3);
            Controls.Add(btnGame2);
            Controls.Add(btnGame1);
            Controls.Add(picBackGround);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picBackGround).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBackGround;
        private Button btnGame1;
        private Button btnGame2;
        private Button btnGame3;
        private Label lbWelcome;
    }
}
