using QuizApp.Business.Generics;
using QuizApp.Domain;
using QuizApp.Dto.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.CategoryManagers
{
    public interface ICategoryService : IGenericService<CategoryDto,CategorySummary>
    {
    }

}
