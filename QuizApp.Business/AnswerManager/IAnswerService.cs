using QuizApp.Business.Generics;
using QuizApp.Domain;
using QuizApp.Dto.AnswerDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.AnswerManager
{
    public interface IAnswerService:IGenericService<AnswerDto,AnswerSummary>  
    {

        IEnumerable<Answer> GetAnswersByQuestion(int questionId);
    }

}
