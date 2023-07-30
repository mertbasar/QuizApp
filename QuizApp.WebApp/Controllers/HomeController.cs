using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuizApp.Business.CategoryManagers;
using QuizApp.Business.QuestionManagers;
using QuizApp.Business.QuizManagers;
using QuizApp.Domain;
using QuizApp.Dto.QuestionDtos;
using QuizApp.Dto.QuizDtos;
using QuizApp.WebApp.Models;
using System.Diagnostics;

namespace QuizApp.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IQuizService _quizService;
        private readonly IQuestionService _questionService;

        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService, IQuizService quizService ,IQuestionService questionService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _quizService = quizService;
            _questionService = questionService;
        }

        public IActionResult Index()
        {
            {
                return View(_categoryService.GetSummaries());
            }
        }
        public IActionResult QuizChoose(int id)
        {
            return View(_quizService.GetByCategoryId(id));
        }
        public IActionResult QuestionChoose(int quizId)
        {
            {
                var questions = _questionService.GetQuestionById(quizId);

                var viewModel = new QuestionChooseViewModel
                {
                    QuizId = quizId,
                    Questions = questions,
                    CurrentQuestionIndex = 0 // Başlangıçta 0 olarak tanımlıyoruz
                };

                return View(viewModel);
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
