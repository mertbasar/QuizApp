using QuizApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.Validators.Generics
{
    public class QuestionValidator : IValidator<Question>
    {
        public ValidationResult Validate(Question entity)
        {
            var result = new ValidationResult();
            if (entity.Text == null)
            {
                result.Messages.Add("Soru boş bırakılamaz");
            }
            return result;

        }
    }
}
