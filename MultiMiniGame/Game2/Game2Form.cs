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
        private List<Label> questionLadder;
        private int[] moneyTable =
        {
            0, 100, 200, 300, 500,
            1000, 2000, 4000, 8000, 16000,
            32000, 64000, 125000, 250000, 500000, 1000000
        };
        public Game2Form()
        {
            InitializeComponent();
            InitGame();
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

            lbShow.Parent = picBackGround;
            lbShow.BackColor = Color.Transparent;

            panelQuestion.Visible = false;
            lbQuestion.Visible = false;
            lbShow.Visible = false;
            btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = false;
        }
        // ================= INIT =================
        private void InitGame()
        {
            game = new Game2Logic();

            questionLadder = new List<Label>
            {
                lbR1, lbR2, lbR3, lbR4, lbR5,
                lbR6, lbR7, lbR8, lbR9, lbR10,
                lbR11, lbR12, lbR13, lbR14, lbR15
            };

            btnNextRound.Visible = false;
            btnStop.Visible = false;
            lbShow.Visible = false;

            StartGame();
        }

        // ================= GAME FLOW =================
        private void StartGame()
        {
            game.StartGame();
            UpdateMoney();
            HighlightLadder();
            ShowQuestion();
            StartTimer();
        }
        private void ShowQuestion()
        {
            var q = game.GetCurrentQuestion();
            lbQuestion.Text = q.QuestionText;

            lbQuestion.Text = q.QuestionText;
            btnA.Text = "  A. " + q.Answers[0];
            btnB.Text = "  B. " + q.Answers[1];
            btnC.Text = "  C. " + q.Answers[2];
            btnD.Text = "  D. " + q.Answers[3];

            ResetButtons();
        }
        // ================= ANSWER =================
        private void HandleAnswer(int index)
        {
            roundTimer.Stop();

            GameState result = game.SubmitAnswer(index);

            var q = game.GetCurrentQuestion();
            var clicked = GetButton(index);
            var correct = GetButton(q.CorrectIndex);

            if (result == GameState.GameOver)
            {
                clicked.VisualState = ButtonVisualState.Wrong;
                correct.VisualState = ButtonVisualState.Correct;
            }
            else
            {
                clicked.VisualState = ButtonVisualState.Correct;
            }

            DisableAnswerButtons();
            btnNextRound.Visible = true;

            switch (result)
            {
                case GameState.Playing:
                    lbShow.Text = "Correct!";
                    break;

                case GameState.LevelCompleted:
                    lbShow.Text = "Level Completed!";
                    btnStop.Visible = true;
                    break;

                case GameState.GameOver:
                    lbShow.Text = "Game Over!";
                    btnNextRound.Enabled = false;
                    break;

                case GameState.GameWon:
                    lbShow.Text = "🎉 YOU WON 1,000,000!";
                    btnNextRound.Enabled = false;
                    break;
            }

            lbShow.Visible = true;
        }
        // ================= NEXT =================
        private void btnNextRound_Click(object sender, EventArgs e)
        {
            btnNextRound.Visible = false;
            btnStop.Visible = false;
            lbShow.Visible = false;

            game.NextQuestion();

            if (!game.HasNextQuestion())
                game.NextLevel();

            UpdateMoney();
            HighlightLadder();
            ShowQuestion();
            StartTimer();
        }
        // ================= TIMER =================
        private void StartTimer()
        {
            roundTimer.Start();
        }

        private void roundTimer_Tick(object sender, EventArgs e)
        {
            roundTimer.Stop();
            lbShow.Text = "⏰ Time's up!";
            lbShow.Visible = true;
            DisableAnswerButtons();
        }
        // ================= UI HELPERS =================
        private void UpdateMoney()
        {
            lbTotalMoney.Text = $"$ {moneyTable[game.CurrentLevel]}";
        }

        private void HighlightLadder()
        {
            foreach (var lb in questionLadder)
                lb.BackColor = System.Drawing.Color.Transparent;

            int index = game.CurrentLevel - 1;
            if (index >= 0 && index < questionLadder.Count)
                questionLadder[index].BackColor = System.Drawing.Color.Gold;
        }
        private void ResetButtons()
        {
            EnableAnswerButtons();

            btnA.VisualState =
            btnB.VisualState =
            btnC.VisualState =
            btnD.VisualState = ButtonVisualState.Normal;
        }

        private void DisableAnswerButtons()
        {
            btnA.Enabled = btnB.Enabled =
            btnC.Enabled = btnD.Enabled = false;
        }

        private void EnableAnswerButtons()
        {
            btnA.Enabled = btnB.Enabled =
            btnC.Enabled = btnD.Enabled = true;
        }

        private btnGame2 GetButton(int index)
        {
            return index switch
            {
                0 => btnA,
                1 => btnB,
                2 => btnC,
                3 => btnD,
                _ => null
            };
        }
        // ================= BUTTON EVENTS =================
        private void btnStart_Click(object sender, EventArgs e)
        {
            panelQuestion.Visible = true;
            lbQuestion.Visible = true;
            btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = true;
            btnStart.Visible = false;
            StartGame();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            mainform.Show();
        }
        private void btnA_Click(object sender, EventArgs e) => HandleAnswer(0);
        private void btnB_Click(object sender, EventArgs e) => HandleAnswer(1);
        private void btnC_Click(object sender, EventArgs e) => HandleAnswer(2);
        private void btnD_Click(object sender, EventArgs e) => HandleAnswer(3);
        private void btnA_MouseHover(object sender, EventArgs e)
        {
            var btn = (btnGame2)sender;
            btn.VisualState = ButtonVisualState.Hover;
            btn.Refresh();
        }
        private void btnA_MouseLeave(object sender, EventArgs e)
        {
            var btn = (btnGame2)sender;
            btn.VisualState = ButtonVisualState.Normal;
            btn.Refresh();
        }
        private void btnB_MouseHover(object sender, EventArgs e)
        {
            var btn = (btnGame2)sender;
            btn.VisualState = ButtonVisualState.Hover;
            btn.Refresh();
        }
        private void btnB_MouseLeave(object sender, EventArgs e)
        {
            var btn = (btnGame2)sender;
            btn.VisualState = ButtonVisualState.Normal;
            btn.Refresh();
        }
        private void btnC_MouseHover(object sender, EventArgs e)
        {
            var btn = (btnGame2)sender;
            btn.VisualState = ButtonVisualState.Hover;
            btn.Refresh();
        }
        private void btnC_MouseLeave(object sender, EventArgs e)
        {
            var btn = (btnGame2)sender;
            btn.VisualState = ButtonVisualState.Normal;
            btn.Refresh();
        }
        private void btnD_MouseHover(object sender, EventArgs e)
        {
            var btn = (btnGame2)sender;
            btn.VisualState = ButtonVisualState.Hover;
            btn.Refresh();
        }
        private void btnD_MouseLeave(object sender, EventArgs e)
        {
            var btn = (btnGame2)sender;
            btn.VisualState = ButtonVisualState.Normal;
            btn.Refresh();
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            var remove = game.GetFiftyFifty();

            foreach (var i in remove)
                GetButton(i).Visible = false;

            btn5050.Enabled = false;
        }
    }
}

