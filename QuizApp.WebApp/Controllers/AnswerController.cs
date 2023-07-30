using Microsoft.AspNetCore.Mvc;
using QuizApp.Business.AnswerManager;
using QuizApp.Business.CategoryManagers;
using QuizApp.Business.QuestionManagers;
using QuizApp.Business.QuizManagers;
using QuizApp.Domain;
using QuizApp.Dto.AnswerDtos;
using QuizApp.Dto.QuestionDtos;
using QuizApp.WebApp.Models;

namespace QuizApp.WebApp.Controllers
{
    public class AnswerController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IQuizService _quizService;
        private readonly IQuestionService _questionService;
        private readonly IAnswerService _answerService;

        public AnswerController(ICategoryService categoryService, IQuizService quizService, IQuestionService questionService,IAnswerService answerService)
        {
            _categoryService = categoryService;
            _quizService = quizService;
            _questionService = questionService;
            _answerService = answerService;
        }

        public IActionResult Index()
        {
            return View(_answerService.GetSummaries());
        }

        public IActionResult Show(int id)
        {
            // Soruyu ve cevapları veritabanından alalım
            var question = _questionService.GetById(id);

            if (question == null)
            {
                return NotFound(); // Soru bulunamazsa 404 döndürüyoruz
            }

            var answers = _answerService.GetAnswersByQuestion(id);

            // QuestionDto'ya dönüştürme işlemi
            var questionDto = new QuestionDto
            {
                Id = question.Id,
                Text = question.Text,
                Answers = answers.Select(answer => new AnswerDto
                {
                    Id = answer.Id,
                    Text = answer.Text,
                    IsCorrect = answer.IsCorrect
                }).ToList()
            };

            return View(questionDto); // View'e QuestionDto'yu gönderiyoruz
        }
        [HttpGet]
        public IActionResult AddAnswer(int Id)
        {
            var question = _questionService.GetById(Id);
            if (question == null)
            {
                return NotFound();
            }

            var answerDto = new AnswerDto
            {
                QuestionId = question.Id
            };

            return View(answerDto);
        }
        [HttpPost]
        public IActionResult AddAnswer(AnswerDto answerDto)
        {
            if (ModelState.IsValid)
            {
                // AnswerDto'yu Answer entity'sine dönüştürüyoruz

                // Cevabı veritabanına ekliyoruz
                _answerService.Create(answerDto);

                return RedirectToAction("Show", "Question", new { id = answerDto.QuestionId });
            }

            // Eğer ModelState geçerli değilse, View'ı tekrar gösteriyoruz
            return View(answerDto);
        }

        public IActionResult Delete(int id)
        {
            if (id == 0) return Json("Bu boş.");
            var result = _answerService.Delete(id);
            return Json(result.Message);
        }
        public IActionResult Edit(int id)
        {
            var answer = _answerService.GetById(id);
            if (answer == null)
            {
                return NotFound();
            }

            var question = _questionService.GetById(answer.QuestionId);
            if (question == null)
            {
                return NotFound();
            }

            var answerViewModel = new AnswerViewModel
            {
                Id = question.Id,
                Text = question.Text,
                Answer = new AnswerDto
                {
                    Id = answer.Id,
                    Text = answer.Text,
                    IsCorrect = answer.IsCorrect
                }
            };

            return View(answerViewModel);
        }

        [HttpPost]
        public IActionResult Edit(AnswerViewModel answerViewModel)
        {
            if (ModelState.IsValid)
            {
                var answer = _answerService.GetById(answerViewModel.Id);
                if (answer == null)
                {
                    return NotFound();
                }

                answer.Text = answerViewModel.Text;
                answer.IsCorrect = answerViewModel.IsCorrect;

                _answerService.Update(answer);

                return RedirectToAction("Index", "Question"); // veya farklı bir sayfaya yönlendirin
            }

            // Eğer ModelState geçersizse, tekrar düzenleme sayfasını gösterin
            // Aynı zamanda, seçenekleri tekrar doldurun.
            var question = _questionService.GetById(answerViewModel.Id);
            if (question == null)
            {
                return NotFound();
            }

            answerViewModel.Text = question.Text;

            return View(answerViewModel);
        }
    

}
}

