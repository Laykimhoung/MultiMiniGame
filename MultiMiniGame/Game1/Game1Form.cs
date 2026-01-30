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
        string rndWord = "";

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
            if (input == $"{rndWord}$" || input == "KBATI")
            {
                AddMessage("You Win", $"Congratulations! The word is {rndWord}!");
                MessageBox.Show($"You guessed the word correctly!\nThe Word is {rndWord}", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AddMessage("You: ", input);
            txtInput.Clear();

            // jam vea kit sen
            string response = await _ai.GetResponseAsync(input);
            AddMessage("Hint: ", response);
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = true;
            rndWord = words[_random.Next(words.Length)];
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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string info = "Welcome to the Word Guessing Game!\n\n" +
                "How to Play:\n" +
                "1. Click 'Start Game' to begin.\n" +
                "2. You will receive a hint for a secret word.\n" +
                "3. Type your guess in the input box and click 'Send'.\n" +
                "4. If you guess correctly, you'll be congratulated!\n\n" +
                "5. The AI in this is small. If there is a problem click Restart" +
                "Enjoy the game and have fun guessing!";
            MessageBox.Show(info, "Game Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
