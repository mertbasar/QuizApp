using QuizApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.Validators.Generics
{
    public class CategoryValidator : IValidator<Category>
    {
        public ValidationResult Validate(Category entity)
        {
            var result = new ValidationResult();
            if (entity.Name == null)
            {
                result.Messages.Add("Kategori adı girmeniz gerekir");
            }
            return result;
        }
    }
}
