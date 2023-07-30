using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.Generics
{
    public interface IGenericService<TDto, TSummary>
    {
        CommandResult Create(TDto dto);
        CommandResult Update(TDto dto);
        CommandResult Delete(TDto dto);
        CommandResult Delete(int id);
        TDto? GetById(int id);
        IEnumerable<TDto> GetAll();
        TSummary? GetSummaryById(int id);
        IEnumerable<TSummary> GetSummaries();
    }

}
