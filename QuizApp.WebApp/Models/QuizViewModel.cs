using QuizApp.Dto.QuizDtos;

namespace QuizApp.WebApp.Models
{
    public class QuizViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int QuestionCount { get; set; }
        public List<QuestionViewModel> Questions { get; set; }
        public CategoryViewModel Category { get; set; }
        public List<int> UserAnswers { get; set; }
    }
}
