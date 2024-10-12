using Microsoft.AspNetCore.Mvc;
using OnlineQuiz.Models;
using System.Diagnostics;

namespace OnlineQuiz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly QuizContext context;
       

        public HomeController(ILogger<HomeController> logger , QuizContext _context)
        {
            _logger = logger;
            context = _context;
        }

        public IActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
