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
                QuestionText = "តើរាជធានីនៃប្រទេសកម្ពុជាស្ថិតនៅឯណា?",
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
                QuestionText = "តើអង្គរវត្តស្ថិតនៅខេត្តណា?",
                Answers = new[] { "ភ្នំពេញ", "បាត់ដំបង", "សៀមរាប", "កំពង់ធំ" },
                CorrectIndex = 2
            },
            new Question {
                Id = 4,
                Level = 1,
                QuestionText = "តើអង្គរវត្តត្រូវបានសាងសង់ក្នុងរាជសម័យអង្គណា?",
                Answers = new[] { "ជ័យវរ្ម័នទី៧", "ជ័យវរ្ម័នទី៥", "ឥន្ទ្រវរ្ម័នទី១","សូរ្យវរ្ម័នទី២" },
                CorrectIndex = 3
            },
            new Question {
                Id = 5,
                Level = 1,
                QuestionText = "តើភ្នំខ្ពស់បំផុតនៅកម្ពុជាជាភ្នំអ្វី?",
                Answers = new[] { "ភ្នំឱរ៉ាល់", "ភ្នំបូកគោ", "ភ្នំគូលែន", "ភ្នំដងរែក" },
                CorrectIndex = 0
            },
            new Question {
                Id = 6,
                Level = 1,
                QuestionText = "តើបុណ្យចូលឆ្នាំខ្មែរ តែងតែធ្វើឡើងនៅខែណា?",
                Answers = new[] { "មករា", "មេសា", "មិថុនា", "ធ្នូ" },
                CorrectIndex = 1
            },
            new Question {
                Id = 7,
                Level = 1,
                QuestionText = "តើប្រទេសកម្ពុជាស្ថិតនៅតំបន់អាស៊ីអ្វី?",
                Answers = new[] { "អាស៊ីកណ្តាល", "អាស៊ីខាងត្បូង", "អាស៊ីអាគ្នេយ៍", "អាស៊ីខាងកើត" },
                CorrectIndex = 2
            },
            new Question {
                Id = 8,
                Level = 1,
                QuestionText = "តើប្រជាជនកម្ពុជាភាគច្រើនគោរពសាសនាអ្វី?",
                Answers = new[] { "គ្រីស្ទសាសនា", "អ៊ីស្លាម", "ហិណ្ឌូ" ,"ពុទ្ធសាសនា"},
                CorrectIndex = 3
            },
            new Question {
                Id = 9,
                Level = 1,
                QuestionText = "តើអក្សរខ្មែរ មានព្យញ្ជនៈប៉ុន្មានតួ?",
                Answers = new[] { "31", "32", "33", "34" },
                CorrectIndex = 2
            },
            new Question {
                Id = 10,
                Level = 1,
                QuestionText = "តើកីឡាជាតិរបស់កម្ពុជាគឺជាកីឡាអ្វី?",
                Answers = new[] { "បាល់ទាត់", "ប្រដាល់គុនខ្មែរ", "បាល់ទះ", "បាល់បោះ" },
                CorrectIndex = 1
            },

            // ================= LEVEL 2 (Medium) =================
            new Question {
                Id = 11,
                Level = 2,
                QuestionText = "តើមួយណាខាងក្រោមនេះបង្ហាញពីប្រតិកម្មគីមី?",
                Answers = new[] { "ដែកជ្រាបច្រេះ", "ទឹកកករលាយ", "ទឹករំពុះ", "កញ្ចក់បែក"},
                CorrectIndex = 0
            },
            new Question {
                Id = 12,
                Level = 2,
                QuestionText = "UNTAC មានតួនាទីអ្វីនៅកម្ពុជា?",
                Answers = new[] {"បង្កើតសង្គ្រាម", "រៀបចំការបោះឆ្នោត", "គ្រប់គ្រងធនធាន", "បង្កើតអាណានិគម"},
                CorrectIndex = 1
            },
            new Question {
                Id = 13,
                Level = 2,
                QuestionText = "បើ x² = 16,នោះ x​ =​ ?",
                Answers = new[]{"4", "-4", "±4", "0" },
                CorrectIndex = 2
            },
            new Question {
                Id = 14,
                Level = 2,
                QuestionText = "បើ pH = 3 តើសារធាតុនោះមានលក្ខណៈយ៉ាងដូចម្តេច?",
                Answers = new[] { "បាសខ្សោយ", "បាសខ្លាំង", "អាស៊ីតខ្សោយ", "អាស៊ីតខ្លាំង"},
                CorrectIndex = 3
            },
            new Question {
                Id = 15,
                Level = 2,
                QuestionText = "តើសម័យអង្គររីកចម្រើនដោយសារអ្វីសំខាន់?",
                Answers = new[] { "ប្រព័ន្ធទឹក និងកសិកម្ម", "កងទ័ព", "អាកាសធាតុ", "គ្មានសង្គ្រាម" },
                CorrectIndex = 0
            },
            new Question {
                Id = 16,
                Level = 2,
                QuestionText = "បើអាតូមបាត់បង់អេឡិចត្រុង វានឹងក្លាយជា?",
                Answers = new[] {"អ៊ីយ៉ុងអវិជ្ជមាន", "អ៊ីយ៉ុងវិជ្ជមាន", "អាតូមធម្មតា", "ម៉ូលេគុល"},
                CorrectIndex = 1
            },
            new Question {
                Id = 17,
                Level = 2,
                QuestionText = "កម្ពុជាចូលជាសមាជិកអាស៊ាននៅឆ្នាំណា?",
                Answers = new[] {"1995","1997","1999","2001"},
                CorrectIndex = 2
            },
            new Question {
                Id = 18,
                Level = 2,
                QuestionText = "សង្គ្រាមលោកលើកទី១ចាប់ផ្តើមនៅឆ្នាំណា?",
                Answers = new[] {"1920","1918","1916","1914"},
                CorrectIndex = 3
            },
            new Question {
                Id = 19,
                Level = 2,
                QuestionText = "សង្គ្រាមត្រជាក់ចាប់ផ្តើមនៅឆ្នាំណា?",
                Answers = new[] {"1947","1955","1960","1963"},
                CorrectIndex = 0
            },
            new Question {
                Id = 20,
                Level = 2,
                QuestionText = "កម្ពុជាមានរដ្ឋធម្មនុញ្ញដំបូងនៅឆ្នាំណា?",
                Answers = new[] { "1924", "1947", "1965", "1993" },
                CorrectIndex = 1
            },

            // ================= LEVEL 3 (Hard) =================
            new Question {
                Id = 21,
                Level = 3,
                QuestionText = "ខែមេសានៃគ្រឹស្តសករាជ២០១៦ត្រូវនឹងឆ្នាំពុទ្ធសករាជ៖",
                Answers = new[] { "២៥៥៩", "២៥៦០", "២៥៦១","២៥៦២"},
                CorrectIndex = 0
            },
            new Question {
                Id = 22,
                Level = 3,
                QuestionText = "នំអន្សមយក្សនៅកម្ពុជាត្រូវបានកត់ត្រាក្នុងសៀវភៅកំណត់ត្រាពិភពលោកនៅឆ្នាំ៖",
                Answers = new[] { "2014", "2015", "2016", "2013" },
                CorrectIndex = 1
            },
            new Question {
                Id = 23,
                Level = 3,
                QuestionText = "តើខែកញ្ញាមានប៉ុន្មានថ្ងៃ?",
                Answers = new[] { "28", "29", "30", "31" },
                CorrectIndex = 2
            },
            new Question {
                Id = 24,
                Level = 3,
                QuestionText = "តើភពទី៥ ក្នុងប្រព័ន្ធព្រះអាទិត្យ ជាភពអ្វី?",
                Answers = new[] {"ភពផែនដី","ភពអង្គារ","ភពពុធ","ភពព្រហស្បតិ៍"},
                CorrectIndex = 3
            },
            new Question {
                Id = 25,
                Level = 3,
                QuestionText = "ទន្លេមេគង្គហូរកាត់ប្រទេសណាខ្លះ?",
                Answers = new[] { "ចិន ភូមា ឡាវ​ ចោរសៀម កម្ពុជា វៀតណាម", "ចិន ម៉ាឡេស៊ី ឡាវ ចោរសៀម កម្ពុជា វៀតណាម", "ចិន ម៉ុងហ្គោលី ភូមា ឡាវ ចោរសៀម កម្ពុជា វៀតណាម", "ឡាវ ចោរសៀម កម្ពុជា វៀតណាម" },
                CorrectIndex = 0
            },
            new Question {
                Id = 26,
                Level = 3,
                QuestionText = "បឹងទន្លេសាប(បឹងធំ + បឹងតូច + វាលភក់)មានទំហំ៖",
                Answers = new[] { "១៦០x៣៤ គម", "១៦០x៣៥ គម", "១៦០x៣៦ គម", "១៦០x៣៧ គម"},
                CorrectIndex = 1
            },
            new Question {
                Id = 27,
                Level = 3,
                QuestionText = "តើស្ថានីយ៍បុរេប្រវត្តិសាស្រ្តខ្មែរសំរោងសែនឋិតនៅក្នុងខេត្តណា?",
                Answers = new[] { "ព្រះវិហារ", "កំពង់ធំ", "កំពង់ឆ្នាំង", "កំពង់ចាម" },
                CorrectIndex = 2
            },
            new Question {
                Id = 28,
                Level = 3,
                QuestionText = "តើស្រៈពេញតួ មានប៉ុន្មានតួ",
                Answers = new[] { "12", "13", "14", "15" },
                CorrectIndex = 3
            },
            new Question {
                Id = 29,
                Level = 3,
                QuestionText = "តើសម្តេចព្រះសង្ឃរាជ ជូនណាតទ្រង់ប្រសូតនៅក្នុងខេត្តណា?",
                Answers = new[] { "កំពុងស្ពី","កណ្ដាល","កំពុងឆ្នាំង","តាកែវ"},
                CorrectIndex = 0
            },
            new Question {
                Id = 30,
                Level = 3,
                QuestionText = "តើប្រាសាទអង្គរវត្តមានប្រវែងបណ្តោយប៉ុន្មានម៉ែត្រ?",
                Answers = new[] { "1000m", "1200m", "1500m", "2000m" },
                CorrectIndex = 2
            }
        };
    }
}
