using Microsoft.EntityFrameworkCore;
using QuizApp.Business.Generics;
using QuizApp.Business.Validators.Generics;
using QuizApp.Data;
using QuizApp.Domain;
using QuizApp.Dto.AnswerDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.AnswerManager
{
    public class AnswerService : GenericService<AnswerDto, AnswerSummary, Answer>, IAnswerService
    {
        public AnswerService(QuizDbContext dbContext, AnswerValidator validator) : base(dbContext, validator)
        {
        }

        protected override Expression<Func<Answer, AnswerDto>> DtoMapper => 
            entity => new AnswerDto()
            {
                Id = entity.Id,
                CategoryName = entity.Question.Quiz.Category.Name,
                Question = entity.Question.Text,
                CategoryId = entity.Question.Quiz.Category.Id,
                QuestionId = entity.Question.Id,
                QuizId = entity.Question.Quiz.Id,
                IsCorrect = entity.IsCorrect,
                QuizName = entity.Question.Quiz.Name,
                Text = entity.Text
            }
            ;

        protected override Expression<Func<Answer, AnswerSummary>> SummaryMapper => 
            entity => new AnswerSummary()
            {
                CategoryId = entity.Question.Quiz.Category.Id,
                CategoryName = entity.Question.Quiz.Category.Name,
                Id = entity.Id,
                IsCorrect = entity.IsCorrect,
                Question = entity.Question.Text,
                QuestionId = entity.Question.Id,
                QuizId = entity.Question.Quiz.Id,
                QuizName = entity.Question.Quiz.Name,
                Text = entity.Text
            };

        public IEnumerable<Answer> GetAnswersByQuestion(int questionId)
        {
            return _dbContext.Set<Answer>().Where(a => a.Question.Id == questionId).ToList();
        }

        protected override Answer MapToEntity(AnswerDto entity)
        {
            return new Answer()
            {
                Id = entity.Id,
                IsCorrect = entity.IsCorrect,
                Text = entity.Text,
                QuestionId = entity.QuestionId
            };
        }
    }

}
