using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Third_Task
{
    public class QuestionData
    {
        public int Number { get; set; } = 1;
        public string Question { get; set; } = "PI =";
        public string[] Answers { get; set; } = { "3,45","3,4","3,14" };
        [JsonPropertyName("correct_answer")]
        public int CorrectAnswer { get; set; } = 2;

        public QuestionData(int number,string quest,string[] answer,int corr_answer)
        {
            Number = number;
            Question = quest;
            Answers = answer;
            CorrectAnswer = corr_answer;
        }
    }
    public class Module
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int Questions { get; set; }
        public DateTime Revision { get; set; }
    }

    public class ModuleData
    {
        public Module Module { get; set; }
        public QuestionData[] Questions { get; set; }
    }
}
