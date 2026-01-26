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
            pictureBox1 = new PictureBox();
            btnGame1 = new Button();
            btnGame2 = new Button();
            btnGame3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Angkor_Wat;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnGame1
            // 
            btnGame1.FlatStyle = FlatStyle.Popup;
            btnGame1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGame1.Location = new Point(331, 183);
            btnGame1.Name = "btnGame1";
            btnGame1.Size = new Size(138, 51);
            btnGame1.TabIndex = 1;
            btnGame1.Text = "Game 1";
            btnGame1.UseVisualStyleBackColor = true;
            btnGame1.Click += btnGame1_Click;
            // 
            // btnGame2
            // 
            btnGame2.FlatStyle = FlatStyle.Popup;
            btnGame2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGame2.Location = new Point(331, 269);
            btnGame2.Name = "btnGame2";
            btnGame2.Size = new Size(138, 51);
            btnGame2.TabIndex = 2;
            btnGame2.Text = "Game 2";
            btnGame2.UseVisualStyleBackColor = true;
            btnGame2.Click += btnGame2_Click;
            // 
            // btnGame3
            // 
            btnGame3.FlatStyle = FlatStyle.Popup;
            btnGame3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGame3.Location = new Point(331, 351);
            btnGame3.Name = "btnGame3";
            btnGame3.Size = new Size(138, 51);
            btnGame3.TabIndex = 3;
            btnGame3.Text = "Game 3";
            btnGame3.UseVisualStyleBackColor = true;
            btnGame3.Click += btnGame3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGame3);
            Controls.Add(btnGame2);
            Controls.Add(btnGame1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnGame1;
        private Button btnGame2;
        private Button btnGame3;
    }
}
