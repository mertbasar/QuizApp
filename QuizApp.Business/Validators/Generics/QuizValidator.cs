using QuizApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Business.Validators.Generics
{
    public class QuizValidator : IValidator<Quiz>
    {
        public ValidationResult Validate(Quiz entity)
        {
            var result = new ValidationResult();

            if (entity.Name == null)
            {
                result.Messages.Add("Başlık kısmı boş geçilemez.");
            }
            if (entity.CreatedAt == null)
            {
                result.Messages.Add("Oluşturma Tarihi kısmı boş geçilemez.");
            }
            if (entity.Description == null)
            {
                result.Messages.Add("Açıklama kısmı boş geçilemez.");
            }
            return result;
        }
    }
}
