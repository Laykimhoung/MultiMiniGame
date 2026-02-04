using MultiMiniGame.Game2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace MultiMiniGame.Game2
{
    public enum GameState
    {
        Playing,
        LevelCompleted,
        GameOver,
        GameWon
    }
    public class Game2Logic
    {
        private List<Question> currentQuestions;
        private HashSet<int> usedQuestionIds = new HashSet<int>();
        private int currentQuestionIndex;
        private int currentLevel;
        private int currentRound;
        public int CurrentRound => currentRound;
        public int CurrentLevel => currentLevel;

        public void StartGame()
        {
            currentLevel = 1;
            currentRound = 1;
            usedQuestionIds.Clear();
            LoadLevel();
        }
        private void LoadLevel()
        {
            Random rnd = new Random();
            // Take 5 UNIQUE questions from 10 per level
            currentQuestions = QuestionBank.AllQuestions
                .Where(q => q.Level == currentLevel && !usedQuestionIds.Contains(q.Id))
                .OrderBy(q => rnd.Next())
                .Take(5)
                .ToList();

            foreach (var q in currentQuestions)
                usedQuestionIds.Add(q.Id);

            currentQuestionIndex = 0;
        }
        public Question GetCurrentQuestion()
        {
            if (currentQuestionIndex >= currentQuestions.Count)
                return null;

            return currentQuestions[currentQuestionIndex];
        }
        public GameState SubmitAnswer(int selectedIndex)
        {
            if (!IsCorrect(selectedIndex))
                return GameState.GameOver;

            currentRound++; // ⭐ THIS IS THE IMPORTANT PART

            if (currentRound <= 15)
            {
                if (HasNextQuestion())
                    return GameState.Playing;

                if (HasNextLevel())
                    return GameState.LevelCompleted;
            }

            return GameState.GameWon;
        }
        public bool IsCorrect(int selectedIndex)
        {
            return GetCurrentQuestion().CorrectIndex == selectedIndex;
        }
        public bool HasNextQuestion()
        {
            return currentQuestionIndex + 1 < currentQuestions.Count;
        }
        public bool HasNextLevel()
        {
            return currentLevel < 15;
        }
        public void NextQuestion()
        {
            currentQuestionIndex++;
        }
        public void NextLevel()
        {
            currentLevel++;
            LoadLevel();
        }
        //50/50
        public int[] GetFiftyFifty()
        {
            Random rnd = new Random();
            var q = GetCurrentQuestion();

            return Enumerable.Range(0, 4)
                .Where(i => i != q.CorrectIndex)
                .OrderBy(i => rnd.Next())
                .Take(2)
                .ToArray();
        }

    }
}
