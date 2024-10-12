using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineQuiz.Models;
using OnlineQuiz.ViewModel;

namespace OnlineQuiz.Controllers
{
    public class QuizController : Controller
    {
        private readonly QuizContext context;
        public QuizController(QuizContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show(int id)
        {
            List<Question> questions = context.Questions.Where(x => x.CategoryId == id)
                .Include(x => x.Choices).ToList();
            return View(questions);
        }
        [HttpPost]
        public IActionResult SubmitAnswers(Dictionary<int,string> answers)
        {
            int score = 0;
            
            foreach (var answer in answers)
            {
                int questionid = answer.Key;
                string selectedanswer = answer.Value;

                var question = context.Questions.Where(x => x.Id == questionid).FirstOrDefault();
                
                if(question != null && question.CorrectAnswer == selectedanswer)
                {
                    score++;
                }
            }
            ViewBag.Score = score;
            
          
            return View();
        }
    }
}
