using QuizApp.Dto.QuizDtos;
using QuizApp.Domain;
using System.Collections.Generic;
using System.Linq;
using QuizApp.Dto.CategoryDtos;
using QuizApp.Dto.QuestionDtos;
using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.Business.Generics;
using QuizApp.Business.Validators.Generics;
using System.Linq.Expressions;
using System.Diagnostics;

namespace QuizApp.Business.QuizManagers
{
    public class QuizService : GenericService<QuizDto, QuizSummary, Quiz>, IQuizService
    {

        public QuizService(QuizDbContext dbContext, QuizValidator validator) : base(dbContext, validator)
        {
        }

        protected override Expression<Func<Quiz, QuizDto>> DtoMapper =>
            entity => new QuizDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                QuestionCount = entity.Questions.Count(),
                Description = entity.Description,
                categoryId = entity.CategoryId,
                CategoryName = entity.Category.Name


            };

        protected override Expression<Func<Quiz, QuizSummary>> SummaryMapper =>
            entity => new QuizSummary()
            {
                Id = entity.Id,
                Name = entity.Name,
                QuestionCount = entity.Questions.Count(),
                Description = entity.Description,
                CategoryName = entity.Category.Name
            };

        public IEnumerable<QuizDto> GetByCategoryId(int categoryId)
        {
            try
            {
                return _dbContext.Quizzes.Where(entity => entity.CategoryId == categoryId).Select(DtoMapper).ToList();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return Enumerable.Empty<QuizDto>();
            }
        }
        protected override Quiz MapToEntity(QuizDto entity)
        {
            return new Quiz()
            {
                Id = entity.Id,
                CreatedAt = DateTime.Now,
                Description = entity.Description,
                Name = entity.Name,
                CategoryId = entity.categoryId,
            };
        }
        public QuizDto GetQuizById(int id)
        {
            var quiz = _dbContext.Quizzes.FirstOrDefault(q => q.Id == id);

            if (quiz == null)
            {
                // Eğer quiz bulunamazsa null dönebilirsiniz veya hata işlemleri yapabilirsiniz
                return null;
            }

            return new QuizDto
            {
                Id = quiz.Id,
                Name = quiz.Name,
                Description = quiz.Description,
                // Diğer özellikleri de DTO'ya ekleyebilirsiniz
            };
        }
    }
}