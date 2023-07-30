using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dto.AnswerDtos
{
    public class AnswerSummary
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public string Question { get; set; }
        public string QuizName { get; set; }
        public string CategoryName { get; set; }
        public int QuizId { get; set; }
        public int CategoryId { get; set; }
        public int QuestionId { get; set; }
    }
}
