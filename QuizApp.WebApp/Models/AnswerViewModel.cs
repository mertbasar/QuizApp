using QuizApp.Domain;
using QuizApp.Dto.AnswerDtos;

namespace QuizApp.WebApp.Models
{
    public class AnswerViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public AnswerDto Answer { get; set; }
    }
}
