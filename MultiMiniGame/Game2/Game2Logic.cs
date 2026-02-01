using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MultiMiniGame.Game2;

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
        private int currentIndex;
        private int currentLevel = 1;

        public int CurrentLevel => currentLevel;

        public void StartGame()
        {
            currentLevel = 1;
            LoadLevel();
        }

        private void LoadLevel()
        {
            Random rnd = new Random();

            currentQuestions = QuestionBank.AllQuestions
                .Where(q => q.Level == currentLevel)
                .OrderBy(q => rnd.Next())
                .Take(5)
                .ToList();

            currentIndex = 0;
        }

        public Question GetCurrentQuestion()
        {
            if (currentIndex >= currentQuestions.Count)
                return null;

            return currentQuestions[currentIndex];
        }

        public GameState SubmitAnswer(int selectedIndex)
        {
            if (currentQuestions[currentIndex].CorrectIndex != selectedIndex)
                return GameState.GameOver;

            currentIndex++;

            if (currentIndex < currentQuestions.Count)
                return GameState.Playing;

            currentLevel++;

            if (currentLevel > 3)
                return GameState.GameWon;

            LoadLevel();
            return GameState.LevelCompleted;
        }
    }
}
