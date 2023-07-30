using Microsoft.AspNetCore.Mvc;
using QuizApp.Business.CategoryManagers;
using QuizApp.Dto.CategoryDtos;
using QuizApp.WebApp.Models;

namespace QuizApp.WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var allCategories = _categoryService.GetAll();
            return View(allCategories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryViewModel categoryViewModel)
        {
            string vm = categoryViewModel.Kategori_Adi;
            var categoryDto = new CategoryDto()
            {
                Name = vm
            };
            var result = _categoryService.Create(categoryDto);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Ok();
            }
        }

        public IActionResult Update(int id)
        {
            var findedCategory = _categoryService.GetById(id);
            if (findedCategory != null)
            {
                return View(findedCategory);
            }
            else
            {
                return NotFound();
            }

        }
        [HttpPost]
        public IActionResult Update(CategoryDto categoryDto)
        {
            var result = _categoryService.Update(categoryDto);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Ok();
            }

        }
        [HttpPost]
        public IActionResult Delete(int id)
        {

            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            var result = _categoryService.Delete(id);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }


        }
    }
}
