using QuizApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.Validators.Generics
{
    public interface IValidator<TEntity>
        where TEntity : class, IEntity, new()
    {
        ValidationResult Validate(TEntity entity);
    }
}
