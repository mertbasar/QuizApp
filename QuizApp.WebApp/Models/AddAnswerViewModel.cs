using QuizApp.Dto.AnswerDtos;

namespace QuizApp.WebApp.Models
{
    public class AddAnswerViewModel
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public List<AnswerDto> Answers { get; set; }
        public string NewAnswerText { get; set; }
        public bool IsNewAnswerCorrect { get; set; }
    }
}
