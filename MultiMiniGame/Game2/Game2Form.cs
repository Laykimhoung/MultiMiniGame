using MultiMiniGame.Game2;   // <-- namespace where Game2Method lives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static MultiMiniGame.Game2.Game2Method;

namespace MultiMiniGame.Game2
{
    public partial class Game2Form : Form
    {
        Game2Method game;
        public Game2Form()
        {
            InitializeComponent();
            List<Question> allQuestions;
            List<Question> currentQuestions;

            int currentLevel = 1;
            int questionIndex = 0;
            int round = 1; // 1–15
            Random rand = new Random();

            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            btnQuestion.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;

            btnQuestion.Visible = true;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;

            btnQuestion.Enabled = false;

            game = new Game2Method();
            game.LoadQuestions();
            game.LoadLevel(1);

            ShowQuestion();
        }

        void ShowQuestion()
        {
            var q = game.GetCurrentQuestion();

            btnQuestion.Text = q.questionText;
            btnA.Text = "A. " + q.answers[0];
            btnB.Text = "B. " + q.answers[1];
            btnC.Text = "C. " + q.answers[2];
            btnD.Text = "D. " + q.answers[3];
        }

        private void btnA_Click(object sender, EventArgs e) => HandleAnswer(0);
        private void btnB_Click(object sender, EventArgs e) => HandleAnswer(1);
        private void btnC_Click(object sender, EventArgs e) => HandleAnswer(2);
        private void btnD_Click(object sender, EventArgs e) => HandleAnswer(3);

        void HandleAnswer(int index)
        {
            if (!game.CheckAnswer(index))
            {
                MessageBox.Show("Wrong Answer! Game Over!");
                Close();
                return;
            }

            ShowQuestion();
        }

    }
}
