using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dto.QuestionDtos
{
    public class QuestionSummary
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public int QuizId { get; set; }

    }
}
