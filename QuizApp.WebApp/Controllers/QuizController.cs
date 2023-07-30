using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuizApp.Business.CategoryManagers;
using QuizApp.Business.QuizManagers;
using QuizApp.Dto.QuizDtos;

namespace QuizApp.WebApp.Controllers
{
    public class QuizController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IQuizService _quizService;
        public QuizController(ICategoryService categoryService, IQuizService quizService)
        {
            _categoryService = categoryService;
            _quizService = quizService;
            
        }
        public IActionResult Index()
        {
            return View(_quizService.GetSummaries());

        }
        private void FillCategoryList()
        {
            var category = _categoryService.GetAll();

            ViewBag.CategorySelectList = new SelectList(category, "Id", "Name");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _quizService.Delete(id);
            return Json(result.Message);
        }
        public IActionResult GetQuizById(int categoryId)
        {
            var quizId = _quizService.GetByCategoryId(categoryId);
            return Json(quizId);
        }
        public IActionResult Create()

        {
            FillCategoryList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(QuizDto qdto)
        {
            if (qdto.Name == null)
            {
                FillCategoryList();

                return View();
            }
            var result = _quizService.Create(qdto);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                FillCategoryList();
                return View();
            }
        }
        public IActionResult Edit(int id)
        {
            FillCategoryList();
            var quiz = _quizService.GetById(id);

            return View(quiz);
        }
        [HttpPost]
        public IActionResult Edit(QuizDto qto)
        {
            var result = _quizService.Update(qto);
            if (result.IsSuccess)
            {
                return RedirectToAction(nameof(Index));
            }

            else
            {
                FillCategoryList();
                return View(qto);
            }
        }
    }
}
