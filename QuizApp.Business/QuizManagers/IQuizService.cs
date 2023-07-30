using QuizApp.Business.Generics;
using QuizApp.Domain;
using QuizApp.Dto.QuizDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.QuizManagers
{
    public interface IQuizService :IGenericService<QuizDto,QuizSummary>
    {
        IEnumerable<QuizDto> GetByCategoryId(int categoryId);
        QuizDto GetQuizById(int id);

    }
}
