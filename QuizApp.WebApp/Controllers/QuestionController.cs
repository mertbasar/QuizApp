using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuizApp.Business.CategoryManagers;
using QuizApp.Business.QuestionManagers;
using QuizApp.Business.QuizManagers;
using QuizApp.Dto.QuestionDtos;
using QuizApp.Dto.QuizDtos;
using QuizApp.WebApp.Models;

namespace QuizApp.WebApp.Controllers
{
    public class QuestionController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IQuizService _quizService;
        private readonly IQuestionService _questionService;

        public QuestionController(ICategoryService categoryService, IQuizService quizService, IQuestionService questionService)
        {
            _categoryService = categoryService;
            _quizService = quizService;
            _questionService = questionService;
        }

        public IActionResult Index()
        {
            return View(_questionService.GetSummaries());
        }
        public IActionResult Create()
        {
            var categoryList = _categoryService.GetAll();
            ViewBag.CategoryList = new SelectList(categoryList, "Id", "Name");
            var quizList = _quizService.GetAll();
            ViewBag.QuizList = new SelectList(quizList, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(QuestionDto qdo)
        {
            if (qdo == null)
            {
                return Json("Ekleme işlemi başarısız,model boş");
            }
            var result = _questionService.Create(qdo);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var que = _questionService.GetById(id);
            if (que == null)
            {
                return NotFound();
            }
            var categoryList = _categoryService.GetAll();
            ViewBag.CategoryList = new SelectList(
                categoryList,
                "Id",
                "Name",
                que.CategoryId);
            var quizList = _quizService.GetByCategoryId(que.CategoryId);
            ViewBag.QuizList = new SelectList(
                quizList,
                "Id",
                "Name");
            return View(que);
        }
        [HttpPost]
        public IActionResult Edit(QuizDto qto)
        {
            if (qto == null) return Ok();
            var result = _quizService.Update(qto);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var categoryList = _categoryService.GetAll();
                ViewBag.MakeList = new SelectList(
                    categoryList,
                    "Id",
                    "Name",
                    qto.categoryId);


                return View(qto);
            }
        }
        public IActionResult Delete(int id)
        {
            if (id == 0) return Json("Bu boş la");
            var result = _questionService.Delete(id);
            return Json(result.Message);
        }
        public IActionResult QuestionChoose(int id)
        {
            var questions = _questionService.GetQuestionById(id);

            var viewModel = new QuestionChooseViewModel
            {
                QuizId = id,
                Questions = questions
                
            };

            return View(viewModel);
        }


    }
}
