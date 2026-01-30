using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MultiMiniGame.Game2;

namespace MultiMiniGame.Game2
{
    public class Game2Logic
    {
        private List<Question> currentQuestions;
        private int currentIndex = 0;

        public void LoadLevel(int level)
        {
            Random rnd = new Random();

            currentQuestions = QuestionBank.AllQuestions
                .Where(q => q.Level == level)
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

        public bool CheckAnswer(int selectedIndex)
        {
            bool correct = currentQuestions[currentIndex].CorrectIndex == selectedIndex;
            currentIndex++;
            return correct;
        }

        public bool IsLevelFinished()
        {
            return currentIndex >= currentQuestions.Count;
        }
    }
}
