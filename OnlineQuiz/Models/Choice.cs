﻿namespace OnlineQuiz.Models
{
    public class Choice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
