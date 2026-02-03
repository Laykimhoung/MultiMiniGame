namespace MultiMiniGame.Game1
{
    partial class Game1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1Form));
            rtbChat = new RichTextBox();
            lblTitle = new Label();
            txtInput = new TextBox();
            btnSend = new Button();
            btnExit = new Button();
            btnInfo = new Button();
            btnStart = new Button();
            G1_Background = new PictureBox();
            picSaba = new PictureBox();
            Saba = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)G1_Background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSaba).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Saba).BeginInit();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.BackColor = Color.MintCream;
            rtbChat.BorderStyle = BorderStyle.None;
            rtbChat.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbChat.Location = new Point(171, 69);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(530, 530);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(353, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Guess The Word";
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.MintCream;
            txtInput.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(171, 605);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(446, 34);
            txtInput.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.Highlight;
            btnSend.Enabled = false;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(623, 605);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(80, 34);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(171, 645);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Yellow;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInfo.Location = new Point(576, 645);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(125, 34);
            btnInfo.TabIndex = 5;
            btnInfo.Text = "Game Info";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LawnGreen;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(277, 645);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(293, 34);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start / Restart";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // G1_Background
            // 
            G1_Background.Dock = DockStyle.Fill;
            G1_Background.Image = Properties.Resources.G1_Background;
            G1_Background.Location = new Point(0, 0);
            G1_Background.Name = "G1_Background";
            G1_Background.Size = new Size(887, 715);
            G1_Background.SizeMode = PictureBoxSizeMode.CenterImage;
            G1_Background.TabIndex = 7;
            G1_Background.TabStop = false;
            // 
            // picSaba
            // 
            picSaba.Image = Properties.Resources.G1_CatchedSaba;
            picSaba.Location = new Point(677, 0);
            picSaba.Name = "picSaba";
            picSaba.Size = new Size(210, 347);
            picSaba.SizeMode = PictureBoxSizeMode.StretchImage;
            picSaba.TabIndex = 8;
            picSaba.TabStop = false;
            // 
            // Saba
            // 
            Saba.Image = Properties.Resources.Saba;
            Saba.Location = new Point(-41, 441);
            Saba.Name = "Saba";
            Saba.Size = new Size(256, 238);
            Saba.SizeMode = PictureBoxSizeMode.StretchImage;
            Saba.TabIndex = 9;
            Saba.TabStop = false;
            // 
            // Game1Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 715);
            Controls.Add(Saba);
            Controls.Add(picSaba);
            Controls.Add(btnStart);
            Controls.Add(btnInfo);
            Controls.Add(btnExit);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(lblTitle);
            Controls.Add(rtbChat);
            Controls.Add(G1_Background);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game1Form";
            Text = "Guess The Word";
            Load += Game1Form_Load;
            ((System.ComponentModel.ISupportInitialize)G1_Background).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSaba).EndInit();
            ((System.ComponentModel.ISupportInitialize)Saba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbChat;
        private Label lblTitle;
        private TextBox txtInput;
        private Button btnSend;
        private Button btnExit;
        private Button btnInfo;
        private Button btnStart;
        private PictureBox G1_Background;
        private PictureBox picSaba;
        private PictureBox Saba;
    }
}