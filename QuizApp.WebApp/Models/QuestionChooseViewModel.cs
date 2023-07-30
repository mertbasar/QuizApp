using QuizApp.Dto.QuestionDtos;

namespace QuizApp.WebApp.Models
{
    public class QuestionChooseViewModel
    {
        public int QuizId { get; set; }
        public IEnumerable<QuestionDto> Questions { get; set; }
        public int CurrentQuestionIndex { get; set; }
    }
}
