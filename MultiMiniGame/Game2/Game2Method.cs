using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace MultiMiniGame.Game2
{
    public class Game2Method
    {
        // ===== MODEL =====
        public class Question
        {
            public int Level { get; set; }
            public string QuestionText { get; set; }
            public string[] Answers { get; set; }
            public int CorrectIndex { get; set; }
        }

        // ===== DATA =====
        private List<Question> allQuestions;
        private List<Question> level1All, level2All, level3All;

        // ===== GAME STATE =====
        private List<Question> currentQuestions;
        private int currentLevel;
        private int questionIndex;

        // ===== PUBLIC ACCESS =====
        public Question CurrentQuestion => currentQuestions[questionIndex];
        public int CurrentLevel => currentLevel;

        // ===== LOAD JSON =====
        public void LoadQuestions()
        {
            string path = Path.Combine(Application.StartupPath, "questions.json");
            string json = File.ReadAllText(path);

            allQuestions = JsonSerializer.Deserialize<List<Question>>(json);

            level1All = allQuestions.Where(q => q.Level == 1).ToList();
            level2All = allQuestions.Where(q => q.Level == 2).ToList();
            level3All = allQuestions.Where(q => q.Level == 3).ToList();
        }


        // ===== START GAME =====
        public void StartGame()
        {
            currentLevel = 1;
            questionIndex = 0;
            currentQuestions = PickRandom(level1All, 5);
        }

        // ===== ANSWER CHECK =====
        public bool Answer(int selectedIndex)
        {
            if (selectedIndex == CurrentQuestion.CorrectIndex)
            {
                questionIndex++;

                if (questionIndex >= currentQuestions.Count)
                    return NextLevel();

                return true;
            }

            return false;
        }

        // ===== NEXT LEVEL =====
        private bool NextLevel()
        {
            questionIndex = 0;

            if (currentLevel == 1)
            {
                currentLevel = 2;
                currentQuestions = PickRandom(level2All, 5);
                return true;
            }
            else if (currentLevel == 2)
            {
                currentLevel = 3;
                currentQuestions = PickRandom(level3All, 5);
                return true;
            }

            // Game finished
            return false;
        }

        // ===== RANDOM PICK =====
        private List<Question> PickRandom(List<Question> source, int count)
        {
            Random rnd = new Random();
            return source.OrderBy(q => rnd.Next()).Take(count).ToList();
        }
    }
}
