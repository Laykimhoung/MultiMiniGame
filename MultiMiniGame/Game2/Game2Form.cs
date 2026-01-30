using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static MultiMiniGame.Game2.Game2Logic;

namespace MultiMiniGame.Game2
{
    public partial class Game2Form : Form
    {
        Game2Logic game = new Game2Logic();
        int currentLevel = 1;
        int round = 1;
        public Game2Form()
        {
            InitializeComponent();
        }
        private void Game2Form_Load(object sender, EventArgs e)
        {
            panelQuestion.BackgroundImage = Properties.Resources.game2panelQuesion;
            panelQuestion.BackgroundImageLayout = ImageLayout.Stretch;
            panelQuestion.Parent = picBackGround;
            panelQuestion.BackColor = Color.Transparent;

            lbQuestion.Parent = panelQuestion;
            lbQuestion.BackColor = Color.Transparent;
            lbQuestion.ForeColor = Color.White;

            panelQuestion.Visible = false;
            lbQuestion.Visible = false;
            btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = false;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = true;
            panelQuestion.Visible = true;
            lbQuestion.Visible = true;

            LoadLevel();
        }
        private void LoadLevel()
        {
            game.LoadLevel(currentLevel);
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            Question q = game.GetCurrentQuestion();

            if (q == null)
            {
                NextLevel();
                return;
            }

            lbQuestion.Text = q.QuestionText;

            btnA.Text = " A. " + q.Answers[0];
            btnB.Text = " B. " + q.Answers[1];
            btnC.Text = " C. " + q.Answers[2];
            btnD.Text = " D. " + q.Answers[3];
        }

        private void btnA_Click(object sender, EventArgs e) => HandleAnswer(0);
        private void btnB_Click(object sender, EventArgs e) => HandleAnswer(1);
        private void btnC_Click(object sender, EventArgs e) => HandleAnswer(2);
        private void btnD_Click(object sender, EventArgs e) => HandleAnswer(3);

        private void HandleAnswer(int index)
        {
            bool correct = game.CheckAnswer(index);

            if (!correct)
            {
                MessageBox.Show("Wrong answer! Game Over.");
                Close();
                return;
            }

            round++;
            ShowQuestion();
        }

        private void NextLevel()
        {
            currentLevel++;

            if (currentLevel > 3)
            {
                MessageBox.Show(" Congratulations! You are a MILLIONAIRE!");
                Close();
                return;
            }

            MessageBox.Show($"Level {currentLevel} starts!");
            LoadLevel();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            mainform.Show();

        }
    }
}

