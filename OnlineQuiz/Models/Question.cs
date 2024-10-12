namespace OnlineQuiz.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CorrectAnswer { get; set; }
        public int CategoryId { get; set; }

        public List<Choice>? Choices { get; set; }
        public Category? Category { get; set; }
    }
}
