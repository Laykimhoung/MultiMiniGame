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
        Random _random = new Random();
        string[] words = { "Apple", "Banana", "Orange", "Mango", "Grape", "Lemon",
    "Dog","Cat","Cow","Pig","Fish","Bird","Duck","Horse","Rabbit","Chicken",
    "Pineapple","Watermelon","Papaya", "Cloud","Rock","Leaf","Water", "Strawberry",
    "Chair","Table","Bed","Sofa","Door","Window","Lamp","Fan","Pillow","Mirror",
    "Book","Pen","Pencil","Bag","Ruler","Eraser","Clock","Phone","Bottle","Cup",
    "Sun","Moon","Star","Tree","Flower","Rain" };
        string prompt = @"Give ONE short hint (3–6 words) for a word guessing game. You give a hint. The player guesses the word. 
Do NOT define, classify, or give the word. 
Avoid repeating previous hints 
The Word is: Shark
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
            btnSend.Enabled = true;
            string rndWord = words[_random.Next(words.Length)];
            string temPrompt = prompt.Replace("Shark", rndWord);

            _ai.ResetMemory();
            rtbChat.Clear();

            string response = await _ai.GetResponseAsync(temPrompt);
            AddMessage("Hint: ", response);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddMessage(string sender, string msg)
        {
            rtbChat.AppendText(sender + " ");

            rtbChat.SelectionFont = new Font(rtbChat.Font, FontStyle.Regular);
            rtbChat.AppendText(msg + Environment.NewLine + Environment.NewLine);

            // Auto scroll
            rtbChat.ScrollToCaret();
        }
    }
}
