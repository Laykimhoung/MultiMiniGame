using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace MultiMiniGame.Game2
{
    public class Question
    {
        public int level { get; set; }
        public string questionText { get; set; }
        public List<string> answers { get; set; }
        public int correctIndex { get; set; }
    }
    public class Game2Method
    {
        public List<Question> AllQuestions;
        public List<Question> CurrentQuestions;

        public int CurrentLevel = 1;
        public int QuestionIndex = 0;
        public int Round = 1;

        Random rand = new Random();

        public void LoadQuestions()
        {
            string json = File.ReadAllText("Game2/questions.json");
            AllQuestions = JsonSerializer.Deserialize<List<Question>>(json);
        }

        public void LoadLevel(int level)
        {
            CurrentLevel = level;
            QuestionIndex = 0;

            CurrentQuestions = AllQuestions
                .Where(q => q.level == level)
                .OrderBy(q => rand.Next())
                .Take(5)
                .ToList();
        }

        public Question GetCurrentQuestion()
        {
            return CurrentQuestions[QuestionIndex];
        }

        public bool CheckAnswer(int selectedIndex)
        {
            var q = GetCurrentQuestion();

            if (selectedIndex == q.correctIndex)
            {
                QuestionIndex++;
                Round++;

                if (Round == 6) LoadLevel(2);
                if (Round == 11) LoadLevel(3);

                return true;
            }

            return false;
        }
    }
}
