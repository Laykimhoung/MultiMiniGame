using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiMiniGame.Game1
{
    public partial class Game1Form : Form
    {
        string prompt = @"Give ONE short hint (3–6 words) for a word guessing game. You give a hint. The player guesses the word. 
Do NOT define, classify, or give the word. 
Avoid repeating previous hints 
The Word is: orange 
Hint:";
        private AIManager _ai = new AIManager();
        public Game1Form()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (string.IsNullOrWhiteSpace(input)) return;

            AddMessage("You: ", input);
            txtInput.Clear();

            // jam vea kit sen
            string response = await _ai.GetResponseAsync(input);
            AddMessage("Hint: ", response);
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            _ai.ResetMemory();
            rtbChat.Clear();

            string response = await _ai.GetResponseAsync(prompt);
            AddMessage("Hint: ", response);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddMessage(string sender, string msg)
        {
            rtbChat.AppendText(sender + ": ");

            // Make the message Regular
            rtbChat.SelectionFont = new Font(rtbChat.Font, FontStyle.Regular);
            rtbChat.AppendText(msg + Environment.NewLine + Environment.NewLine);

            // Auto scroll
            rtbChat.ScrollToCaret();
        }
    }
}
