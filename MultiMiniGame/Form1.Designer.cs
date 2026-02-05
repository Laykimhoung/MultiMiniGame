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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picBackGround = new PictureBox();
            btnGame1 = new Button();
            btnGame2 = new Button();
            btnGame3 = new Button();
            lbWelcome = new Label();
            btnGame4 = new Button();
            btnGame5 = new Button();
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
            btnGame1.Location = new Point(217, 284);
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
            btnGame2.Location = new Point(396, 378);
            btnGame2.Name = "btnGame2";
            btnGame2.Size = new Size(232, 74);
            btnGame2.TabIndex = 2;
            btnGame2.Text = "ហ្គេមមហាសេដ្ឋី";
            btnGame2.UseVisualStyleBackColor = false;
            btnGame2.Click += btnGame2_Click;
            // 
            // btnGame3
            // 
            btnGame3.BackColor = Color.Red;
            btnGame3.FlatStyle = FlatStyle.Flat;
            btnGame3.Font = new Font("Khmer OS Siemreap", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGame3.ForeColor = Color.Black;
            btnGame3.Location = new Point(598, 284);
            btnGame3.Name = "btnGame3";
            btnGame3.Size = new Size(232, 74);
            btnGame3.TabIndex = 3;
            btnGame3.Text = "ហាមចូល មេវៃ";
            btnGame3.UseVisualStyleBackColor = false;
            btnGame3.Click += btnGame3_Click;
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.BackColor = SystemColors.ButtonHighlight;
            lbWelcome.Font = new Font("Khmer OS Bokor", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWelcome.ForeColor = Color.Black;
            lbWelcome.Location = new Point(217, 116);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(596, 83);
            lbWelcome.TabIndex = 4;
            lbWelcome.Text = "សូមស្វាគមន៍មកកាន់ទំព័រហ្គេមរបស់យើងខ្ញុំ";
            // 
            // btnGame4
            // 
            btnGame4.BackColor = Color.FromArgb(0, 192, 0);
            btnGame4.FlatStyle = FlatStyle.Flat;
            btnGame4.Font = new Font("Khmer OS Siemreap", 13.8F);
            btnGame4.ForeColor = Color.White;
            btnGame4.Location = new Point(217, 469);
            btnGame4.Name = "btnGame4";
            btnGame4.Size = new Size(232, 74);
            btnGame4.TabIndex = 5;
            btnGame4.Text = "Game4";
            btnGame4.UseVisualStyleBackColor = false;
            btnGame4.Click += btnGame4_Click;
            // 
            // btnGame5
            // 
            btnGame5.BackColor = Color.Pink;
            btnGame5.FlatStyle = FlatStyle.Flat;
            btnGame5.Font = new Font("Khmer OS Siemreap", 13.8F);
            btnGame5.Location = new Point(598, 478);
            btnGame5.Name = "btnGame5";
            btnGame5.Size = new Size(232, 74);
            btnGame5.TabIndex = 6;
            btnGame5.Text = "Game5";
            btnGame5.UseVisualStyleBackColor = false;
            btnGame5.Click += btnGame5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 590);
            Controls.Add(btnGame5);
            Controls.Add(btnGame4);
            Controls.Add(lbWelcome);
            Controls.Add(btnGame3);
            Controls.Add(btnGame2);
            Controls.Add(btnGame1);
            Controls.Add(picBackGround);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btnGame4;
        private Button btnGame5;
    }
}
