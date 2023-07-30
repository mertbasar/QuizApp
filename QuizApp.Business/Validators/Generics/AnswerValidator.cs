using QuizApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.Validators.Generics
{
    public class AnswerValidator : IValidator<Answer>
    {
        public ValidationResult Validate(Answer entity)
        {
            var result = new ValidationResult();
            if (entity.Question == null)
            {
                result.Messages.Add("Soru boş bırakılamaz");
            }
            if (entity.Text == null)
            {
                result.Messages.Add("Cevap alanı bol bırakılamaz");
            }
            return result;

        }
    }
}
