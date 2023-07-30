using Microsoft.EntityFrameworkCore;
using QuizApp.Business.Generics;
using QuizApp.Business.Validators.Generics;
using QuizApp.Data;
using QuizApp.Domain;
using QuizApp.Dto.AnswerDtos;
using QuizApp.Dto.QuestionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.QuestionManagers
{
    public class QuestionService : GenericService<QuestionDto, QuestionSummary, Question>, IQuestionService
    {
        public QuestionService(QuizDbContext dbContext, QuestionValidator validator) : base(dbContext, validator)
        {
        }

        protected override Expression<Func<Question, QuestionDto>> DtoMapper => 
            entity => new QuestionDto()
            {
                Id = entity.Id,
                Category = entity.Quiz.Category.Name,
                Description = entity.Quiz.Description,
                Title = entity.Quiz.Name,
                Text = entity.Text,
                CategoryId = entity.Quiz.Category.Id,
                QuizId = entity.Quiz.Id,
                //Answers = _dbContext.Answers.Where(x=> x.QuestionId == entity.Id).Select(x => new AnswerDto()
                //{
                //    Id=entity.Id,
                //    Text = entity.Text,
                //    IsCorrect = entity.Quiz.Answers.IsCorrect,
                //    QuizName = entity.Quiz.Name
                //} ).ToList()
            };

        protected override Expression<Func<Question, QuestionSummary>> SummaryMapper => 
            entity=> new QuestionSummary()
            {
                Id= entity.Id,
                Category= entity.Quiz.Category.Name,
                Description = entity.Quiz.Description,
                Title = entity.Quiz.Name,
                Text = entity.Text,
                CategoryId= entity.Quiz.Category.Id,
                QuizId= entity.Quiz.Id,
                
                
            };


        public IEnumerable<QuestionDto> GetQuestionById(int quizId)
        {
            {
                var questions = _dbContext.Questions
                    .Include(q => q.Answers)
                    .Where(q => q.QuizId == quizId )
                    .ToList();

                var questionDtos = questions.Select(q => new QuestionDto
                {
                    Id = q.Id,
                    Text = q.Text,
                    QuizId = q.QuizId,
                    Answers = q.Answers.Select(a => new AnswerDto
                    {
                        Id = a.Id,
                        Text = a.Text,
                        IsCorrect = a.IsCorrect,
                        QuestionId = a.Question.Id,
                        CategoryId = a.Question.Quiz.Category.Id,
                        CategoryName = a.Question.Quiz.Category.Name,
                        QuizId = a.Question.Quiz.Id,
                        QuizName = a.Question.Text
                    }).ToList()
                });

                return questionDtos;
            }
        }

        protected override Question MapToEntity(QuestionDto entity)
        {
            return new Question()
            {
                Id = entity.Id,
                Text = entity.Text,
                QuizId  = entity.QuizId
            };
        }
    }

}
