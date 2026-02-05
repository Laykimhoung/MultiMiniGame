using System.Collections.Generic;

namespace MultiMiniGame.Game2
{
    public class Question
    {
        public int Id { get; set; }
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
                Id = 1,
                Level = 1,
                QuestionText = "រាជធានីនៃប្រទេសកម្ពុជាគឺអ្វី?",
                Answers = new[] { "ភ្នំពេញ", "សៀមរាប", "បាត់ដំបង", "កំពត" },
                CorrectIndex = 0
            },
            new Question {
                Id = 2,
                Level = 1,
                QuestionText = "ទង់ជាតិខ្មែរមានពណ៌ប៉ុន្មាន?",
                Answers = new[] { "2", "3", "4", "5" },
                CorrectIndex = 1
            },
            new Question {
                Id = 3,
                Level = 1,
                QuestionText = "អង្គរវត្តស្ថិតនៅខេត្តណា?",
                Answers = new[] { "ភ្នំពេញ", "បាត់ដំបង", "សៀមរាប", "កំពង់ធំ" },
                CorrectIndex = 2
            },
            new Question {
                Id = 4,
                Level = 1,
                QuestionText = "អង្គរវត្តត្រូវបានសាងសង់ក្នុងរាជសម័យណា?",
                Answers = new[] { "ជ័យវរ្ម័នទី៧", "ជ័យវរ្ម័នទី៥", "ឥន្ទ្រវរ្ម័នទី១","សូរ្យវរ្ម័នទី២" },
                CorrectIndex = 3
            },
            new Question {
                Id = 5,
                Level = 1,
                QuestionText = "ភ្នំខ្ពស់បំផុតនៅកម្ពុជាគឺ?",
                Answers = new[] { "ភ្នំអរ៉ាល់", "ភ្នំបូកគោ", "ភ្នំគូលែន", "ភ្នំដងរែក" },
                CorrectIndex = 0
            },
            new Question {
                Id = 6,
                Level = 1,
                QuestionText = "បុណ្យចូលឆ្នាំខ្មែរ តែងតែធ្វើឡើងនៅខែ?",
                Answers = new[] { "មករា", "មេសា", "មិថុនា", "ធ្នូ" },
                CorrectIndex = 1
            },
            new Question {
                Id = 7,
                Level = 1,
                QuestionText = "ប្រទេសកម្ពុជាស្ថិតនៅតំបន់អាស៊ីអ្វី?",
                Answers = new[] { "អាស៊ីកណ្តាល", "អាស៊ីខាងត្បូង", "អាស៊ីអាគ្នេយ៍", "អាស៊ីខាងកើត" },
                CorrectIndex = 2
            },
            new Question {
                Id = 8,
                Level = 1,
                QuestionText = "ប្រជាជនកម្ពុជាភាគច្រើនគោរពសាសនាអ្វី?",
                Answers = new[] { "គ្រីស្ទសាសនា", "អ៊ីស្លាម", "ហិណ្ឌូ" ,"ពុទ្ធសាសនា"},
                CorrectIndex = 3
            },
            new Question {
                Id = 9,
                Level = 1,
                QuestionText = "អក្សរខ្មែរ មានព្យញ្ជនៈប៉ុន្មាន?",
                Answers = new[] { "31", "32", "33", "34" },
                CorrectIndex = 2
            },
            new Question {
                Id = 10,
                Level = 1,
                QuestionText = "កីឡាជាតិរបស់កម្ពុជាគឺ?",
                Answers = new[] { "បាល់ទាត់", "ប្រដាល់គុនខ្មែរ", "វ៉ូឡីបាល់", "បាល់បោះ" },
                CorrectIndex = 1
            },

            // ================= LEVEL 2 (Medium) =================
            new Question {
                Id = 11,
                Level = 2,
                QuestionText = "តើមួយណាខាងក្រោមនេះ មិនមែនជា Programming Language?",
                Answers = new[] { "HTML","Python", "C#", "C++" },
                CorrectIndex = 0
            },
            new Question {
                Id = 12,
                Level = 2,
                QuestionText = ".NET គឺជាអ្វី?",
                Answers = new[] { "Programming Language", "Framework", "Browser", "OS" },
                CorrectIndex = 1
            },
            new Question {
                Id = 13,
                Level = 2,
                QuestionText = "តើមួយណាខាងក្រោមនេះ ដែលជា backend framework?",
                Answers = new[] { "Vue", "jQuery", "Django", "Bootstrap" },
                CorrectIndex = 2
            },
            new Question {
                Id = 14,
                Level = 2,
                QuestionText = "Compiler មានតួនាទីអ្វី?",
                Answers = new[] { "រត់ UI", "រក Bug","គ្រប់គ្រង Memory", "បកប្រែកូដទៅ Machine Code",},
                CorrectIndex = 3
            },
            new Question {
                Id = 15,
                Level = 2,
                QuestionText = "Framework ជួយអ្វីដល់ Programmer?",
                Answers = new[] { "កាត់បន្ថយការសរសេរកូដថ្មី", "Run OS", "Design Hardware", "ផ្ទុក File" },
                CorrectIndex = 0
            },
            new Question {
                Id = 16,
                Level = 2,
                QuestionText = "តើមួយណាខាងក្រោមនេះ មិនមែនជា  database?",
                Answers = new[] { "MongoDB", "Kotlin", "Oracle", "PostgreSQL" },
                CorrectIndex = 1
            },
            new Question {
                Id = 17,
                Level = 2,
                QuestionText = "Windows Form គឺជាធ្វី?",
                Answers = new[] { "Database", "Game Engine", "UI Application", "OS" },
                CorrectIndex = 2
            },
            new Question {
                Id = 18,
                Level = 2,
                QuestionText = "តើមួយណាខាងក្រោមនេះ ដែលជា frontend framework?",
                Answers = new[] { "Node.js", "Django", "Laravel", "Angular" },
                CorrectIndex = 3
            },
            new Question {
                Id = 19,
                Level = 2,
                QuestionText = "Bit និង Byte មានទំនាក់ទំនងយ៉ាងដូចម្តេច?",
                Answers = new[] { "1 Byte = 8 Bits", "1 Bit = 8 Bytes", "1 Bit = 2 Bytes", "1 Byte = 2 Bits" },
                CorrectIndex = 0
            },
            new Question {
                Id = 20,
                Level = 2,
                QuestionText = "C# ជាភាសា?",
                Answers = new[] { "Low-level", "Markup", "Object-Oriented", "High-level" },
                CorrectIndex = 2
            },

            // ================= LEVEL 3 (Hard) =================
            new Question {
                Id = 21,
                Level = 3,
                QuestionText = "OOP ត្រូវបានបង្កើតឡើងដើម្បីដោះស្រាយបញ្ហាអ្វី?",
                Answers = new[] { "ការគ្រប់គ្រង code ស្មុគស្មាញ", "Speed", "Memory Leak","Syntax error"},
                CorrectIndex = 0
            },
            new Question {
                Id = 22,
                Level = 3,
                QuestionText = "Encapsulation មានន័យថា?",
                Answers = new[] { "បែងចែក", "លាក់ទិន្នន័យ", "Loop", "Inheritance" },
                CorrectIndex = 1
            },
            new Question {
                Id = 23,
                Level = 3,
                QuestionText = "Which one is NoSQL database?",
                Answers = new[] { "MySQL", "PostgreSQL", "MongoDB", "Oracle" },
                CorrectIndex = 2
            },
            new Question {
                Id = 24,
                Level = 3,
                QuestionText = "Primary Key មានតួនាទីអ្វីក្នុង Table?",
                Answers = new[] {"អនុញ្ញាតឲ្យស្ទួន","រក្សាទុកអក្សរ","ភ្ជាប់ Server","កំណត់អត្តសញ្ញាណកំណត់ត្រា"},
                CorrectIndex = 3
            },
            new Question {
                Id = 25,
                Level = 3,
                QuestionText = "Data Structure មួយណាសមស្របសម្រាប់ Undo / Redo?",
                Answers = new[] { "Stack", "Queue", "Array", "Tree" },
                CorrectIndex = 0
            },
            new Question {
                Id = 26,
                Level = 3,
                QuestionText = "Linked List ខុសពី Array ត្រង់ចំណុចសំខាន់ណា?",
                Answers = new[] { "មានទំហំថេរ", "មានទំហំបត់បែនបាន", "Memory តភ្ជាប់ជាប់គ្នា","ចូលដំណើរការលឿនជាង"},
                CorrectIndex = 1
            },
            new Question {
                Id = 27,
                Level = 3,
                QuestionText = "Polymorphism មានន័យថា?",
                Answers = new[] {  "បង្កើត Class តែមួយ", "បង្កើត​ Class ច្រើន", "Method ច្រើនទម្រង់", "Method តែមួយទម្រង់" },
                CorrectIndex = 2
            },
            new Question {
                Id = 28,
                Level = 3,
                QuestionText = "Inheritance ប្រើសម្រាប់អ្វី?",
                Answers = new[] { "Repeat code", "Show class", "Hide data", "Reuse code" },
                CorrectIndex = 3
            },
            new Question {
                Id = 29,
                Level = 3,
                QuestionText = "Overflow Error កើតឡើងពេល?",
                Answers = new[] { "Variable តូចជាងតម្លៃ","Divide by zero","Syntax error","Missing library"},
                CorrectIndex = 0
            },
            new Question {
                Id = 30,
                Level = 3,
                QuestionText = "Syntax Error កើតឡើងពេលណា?",
                Answers = new[] { "Runtime", "Compile", "Design", "Deploy" },
                CorrectIndex = 1
            }
        };
    }
}
