using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Third_Task
{
    public class QuestionData
    {
        public int Number { get; set; }
        public string Question { get; set; }
        public string[] Answers { get; set; }
        [JsonPropertyName("correct_answer")]
        public int CorrectAnswer { get; set; }
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
