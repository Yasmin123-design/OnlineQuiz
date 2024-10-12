using OnlineQuiz.Models;

namespace OnlineQuiz.ViewModel
{
    public class QuestionsWithChoices
    {
        public List<Question> Questions { get; set; }
        public List<Choice> Choices { get; set; }
    }
}
