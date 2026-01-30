using System;
using System.Collections.Generic;
using System.Text;

namespace MultiMiniGame.Game2
{
    public class Question
    {
        public int Level { get; set; }
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectIndex { get; set; }
    }

    public static class QuestionBank
    {
        public static List<Question> AllQuestions = new List<Question>()
        {
            // ===== LEVEL 1 (10 questions) =====
            new Question
            {
                Level = 1,
                QuestionText = "2 + 2 = ?",
                Answers = new[] { "3", "4", "5", "6" },
                CorrectIndex = 1
            },
            new Question
            {
                Level = 1,
                QuestionText = "5 - 3 = ?",
                Answers = new[] { "1", "2", "3", "4" },
                CorrectIndex = 1
            },
            // add until 10 for level 1...

            // ===== LEVEL 2 =====
            new Question
            {
                Level = 2,
                QuestionText = "10 × 2 = ?",
                Answers = new[] { "10", "15", "20", "25" },
                CorrectIndex = 2
            },

            // ===== LEVEL 3 =====
            new Question
            {
                Level = 3,
                QuestionText = "√81 = ?",
                Answers = new[] { "7", "8", "9", "10" },
                CorrectIndex = 2
            }
        };
    }
}
