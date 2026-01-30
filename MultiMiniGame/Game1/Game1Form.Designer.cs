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
            rtbChat = new RichTextBox();
            lblTitle = new Label();
            txtInput = new TextBox();
            btnSend = new Button();
            btnExit = new Button();
            btnInfo = new Button();
            btnStart = new Button();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbChat.Location = new Point(25, 60);
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
            lblTitle.Location = new Point(190, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Guess The Word";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(25, 596);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(446, 34);
            txtInput.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.Enabled = false;
            btnSend.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(477, 596);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(80, 34);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(25, 636);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnInfo
            // 
            btnInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInfo.Location = new Point(430, 636);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(125, 34);
            btnInfo.TabIndex = 5;
            btnInfo.Text = "Game Info";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(131, 636);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(293, 34);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start / Restart";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Game1Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 715);
            Controls.Add(btnStart);
            Controls.Add(btnInfo);
            Controls.Add(btnExit);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(lblTitle);
            Controls.Add(rtbChat);
            Name = "Game1Form";
            Text = "Guess The Word";
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
    }
}