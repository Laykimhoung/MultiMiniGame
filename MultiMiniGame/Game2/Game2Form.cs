using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static MultiMiniGame.Game2.Game2Logic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace MultiMiniGame.Game2
{
    public partial class Game2Form : Form
    {
        Game2Logic game = new Game2Logic();
        private List<System.Windows.Forms.Label> questionLadder;
        private int[] moneyTable =
        {
            10000, 20000, 30000, 50000,
            100000, 200000, 400000, 800000, 1600000,
            3200000, 6400000, 12500000, 25000000, 50000000, 100000000
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

            lbTotalMoney.Parent = picBackGround;
            lbTotalMoney.BackColor = Color.Transparent;

            lbTimer.Parent = picBackGround;
            lbTimer.BackColor = Color.Transparent;

            UnVisible();
            btnLost.Visible = false;
            roundTimer.Stop();
        }
        // ================= INIT =================
        private void InitGame()
        {

            game = new Game2Logic();

            questionLadder = new List<System.Windows.Forms.Label>
            {
                lbR1, lbR2, lbR3, lbR4, lbR5,
                lbR6, lbR7, lbR8, lbR9, lbR10,
                lbR11, lbR12, lbR13, lbR14, lbR15
            };

            InitMoneyLadder();
            btnNextRound.Visible = false;
            btnStop.Visible = false;
            lbShow.Visible = false;

            StartGame();
        }
        private void InitMoneyLadder()
        {
            for (int i = 0; i < questionLadder.Count; i++)
            {
                questionLadder[i].Text = $"{moneyTable[i]:N0}៛";
            }
        }


        // ================= GAME FLOW =================
        private void StartGame()
        {
            game.StartGame();
            UpdateMoney();
            HighlightLadder();
            ShowQuestion();
            StartTimer();
            CanVisible();
            lbShow.Visible = false;
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
                    btnNextRound.Visible = false;
                    btnLost.Visible = true;
                    break;

                case GameState.GameWon:
                    lbShow.Text = " YOU WON 1,000,000!";
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

            if (game.HasNextQuestion())
            {
                game.NextQuestion();
            }
            else
            {
                game.NextLevel();
            }

            UpdateMoney();
            HighlightLadder();
            ShowQuestion();
            StartTimer();
        }
        // ================= TIMER =================
        int timeLeft;
        private void StartTimer()
        {
            timeLeft = 60;
            lbTimer.Text = timeLeft.ToString();
            roundTimer.Start();
        }
        private void roundTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            lbTimer.Text = timeLeft.ToString();

            if (timeLeft <= 0)
            {
                roundTimer.Stop();
                lbShow.Text = "Time's up!";
                lbShow.Visible = true;
                DisableAnswerButtons();
            }
        }
        // ================= UI HELPERS =================
        private void UpdateMoney()
        {
            int earned = game.CurrentRound > 1
         ? moneyTable[game.CurrentRound - 2]
         : 0;

            lbTotalMoney.Text = $"{earned:N0}៛";
        }

        private void HighlightLadder()
        {
            foreach (var lb in questionLadder)
            {
                lb.Parent = picBackGround;
                lb.BackColor = Color.Transparent;
                lb.ForeColor = Color.White;
            }

            int index = game.CurrentRound - 1;

            if (index >= 0 && index < questionLadder.Count)
                questionLadder[index].ForeColor = Color.Gold;
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
        private void ResetButtons()
        {
            EnableAnswerButtons();
            btnA.VisualState = ButtonVisualState.Normal;
            btnB.VisualState = ButtonVisualState.Normal;
            btnC.VisualState = ButtonVisualState.Normal;
            btnD.VisualState = ButtonVisualState.Normal;
        }
        private void UnVisible()
        {
            btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = false;
            btn5050.Visible = btnCall.Visible = false;
            lbR1.Visible = lbR2.Visible = lbR3.Visible = lbR4.Visible = lbR5.Visible = lbR6.Visible = lbR7.Visible = lbR8.Visible = lbR9.Visible = lbR10.Visible = lbR11.Visible = lbR12.Visible = lbR13.Visible = lbR14.Visible = lbR15.Visible = false;
            lbShow.Visible = lbTotalMoney.Visible = lbTimer.Visible = lbQuestion.Visible = false;
            panelQuestion.Visible = false;
        }
        private void CanVisible()
        {
            btnA.Visible = btnB.Visible = btnC.Visible = btnD.Visible = true;
            btn5050.Visible = btnCall.Visible = true;
            lbR1.Visible = lbR2.Visible = lbR3.Visible = lbR4.Visible = lbR5.Visible = lbR6.Visible = lbR7.Visible = lbR8.Visible = lbR9.Visible = lbR10.Visible = lbR11.Visible = lbR12.Visible = lbR13.Visible = lbR14.Visible = lbR15.Visible = true;
            lbShow.Visible = lbTotalMoney.Visible = lbTimer.Visible = lbQuestion.Visible = true;
            panelQuestion.Visible = true;
        }
        private void DisableAnswerButtons()
        {
            btnA.Enabled = btnB.Enabled = btnC.Enabled = btnD.Enabled = false;
        }

        private void EnableAnswerButtons()
        {
            btnA.Enabled = btnB.Enabled = btnC.Enabled = btnD.Enabled = true;
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            var remove = game.GetFiftyFifty();

            foreach (var i in remove)
                GetButton(i).Visible = false;

            btn5050.Enabled = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            mainform.Show();
        }

        private void btnLost_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

