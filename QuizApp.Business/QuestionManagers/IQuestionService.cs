using QuizApp.Business.Generics;
using QuizApp.Domain;
using QuizApp.Dto.QuestionDtos;
using QuizApp.Dto.QuizDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.QuestionManagers
{
    public interface IQuestionService :IGenericService<QuestionDto,QuestionSummary>
    {
        IEnumerable<QuestionDto> GetQuestionById(int questionId);

    }

}
