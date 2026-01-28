using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MultiMiniGame.Game2;   // <-- namespace where Game2Method lives

namespace MultiMiniGame.Game2
{
    public partial class Game2Form : Form
    {
        // ===== GAME LOGIC OBJECT =====
        private Game2Method game;

        public Game2Form()
        {
            InitializeComponent();

            // Wire buttons (clean & short)
            btnA.Click += (s, e) => HandleAnswer(0);
            btnB.Click += (s, e) => HandleAnswer(1);
            btnC.Click += (s, e) => HandleAnswer(2);
            btnD.Click += (s, e) => HandleAnswer(3);

          
        }

        // ===== FORM LOAD =====
        private void Game2Form_Load(object sender, EventArgs e)
        {
            game = new Game2Method();
            game.LoadQuestions();   // Form never knows where JSON is

            DisableAnswerButtons();
            btnQuestion.Text = "Press Start to play";
        }

        // ===== START GAME =====
        private void btnStart_Click(object sender, EventArgs e)
        {
            game.StartGame();
            EnableAnswerButtons();
            ShowQuestion();
        }

        // ===== SHOW QUESTION =====
        private void ShowQuestion()
        {
            var q = game.CurrentQuestion;

            btnQuestion.Text = q.QuestionText;

            btnA.Text = "A. " + q.Answers[0];
            btnB.Text = "B. " + q.Answers[1];
            btnC.Text = "C. " + q.Answers[2];
            btnD.Text = "D. " + q.Answers[3];
        }

        // ===== HANDLE ANSWER =====
        private void HandleAnswer(int index)
        {
            bool isCorrect = game.Answer(index);

            if (!isCorrect)
            {
                DisableAnswerButtons();
                MessageBox.Show("❌ Wrong answer!\nGame Over.");
                return;
            }

            // Game still running
            if (game.CurrentQuestion != null)
            {
                ShowQuestion();
            }
            else
            {
                DisableAnswerButtons();
                MessageBox.Show("🏆 CONGRATULATIONS!\nYOU ARE A MILLIONAIRE!");
            }
        }

        // ===== UI HELPERS =====
        private void EnableAnswerButtons()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
        }

        private void DisableAnswerButtons()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
    }
}
