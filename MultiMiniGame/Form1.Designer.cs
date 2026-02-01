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
            picBackGround.Size = new Size(1032, 590);
            picBackGround.SizeMode = PictureBoxSizeMode.StretchImage;
            picBackGround.TabIndex = 0;
            picBackGround.TabStop = false;
            // 
            // btnGame1
            // 
            btnGame1.BackColor = Color.Gold;
            btnGame1.FlatStyle = FlatStyle.Flat;
            btnGame1.Font = new Font("Khmer OS Siemreap", 13.8F);
            btnGame1.Location = new Point(395, 256);
            btnGame1.Name = "btnGame1";
            btnGame1.Size = new Size(232, 74);
            btnGame1.TabIndex = 1;
            btnGame1.Text = "ហ្គេមទាយពាក្យ";
            btnGame1.UseVisualStyleBackColor = false;
            btnGame1.Click += btnGame1_Click;
            // 
            // btnGame2
            // 
            btnGame2.BackColor = Color.MediumBlue;
            btnGame2.FlatStyle = FlatStyle.Flat;
            btnGame2.Font = new Font("Khmer OS Siemreap", 13.8F);
            btnGame2.ForeColor = Color.White;
            btnGame2.Location = new Point(395, 359);
            btnGame2.Name = "btnGame2";
            btnGame2.Size = new Size(232, 74);
            btnGame2.TabIndex = 2;
            btnGame2.Text = "ហ្គេមមហាសេដ្ឋី";
            btnGame2.UseVisualStyleBackColor = false;
            btnGame2.Click += btnGame2_Click;
            // 
            // btnGame3
            // 
            btnGame3.FlatStyle = FlatStyle.Flat;
            btnGame3.Font = new Font("Khmer OS Siemreap", 13.8F);
            btnGame3.Location = new Point(395, 459);
            btnGame3.Name = "btnGame3";
            btnGame3.Size = new Size(232, 74);
            btnGame3.TabIndex = 3;
            btnGame3.Text = "Game 3";
            btnGame3.UseVisualStyleBackColor = true;
            btnGame3.Click += btnGame3_Click;
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.BackColor = SystemColors.ButtonHighlight;
            lbWelcome.Font = new Font("Khmer OS Bokor", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWelcome.ForeColor = Color.Black;
            lbWelcome.Location = new Point(254, 97);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(596, 83);
            lbWelcome.TabIndex = 4;
            lbWelcome.Text = "សូមស្វាគមន៍មកកាន់ទំព័រហ្គេមរបស់យើងខ្ញុំ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 590);
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
