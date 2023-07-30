using Microsoft.EntityFrameworkCore;
using QuizApp.Business.Generics;
using QuizApp.Business.Validators.Generics;
using QuizApp.Data;
using QuizApp.Domain;
using QuizApp.Dto.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.CategoryManagers
{
    public class CategoryServices : GenericService<CategoryDto, CategorySummary, Category>,ICategoryService
    {

        public CategoryServices(QuizDbContext context,CategoryValidator categoryValidator):base(context,categoryValidator) { }
        protected override Expression<Func<Category, CategoryDto>> DtoMapper => 
            entity => new CategoryDto()
            {
                Id = entity.Id,
                Name = entity.Name,
            };

        protected override Expression<Func<Category, CategorySummary>> SummaryMapper =>
            entity => new CategorySummary()
            {
                Id = entity.Id,
                Name = entity.Name,
            };   

        protected override Category MapToEntity(CategoryDto entity)
        {
            return new Category()
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }

}
