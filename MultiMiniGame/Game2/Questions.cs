using System.Collections.Generic;

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
            // ================= LEVEL 1 (Easy) =================
            new Question {
                Level = 1,
                QuestionText = "រាជធានីនៃប្រទេសកម្ពុជាគឺអ្វី?",
                Answers = new[] { "ភ្នំពេញ", "សៀមរាប", "បាត់ដំបង", "កំពត" },
                CorrectIndex = 0
            },
            new Question {
                Level = 1,
                QuestionText = "ទង់ជាតិខ្មែរមានពណ៌ប៉ុន្មាន?",
                Answers = new[] { "2", "3", "4", "5" },
                CorrectIndex = 1
            },
            new Question {
                Level = 1,
                QuestionText = "អង្គរវត្តស្ថិតនៅខេត្តណា?",
                Answers = new[] { "ភ្នំពេញ", "សៀមរាប", "បាត់ដំបង", "កំពង់ធំ" },
                CorrectIndex = 1
            },
            new Question {
                Level = 1,
                QuestionText = "ភាសាផ្លូវការរបស់កម្ពុជាគឺ?",
                Answers = new[] { "អង់គ្លេស", "បារាំង", "ខ្មែរ", "ថៃ" },
                CorrectIndex = 2
            },
            new Question {
                Level = 1,
                QuestionText = "1 + 1 = ?",
                Answers = new[] { "1", "2", "3", "4" },
                CorrectIndex = 1
            },
            new Question {
                Level = 1,
                QuestionText = "ថ្ងៃណាជាទិវាជាតិខ្មែរ?",
                Answers = new[] { "៩ វិច្ឆិកា", "៧ មករា", "១៥ មេសា", "១ មិថុនា" },
                CorrectIndex = 0
            },
            new Question {
                Level = 1,
                QuestionText = "កម្ពុជាស្ថិតនៅទ្វីបណា?",
                Answers = new[] { "អឺរ៉ុប", "អាហ្វ្រិក", "អាស៊ី", "អាមេរិក" },
                CorrectIndex = 2
            },
            new Question {
                Level = 1,
                QuestionText = "កុំព្យូទ័រជាអ្វី?",
                Answers = new[] { "សត្វ", "ឧបករណ៍អេឡិចត្រូនិច", "អគារ", "រថយន្ត" },
                CorrectIndex = 1
            },
            new Question {
                Level = 1,
                QuestionText = "Mouse ប្រើសម្រាប់?",
                Answers = new[] { "សរសេរ", "បោះពុម្ព", "ចុច និងបញ្ជា", "ស្តាប់តន្ត្រី" },
                CorrectIndex = 2
            },
            new Question {
                Level = 1,
                QuestionText = "Keyboard មានប៊ូតុងហៅថា?",
                Answers = new[] { "Key", "Button", "Click", "Screen" },
                CorrectIndex = 0
            },

            // ================= LEVEL 2 (Medium) =================
            new Question {
                Level = 2,
                QuestionText = "C# ជាភាសាប្រើសម្រាប់?",
                Answers = new[] { "រចនាផ្ទះ", "សរសេរកម្មវិធី", "គូរគំនូរ", "ថតរូប" },
                CorrectIndex = 1
            },
            new Question {
                Level = 2,
                QuestionText = ".NET គឺអ្វី?",
                Answers = new[] { "ហ្គេម", "Framework", "Browser", "OS" },
                CorrectIndex = 1
            },
            new Question {
                Level = 2,
                QuestionText = "Visual Studio ប្រើសម្រាប់?",
                Answers = new[] { "លេងហ្គេម", "សរសេរកូដ", "មើលវីដេអូ", "រចនាសម្លៀកបំពាក់" },
                CorrectIndex = 1
            },
            new Question {
                Level = 2,
                QuestionText = "int ក្នុង C# ប្រើសម្រាប់?",
                Answers = new[] { "អក្សរ", "លេខគត់", "រូបភាព", "សំឡេង" },
                CorrectIndex = 1
            },
            new Question {
                Level = 2,
                QuestionText = "string ក្នុង C# មានន័យថា?",
                Answers = new[] { "លេខ", "អក្សរ", "Boolean", "Date" },
                CorrectIndex = 1
            },
            new Question {
                Level = 2,
                QuestionText = "if statement ប្រើសម្រាប់?",
                Answers = new[] { "ធ្វើ loop", "សម្រេចចិត្ត", "បង្ហាញ UI", "រក error" },
                CorrectIndex = 1
            },
            new Question {
                Level = 2,
                QuestionText = "Windows Form គឺ?",
                Answers = new[] { "Database", "UI Application", "Game Engine", "OS" },
                CorrectIndex = 1
            },
            new Question {
                Level = 2,
                QuestionText = "Button ក្នុង Form ជា?",
                Answers = new[] { "Variable", "Control", "Class", "Method" },
                CorrectIndex = 1
            },
            new Question {
                Level = 2,
                QuestionText = "Click event កើតឡើងពេលណា?",
                Answers = new[] { "បើក App", "បិទ App", "ចុច Button", "Load Form" },
                CorrectIndex = 2
            },
            new Question {
                Level = 2,
                QuestionText = "C# ជាភាសា?",
                Answers = new[] { "Low-level", "Markup", "Object-Oriented", "Assembly" },
                CorrectIndex = 2
            },

            // ================= LEVEL 3 (Hard) =================
            new Question {
                Level = 3,
                QuestionText = "OOP មានគោលការណ៍ប៉ុន្មាន?",
                Answers = new[] { "2", "3", "4", "5" },
                CorrectIndex = 2
            },
            new Question {
                Level = 3,
                QuestionText = "Class និង Object ខុសគ្នាយ៉ាងដូចម្តេច?",
                Answers = new[] { "ដូចគ្នា", "Class ជាគំរូ Object ជាវត្ថុ", "Object ធំជាង", "Class ប្រើ runtime" },
                CorrectIndex = 1
            },
            new Question {
                Level = 3,
                QuestionText = "Encapsulation មានន័យថា?",
                Answers = new[] { "បែងចែក", "លាក់ទិន្នន័យ", "Loop", "Inheritance" },
                CorrectIndex = 1
            },
            new Question {
                Level = 3,
                QuestionText = "List<T> ប្រើសម្រាប់?",
                Answers = new[] { "តម្លៃតែមួយ", "ទិន្នន័យច្រើន", "UI", "File" },
                CorrectIndex = 1
            },
            new Question {
                Level = 3,
                QuestionText = "private keyword មានន័យថា?",
                Answers = new[] { "គេមើលបានគ្រប់ទី", "ប្រើបានតែក្នុង class", "Static", "Global" },
                CorrectIndex = 1
            },
            new Question {
                Level = 3,
                QuestionText = "Method return type ប្រាប់អ្វី?",
                Answers = new[] { "ឈ្មោះ method", "តម្លៃត្រឡប់", "Parameter", "Loop" },
                CorrectIndex = 1
            },
            new Question {
                Level = 3,
                QuestionText = "null មានន័យថា?",
                Answers = new[] { "0", "Empty string", "គ្មានតម្លៃ", "false" },
                CorrectIndex = 2
            },
            new Question {
                Level = 3,
                QuestionText = "Exception កើតឡើងពេលណា?",
                Answers = new[] { "Code ត្រឹមត្រូវ", "Runtime error", "Compile success", "UI load" },
                CorrectIndex = 1
            },
            new Question {
                Level = 3,
                QuestionText = "try-catch ប្រើសម្រាប់?",
                Answers = new[] { "Loop", "Handle error", "UI", "Array" },
                CorrectIndex = 1
            },
            new Question {
                Level = 3,
                QuestionText = "Framework ជាអ្វី?",
                Answers = new[] { "Hardware", "Library + Structure", "OS", "Database" },
                CorrectIndex = 1
            }
        };
    }
}
